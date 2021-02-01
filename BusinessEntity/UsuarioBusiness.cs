using System;
using System.Collections.Generic;

namespace BusinessEntity
{
    // Business stuff
    public partial class Usuario
    {
        public List<Notificacion> notificaciones;
        public List<Objetivo> objetivosNoCumplidos;
        public Sector sector;
        public Puesto puesto;
        public DateTime fechaEntrada;
    }
}