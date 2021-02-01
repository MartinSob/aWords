using BusinessEntity;
using Persistence.Negocio;
using Security;
using System.Collections.Generic;

namespace BusinessLogic {
	public static class SectorManager {
		static SectorDao dao = new SectorDao();

		public static List<KeyValuePair<Puesto, Usuario>> obtenerPuestos(Sector sec) {
			if (sec.puestos == null || sec.puestos.Count == 0) {
				sec.puestos = dao.obtenerPuestos(sec.id);
			}
			return sec.puestos;
		}

		public static Usuario obtenerJefe(Sector sec) {
			if (sec.jefe == null) {
				sec.jefe = dao.obtenerJefe(sec.id);
			}
			return sec.jefe;
		}

		public static Sector obtener(int id) {
			return dao.obtener(id);
		}

		public static Sector obtener(Usuario us) {
			if (us.sector == null) {
				us.sector = dao.obtener(us);
			}
			return us.sector;
		}

		public static void crear(Sector sec) {
			dao.crear(sec);

			if (sec.jefe != null) {
				List<Familia> jefeFamilia = PermisosManager.obtenerFamilia("jefe");

				if(jefeFamilia.Count > 0) {
					PermisosManager.modificarFamilia(sec.jefe, jefeFamilia[0]);
				}
			}

			BitacoraManager.agregarMensajeControl("Sector creado: ", sec);
		}

		public static void actualizar(Sector sec) {
			dao.actualizar(sec);

			BitacoraManager.agregarMensajeControl("Sector actualizado: ", sec);
		}

		public static void borrar(int id) {
			dao.borrar(id);

			BitacoraManager.agregarMensajeControl("Sector borrado: ", new Sector { id = id });
		}

		public static List<Sector> obtener(string name = null) {
			return dao.obtener(name);
		}

		public static List<Usuario> obtenerTrabajadores(Sector sec) {
			return dao.obtenerTrabajadores(sec.id);
		}

		public static bool verSiExiste(string nombre) {
			return dao.verSiExiste(nombre);
		}
	}
}
