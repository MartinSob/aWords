using System;

namespace BusinessEntity {
    public class Reconocimiento {
        public int id;
        public Usuario reconocedor;
        public Usuario reconocido;
        public string descripcion;
        public DateTime fecha;
        public Emblema emblema;
        public int valoracion;
	}
}