using System;

namespace BusinessEntity {
    public class Notificacion {
        public int id;
        public DateTime fechaCreacion;
        public bool leido;
        public string texto;
        public Usuario usuario;

        public Notificacion(string texto, Usuario usuario) {
            this.texto = texto;
            this.usuario = usuario;
        }

        public Notificacion() {  }
    }
}