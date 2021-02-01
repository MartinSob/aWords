using BusinessEntity;
using Persistence;
using System;
using System.Collections.Generic;

namespace Security {

    public static class UsuarioManager {
		static UsuarioDao dao = new UsuarioDao();

		public static void actualizar(Usuario usuario) {
			dao.actualizar(usuario);
			PermisosManager.modificarFamilia(usuario, PermisosManager.obtenerFamilia(usuario));

			BitacoraManager.agregarMensajeControl("Usuario actualizado: ", usuario);

			DV.actualizarDV();
		}

		public static void eliminar(Usuario usuario) {
			dao.eliminar(usuario.id);
			DV.actualizarDV();

			BitacoraManager.agregarMensajeControl("Usuario Eliminado ", usuario);
		}

		public static int crear(Usuario usuario) {
			if (dao.obtenerPorNombreUsuario(usuario.nombreUsuario) != null) {
				return 0;
			}

			usuario.id = dao.crear( usuario, Encriptador.encriptar("123456"), PermisosManager.obtenerFamilia(usuario) );
			DV.actualizarDV();

			BitacoraManager.agregarMensajeControl("Usuario creado: ", usuario);

			return usuario.id;
		}

		public static bool actualizarPassword(Usuario usuario, string oldPass, string newPass) {
			if (dao.obtenerPasswordPorId(usuario.id).Equals(Encriptador.encriptar(oldPass))) {
				dao.actualizarPassword(usuario.id, Encriptador.encriptar(newPass));

				BitacoraManager.agregarMensaje(new BitacoraMensaje {
					titulo = "Cambio de password", 
					descripcion = "Se ha realizado el cambio de contrasena del usuario: " + usuario.id,
					tipo = Tipo.Info,
					fecha = DateTime.Now,
					usuario = Sesion.obtenerSesion().usuario
				});

				DV.actualizarDV();
				return true;
			} else {
				return false;
			}
		}

		public static List<Usuario> obtener(string name = "") {
			return dao.obtener(name);
		}

		public static List<Usuario> obtenerActivos(string name = "") {
			return dao.obtenerActivos(name);
		}

		public static Usuario obtener(int id) {
			return dao.obtener(id);
		}
	}
}
