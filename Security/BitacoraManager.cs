using BusinessEntity;
using Persistence;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Security {
	public static class BitacoraManager {
		static BitacoraDao dao = new BitacoraDao();

		public static List<BitacoraMensaje> obtener(DateTime desde, DateTime hasta, string tipo = null) {
			return dao.obtener(desde, hasta, tipo);
        }

		public static int agregarMensaje(BitacoraMensaje mensaje) {
			return dao.agregarMensaje(mensaje);
        }

		public static int agregarMensajeControl(string title, object obj) {
			return dao.agregarMensaje(new BitacoraMensaje {
				usuario = Sesion.obtenerSesion().usuario,
				tipo = Tipo.Control,
				titulo = title,
				descripcion = JsonConvert.SerializeObject(obj)
			});
		}

		public static string FormatJson(string json) {
			var result = json;
			try {
				dynamic parsedJson = JsonConvert.DeserializeObject(json);
				result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
			} catch (Exception e) {
				Console.WriteLine(e);
			}

			return result;
		}
	}
}
