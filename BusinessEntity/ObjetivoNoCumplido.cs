using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
	public class ObjetivoNoCumplido : Objetivo {
        public string tipo;

		public ObjetivoNoCumplido(Objetivo o, string tipo) {
            id = o.id;
            descripcion = o.descripcion;
            nivelIssue = o.nivelIssue;
            empleado = o.empleado;
            sector = o.sector;
            fechaCreacion = o.fechaCreacion;
            fechaAsignacion = o.fechaAsignacion;
            fechaFin = o.fechaFin;
            fechaCerrarAntesDe = o.fechaCerrarAntesDe;
            archivado = o.archivado;
        }
	}
}
