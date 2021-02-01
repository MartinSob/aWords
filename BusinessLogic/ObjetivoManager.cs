using BusinessEntity;
using Persistence.Negocio;
using Security;
using System;
using System.Collections.Generic;

namespace BusinessLogic {
	public static class ObjetivoManager {
        static ObjetivoDao dao = new ObjetivoDao();

		public static Objetivo obtener(int id) {
			return dao.obtener(id);
		}

        public static Usuario obtenerEmpleado(Objetivo obj) {
			if (obj.empleado == null) {
                obj.empleado = dao.obtenerEmpleado(obj);
			}

			return obj.empleado;
		}

        // TODO
		//public static Sector obtenerSector(Objetivo objetivo) {
		//	if (objetivo.sector == null) {
  //              objetivo.sector = dao.obtenerSector(objetivo.id);
		//	}

		//	return objetivo.sector;
		//}

        public static List<Objetivo> obtenerAbiertos(Sector sec) {
            return dao.obtenerAbiertos(sec);
        } 

        public static List<Objetivo> obtenerAbiertos(Usuario us) {
            return dao.obtenerAbiertos(us);
        } 

        // Devuelve los cerrados no archivados
		public static List<Objetivo> obtenerCerrados(Sector sec) {
			return dao.obtenerCerradosNoArchivados(sec);
		}

        public static List<Objetivo> obtenerFinalizados(Usuario us) {
			return dao.obtenerFinalizados(us);
		}

		public static bool asignarEmpleado(Objetivo obj, int empl) {
            if (obtenerEmpleado(obj) != null) {
                return false;
            }
            
            bool result = dao.asignarTrabajador(obj.id, empl);

            if(result) {
                obj.empleado = new Usuario {
                    id = empl
                };

                NotificacionManager.enviar(
                    new Notificacion(Sesion.obtenerSesion().idioma.textos["new_objective"] + ": " + obj.descripcion, obj.empleado)
                );
			}

            return result;
        }

		public static int crear(Objetivo obj) {
            obj.id = dao.crear(obj);
            DV.actualizarDV();

            BitacoraManager.agregarMensajeControl("Nuevo objetivo", obj);

            return obj.id;
		}

        public static void finalizar(Objetivo obj) {
            dao.finalizar(obj.id);
            DV.actualizarDV();

            BitacoraManager.agregarMensajeControl("Objetivo actualizado: Finalizado", obj);
        }

        public static void archivar(Objetivo obj) {
            dao.archivar(obj.id);
            DV.actualizarDV();

            BitacoraManager.agregarMensajeControl("Objetivo actualizado: Archivado", obj);
        }

        public static int noFinalizado(Objetivo obj) {
            dao.noFinalizado(obj.id);

            BitacoraManager.agregarMensajeControl("Objetivo actualizado: No Finalizado", obj);

            ObjetivoNoCumplido objetivo = new ObjetivoNoCumplido(obj, "not_fixed");

            return agregarNoCumplido(objetivo);
        }

        public static int agregarNoCumplido(ObjetivoNoCumplido obj) {
            int id = dao.agregarNoCumplido(obj);
            DV.actualizarDV();

            NotificacionManager.enviar(
                new Notificacion(Sesion.obtenerSesion().idioma.textos["failed_objective"] + ": " + obj.descripcion, obj.empleado)
            );
            
            return id;
        }

        // TODO
        //public static List<Objetivo> obtener(Usuario usuario) {
        //    return dao.obtener(usuario);
        //}
	
        // Devuelve una lista de objetivos que no tienen un objetivo_fallido para ese usuario-objetivo
        public static List<Objetivo> objetivosCumplidos(Usuario us) {
            return dao.objetivosCumplidos(us);
        }

        // Devuelve los objetivos no cumplidos en los dos ultimos meses
        public static List<Objetivo> ultimosObjetivosNoCumplidos(Usuario us) {
            return dao.ultimosObjetivosNoCumplidos(us);
        }
    }
}
