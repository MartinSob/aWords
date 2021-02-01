using BusinessEntity;
using Persistence.Negocio;
using Security;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic {
	public static class PuestoManager {
		static PuestoDao dao = new PuestoDao();

		public static List<Puesto> obtener() {
			return dao.obtener();
		}

		public static Puesto obtener(int id) {
			return dao.obtener(id).ElementAt(0);
		}

		public static void crear(Puesto puesto) {
			dao.crear(puesto);

			BitacoraManager.agregarMensajeControl("Puesto creado: ", puesto);
		}

		public static void actualizar(Puesto puesto) {
			dao.actualizar(puesto);

			BitacoraManager.agregarMensajeControl("Puesto actualizado: ", puesto);
		}

		public static void borrar(int id) {
			dao.borrar(id);

			BitacoraManager.agregarMensajeControl("Puesto borrado: ", new Puesto { id = id });
		}

		public static Puesto obtener(Usuario us) {
			if (us.puesto == null) {
				us.puesto = dao.obtener(us);
			}
			return us.puesto;
		}
	}
}
