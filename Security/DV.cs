using BusinessEntity;
using Persistence;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Security {
    public static class DV {
		static List<string> errores = new List<string>();
		static DVDao dao = new DVDao();

		public static bool verificarDVH(string tabla) {
			List<string> rows = dao.verificarDVH(tabla);

			if(rows.Count == 0) {
				return true;
			}

			string errorMsg = Sesion.obtenerSesion().idioma.textos["dvh_table"] + tabla;
			errores.Add(errorMsg);

			foreach (string row in rows) {
				errorMsg = Sesion.obtenerSesion().idioma.textos["error_row"] + row;
				errores.Add(errorMsg);
				BitacoraManager.agregarMensaje(new BitacoraMensaje {
					titulo = "Error DVV en BD", 
					descripcion = errorMsg, 
					tipo = Tipo.Error, 
					fecha = DateTime.Now,
					usuario = Sesion.obtenerSesion().usuario
				});
			}

			return false;
		}

		public static bool verificarDV() {
			bool ok = true;

			foreach (string tabla in dao.obtenerTablas()) {
				if (!dao.verificarDVV(tabla)) {
					ok = false;
					string errorMsg = Sesion.obtenerSesion().idioma.textos["dvv_table"] + tabla;
					errores.Add(errorMsg);

					BitacoraManager.agregarMensaje(new BitacoraMensaje {
						titulo = "Error DVV en BD", 
						descripcion = errorMsg, 
						tipo = Tipo.Error,
						fecha = DateTime.Now,
						usuario = Sesion.obtenerSesion().usuario
					});
				}
				if (!verificarDVH(tabla)) {
					ok = false;
				}
			}

			return ok;
		}

		public static string obtenerErrores() {
			var result = new System.Text.StringBuilder();
			foreach(string error in errores) {
				result.Append(error + "\n");
			}

			return result.ToString();
		}

		public static async void actualizarDV() {
			await Task.Run(() => {
				try {
					DV.borrarErrores();

					foreach (string tabla in dao.obtenerTablas()) {
						dao.actualizarDVH(tabla);
						dao.actualizarDVV(tabla);
					}

					BitacoraManager.agregarMensaje(new BitacoraMensaje {
						titulo = "Digitos verificadores",
						descripcion = "Los Digitos verificadores se han actualizado",
						tipo = Tipo.Info,
						usuario = Sesion.obtenerSesion().usuario
					});
				} catch (Exception ex) {
					Console.WriteLine(ex);
				}
			});
		}

		private static void borrarErrores() {
			errores.Clear();
		}
	}
}
