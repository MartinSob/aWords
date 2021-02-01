using BusinessEntity;
using Persistence;
using System.Collections.Generic;

namespace Security
{
    public static class PermisosManager
    {
        static FamiliaDao daoFamilia = new FamiliaDao();
        static PatenteDao daoPatente = new PatenteDao();

        public static List<Familia> obtenerFamilia(string nombre = null)
        {
            return daoFamilia.obtener(nombre);
        }

        public static Familia obtenerFamilia(int id)
        {
            return daoFamilia.obtener(id);
        }

        public static List<Permiso> obtenerPatentes(Familia familia)
        {
            if (familia.patentes == null)
            {
                familia.patentes = new List<Permiso>();
                familia.patentes = obtenerPorFamilia(familia.id);
            }
            return familia.patentes;
        }

        public static List<Patente> obtenerPatentes() {
            return daoPatente.obtener();
        }

        public static Patente obtenerPatente(int id) {
            return daoPatente.obtener(id)[0];
        }

        public static List<Permiso> obtenerPorFamilia(int id) {
            return daoPatente.obtenerPorFamilia(id);
        }

        public static void crear(Familia familia)
        {
            int newId = daoFamilia.crear(familia);

            foreach (Patente patente in familia.patentes)
            {
                daoPatente.crearRelacion(familia.id, patente.id);
            }

            BitacoraManager.agregarMensajeControl("Familia creada: ", familia);

            DV.actualizarDV();
        }

        public static bool verSiFamiliaExiste(int id, string nombre)
        {
            return daoFamilia.verSiFamiliaExiste(id, nombre);
        }

        public static void actualizar(Familia familia, List<Permiso> newPatentes)
        {
            daoFamilia.actualizar(familia);
            borrarRelaciones(familia);
            familia.patentes.Clear();
            foreach (Patente patente in newPatentes)
            {
                daoPatente.crearRelacion(familia.id, patente.id);
                familia.patentes.Add(patente);
            }

            BitacoraManager.agregarMensajeControl("Familia actualizada: ", familia);

            DV.actualizarDV();
        }

        public static Familia obtenerFamilia(Usuario usuario)
        {
            if (usuario.permiso == null) {
                usuario.permiso = daoFamilia.obtener(usuario);
            }
            return (Familia)usuario.permiso;
        }

        public static void borrar(Familia familia)
        {
            daoFamilia.borrar(familia.id);
            DV.actualizarDV();

            BitacoraManager.agregarMensajeControl("Familia borrada: ", familia);
        }

        public static void borrarRelaciones(Familia familia)
        {
            daoFamilia.borrarRelaciones(familia.id);
        }

        public static bool verificarPatente(Usuario usuario, string patenteNombre) {
            obtenerPatentes(obtenerFamilia(usuario));
            return usuario.permiso.tienePermiso(patenteNombre);
        }

        public static bool modificarFamilia(Usuario usuario, Familia newFamilia) {
            daoFamilia.modificarFamilia(usuario.id, newFamilia.id);
            DV.actualizarDV();
            return true;
        }
    }
}
