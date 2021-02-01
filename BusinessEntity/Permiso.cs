using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity {
	public abstract class Permiso {
        public int id;
        public string nombre;

		// Devolverá si el rol tiene o no una cierta patente
		public abstract bool tienePermiso(string permiso);
	}
}
