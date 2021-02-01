using System;

namespace BusinessEntity {
	// Security stuff
	public partial class Usuario {
        public int id;
        public string nombreUsuario;
        public string nombre;
        public string apellido;
        public string mail;
        public Permiso permiso = null;

		public string NombreCompleto { get { return $"{apellido}, {nombre}"; } }
	}
}
