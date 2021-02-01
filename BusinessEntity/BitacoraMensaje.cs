using System;

namespace BusinessEntity
{
    public class BitacoraMensaje
    {
        public int id;
        public DateTime fecha;
        public string titulo;
        public string descripcion;
        public Tipo tipo;
        public Usuario usuario;
    }

    public enum Tipo
    {
        Info,
        Error,
        Warning,
        Control
    }
}
