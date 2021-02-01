using BusinessEntity;
using Persistence;
using Persistence.Negocio;
using Security;
using System.Collections.Generic;

namespace BusinessLogic {
	public static class TrabajadorManager {
		static UsuarioDao dao = new UsuarioDao();

		public static Sector obtenerSector(Usuario us) {
			if(us.sector == null) {
				us.sector = SectorManager.obtener(us);
			}
			return us.sector;
		}

		public static List<Sector> obtenerSectorJefes(Usuario us) {
			SectorDao sectorDao = new SectorDao();
			return sectorDao.obtenerPorJefeId(us.id);
		}

		// TODO
		public static int crear(Usuario us) {
			if (UsuarioManager.crear(us) == 0) {
				return 0;
			}

			dao.agregarPuesto(us);

			DV.actualizarDV();
			return us.id;
		}

		public static void actualizar(Usuario us) {
			UsuarioManager.actualizar(us);
			dao.agregarPuesto(us);

			DV.actualizarDV();
		}

	}
}
