using BusinessEntity;
using Persistence.Negocio;
using Security;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace BusinessLogic {
	public static class EmblemaManager {
		static EmblemaDao dao = new EmblemaDao();

		public static List<Emblema> obtener(int id = 0) {
			return dao.obtener(id);
		}

		public static List<Emblema> obtener(Usuario us, int limit = 0) {
			return dao.obtenerRecibidos(us, limit);
		}

		public static int obtener(Usuario us, Emblema em) {
			return dao.obtenerRecibidos(us, em);
		}

		public static void crear(string nombre) {
			Emblema em = new Emblema {
				id = dao.crear(nombre),
				nombre = nombre
			};

			BitacoraManager.agregarMensajeControl("Nuevo emblema", em);
		}

		public static void actualizar(Emblema em) {
			dao.actualizar(em);

			BitacoraManager.agregarMensajeControl("Cambio emblema", em);
		}

		public static void borrar(int id) {
			dao.borrar(id);

			BitacoraManager.agregarMensajeControl("Borrado emblema", id);
		}

		public static bool verSiExiste(string nombre) {
			return dao.verSiExiste(nombre);
		}
	}
}
