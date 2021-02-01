using System;
using BusinessEntity;
using Persistence.Negocio;
using System.Collections.Generic;

namespace BusinessLogic {
	public static class NotificacionManager {
        static NotificacionDao dao = new NotificacionDao();

		public static List<Notificacion> obtener(Usuario us) {
			return dao.obtener(us);
		}

		public static int obtenerCantidad(Usuario us) {
            return dao.obtenerCantidad(us);
		}

		public static void enviar(Notificacion not) {
            dao.crear(not);
		}

		public static void leerTodas(Usuario us) {
            dao.leerTodas(us);
		}
	}
}
