using System;

namespace BusinessEntity
{
    public class Sesion
    {
		public Usuario usuario;
		public Idioma idioma = new Idioma();
		private static Sesion sesion;

		private Sesion() {} 

		public static Sesion obtenerSesion() {
			if ( sesion == null ) {
				sesion = new Sesion();
			}
			return sesion;
		}
	}
}
