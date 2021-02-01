using BusinessEntity;
using Persistence.Negocio;
using Security;
using System;
using System.Collections.Generic;

namespace BusinessLogic {
	public static class ReconocimientoManager {
		static ReconocimientoDao dao = new ReconocimientoDao();

		public static Usuario obtenerReconocedor(Reconocimiento rec) {
			if(rec.reconocedor == null) {
				rec.reconocedor = dao.obtenerReconocedor(rec);
			}
			return rec.reconocedor;
		}

		public static Usuario obtenerReconocido(Reconocimiento rec) {
			if (rec.reconocido == null) {
				rec.reconocido = dao.obtenerReconocido(rec);
			}
			return rec.reconocido;
		}

		// TODO
		//public static Emblema obtenerEmblema(Reconocimiento reconocimiento) {
		//	if (reconocimiento.emblema == null) {
		//		reconocimiento.emblema = dao.obtenerEmblema(reconocimiento);
		//	}
		//	return reconocimiento.emblema;
		//}

		public static int crear(Reconocimiento rec) {
			int valoracionReconocedor = PuestoManager.obtener(rec.reconocedor).valoracion;
			int valoracionReconocido = PuestoManager.obtener(rec.reconocido).valoracion;

			rec.valoracion = valoracionReconocedor / valoracionReconocido;

			//if (TrabajadorManager.obtenerSectorJefes(rec.reconocedor).Count > 0) {
			//	rec.valoracion++;
			//}

			rec.fecha = DateTime.Now;

			int result = dao.crear(rec);
			BitacoraManager.agregarMensajeControl("Reconocimiento creado: ", rec);

			NotificacionManager.enviar(new Notificacion {
				texto = "Te han reconocido",
				usuario = rec.reconocido
			});

			DV.actualizarDV();

			return result;
		}

		public static List<Reconocimiento> obtener(int id = 0) {
			return dao.obtener(id);
		}

		public static List<Reconocimiento> obtenerRecibidos(Usuario us, int limit = 0) {
			return dao.obtenerRecibidos(us, limit);
		}

		public static List<Reconocimiento> obtenerEnviados(Usuario us, int limit = 0) {
			return dao.obtenerEnviados(us, limit);
		}

		public static void borrar(Reconocimiento rec) {
			dao.borrar(rec.id);
			DV.actualizarDV();

			BitacoraManager.agregarMensajeControl("Reconocimiento borrado: ", rec);
		}

		public static List<Reconocimiento> obtenerRecibidosDeSuperiores(Usuario us) {
			return dao.obtenerRecibidosDeSuperiores(us);
		}

		public static List<Reconocimiento> obtenerUltimosRecibidos(Usuario us) {
			return dao.obtenerUltimosRecibidos(us);
		}
	}
}
