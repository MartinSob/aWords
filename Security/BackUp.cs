using BusinessEntity;
using Persistence;
using System;

namespace Security {
    public static class BackUp {
		static BackupDao dao = new BackupDao();

        public static bool realizarBackUp(Usuario usuarioLoggeado) {
			if(dao.backUp()) {
				BitacoraManager.agregarMensaje(new BitacoraMensaje {
					titulo = "BackUp", 
					descripcion = "Se ha realizado un backUp", 
					tipo = Tipo.Info, 
					fecha = DateTime.Now,
					usuario = usuarioLoggeado
				});

				return true;
			}

			return false;
		}

		public static bool realizarRestore(string nombreArchivo, Usuario usuarioLoggeado) {
			if (dao.restore(nombreArchivo)) {
				BitacoraManager.agregarMensaje(new BitacoraMensaje {
					titulo = "Restore",
					descripcion = "Se ha realizado un restore",
					tipo = Tipo.Info,
					fecha = DateTime.Now,
					usuario = usuarioLoggeado
				});

				return true;
			}

			return false;
		}
	}
}
