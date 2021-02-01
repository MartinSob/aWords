using System.Collections.Generic;

namespace BusinessEntity {
	public class Sector {
        public int id = 0;
        public string nombre;
        public int nivel = 1;
        // Dictionaries wont work because there may be duplicated keys (positions)
        public List<KeyValuePair<Puesto, Usuario>> puestos = new List<KeyValuePair<Puesto, Usuario>>();
        public Usuario jefe;
	}
}
