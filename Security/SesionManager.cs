using System;
using System.Threading;
using BusinessEntity;
using Persistence;

namespace Security
{
    public static class SesionManager {
		static UsuarioDao dao = new UsuarioDao();

		public static bool iniciarSesion(string nombreUsuario, string password) {
			Usuario user = dao.login(nombreUsuario, Encriptador.encriptar(password));

			if (user == null) {
				int intentosFallidos = dao.sumarIntentoFallido(nombreUsuario);

				if(intentosFallidos >= 5) {
					BitacoraManager.agregarMensaje(new BitacoraMensaje {
						titulo = "Intentos fallidos",
						descripcion = $"{nombreUsuario} ha intentado iniciar sesion {intentosFallidos} veces",
						tipo = Tipo.Warning,
						usuario = null
					});
				}
				return false;
			}

			dao.resetearIntentosFallidos(nombreUsuario);
			Sesion.obtenerSesion().usuario = user;
			return true;
        }

		public static bool cerrarSesion() {
			DV.actualizarDV();
			Thread.Sleep(2000);
			Sesion.obtenerSesion().usuario = null;
			return true;
        }

		public static bool estaLoggeado() {
			return Sesion.obtenerSesion().usuario != null;
		}
	}
}
