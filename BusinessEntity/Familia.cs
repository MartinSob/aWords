using System.Collections.Generic;

namespace BusinessEntity {
	public class Familia : Permiso {
        public List<Permiso> patentes;

		public override bool tienePermiso(string permiso) {
			foreach(Patente patente in patentes) {
				if (patente.tienePermiso(permiso)) {
					return true;
				}
			}

			return false;
		}
	}
}
