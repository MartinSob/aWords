using BusinessEntity;
using Persistence;
using System.Collections.Generic;

namespace Security {
    public static class IdiomaManager {
		static IdiomaDao dao = new IdiomaDao();

		public static void cambiar(Idioma sesionIdioma, int idiomaId) {
			Idioma newIdioma = dao.obtener(idiomaId)[0];

			sesionIdioma.id = newIdioma.id;
			sesionIdioma.nombre = newIdioma.nombre;
			sesionIdioma.textos = dao.obtenerTextos(newIdioma.id);

			foreach(iUpdatable form in sesionIdioma.forms) {
				form.actulizarTextos();
			}
		}

        public static void cambiar(Idioma idioma, int idiomaId, iUpdatable form) {
			Idioma newIdioma = dao.obtener(idiomaId)[0];

			idioma.id = newIdioma.id;
			idioma.nombre = newIdioma.nombre;
			idioma.textos = dao.obtenerTextos(newIdioma.id);
			form.actulizarTextos();
        }

		public static void cargar(Idioma idioma) {
			idioma.textos = dao.obtenerTextos(idioma.id);
		}

        public static List<Idioma> obtener(){
            return dao.obtener();
        }

		public static List<Idioma> obtener(int id) {
			return dao.obtener(id);
		}

		public static void cargarDefault() {
			Sesion.obtenerSesion().idioma = dao.cargarDefault();
		}
	}
}
