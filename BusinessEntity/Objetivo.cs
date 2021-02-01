using System;

namespace BusinessEntity {
    public class Objetivo {
        public int id;
        public string descripcion;
        public int nivelIssue = 0;
        public Usuario empleado;
        public Sector sector;
        public DateTime fechaCreacion;
        public DateTime? fechaAsignacion;
        public DateTime? fechaFin;
        public DateTime fechaCerrarAntesDe;
        public bool archivado = false;
    }
}