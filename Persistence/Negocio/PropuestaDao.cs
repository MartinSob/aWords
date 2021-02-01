using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace Persistence.Negocio
{
    public class PropuestaDao : ConnectionDao
    {
        public List<UsuarioPropuesto> obtenerParaPuesto(Sector sector, Puesto puesto, int mesesEnSector, bool puestoFijo)
        {
            try
            {
                var sixMonthsAgo = DateTime.Now.AddDays(-(mesesEnSector * 30));

                /*
                 * Filtros:
                 *  - Mismo puesto
                 *  - Usuario activo
                 *  - No sea jefe de ningun sector
                 *  - Que no pertenezca ya al mismo sector
                 *  - Que este hace mas de 6 meses
                 */
                string strQuery = "SELECT DISTINCT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada " +
                    "FROM usuarios u " +
                    "LEFT JOIN sector_puesto_usuario spu " +
                        "ON spu.usuario_id = u.id " +
                    "LEFT JOIN sector_puesto_usuario spuact " +
                        "ON spuact.usuario_id = u.id " +
                        $"AND spuact.sector_id = {sector.id} " +
                    "LEFT JOIN sectores s " +
                        "ON s.jefe_id = u.id " +
                    $"WHERE u.activo = 1 " +
                        "AND s.id IS NULL " +
                        "AND spuact.id IS NULL " +
                        $"AND u.fecha_entrada < '{sixMonthsAgo.ToString("yyyy-MM-dd")}' ";

                if(puestoFijo) {
                    strQuery += $" AND u.puesto_id = {puesto.id}";
                }

                if(sector.jefe != null) {
                    strQuery += $" AND u.id <> {sector.jefe.id} ";
                }

                SqlCommand query = new SqlCommand(strQuery, conn);

                conn.Open();
                SqlDataReader data = query.ExecuteReader();
                List<UsuarioPropuesto> users = new List<UsuarioPropuesto>();

                if (data.HasRows)
                {
                    UsuarioPropuestoDao uDao = new UsuarioPropuestoDao();
                    while (data.Read())
                    {
                        users.Add(uDao.castDto(data));
                    }
                }

                conn.Close();
                return users;
            }
            catch (Exception e)
            {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }

        public List<UsuarioPropuesto> obtenerParaJefe(Sector sector, int mesesEnSector)
        {
            try
            {
                var sixMonthsAgo = DateTime.Now.AddDays(-(mesesEnSector * 30));

                /*
                 * Filtros:
                 *  - Usuario activo
                 *  - Que haya entrado hace mas de 6
                 *  - Que pertenezca al mismo sector
                 *  - Que no sea el lider actual del sector
                 */
                string strQuery = "SELECT DISTINCT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada " +
                    "FROM usuarios u " +
                    "LEFT JOIN sector_puesto_usuario spu ON spu.usuario_id = u.id " +
                    $"LEFT JOIN sectores s ON s.jefe_id = u.id AND s.id = {sector.id} " +
                    $"WHERE u.activo = 1 " +
                        "AND ( " +
                            $"u.fecha_entrada < '{sixMonthsAgo.ToString("yyyy - MM - dd")}' " +
                            "OR " +
                            $"spu.sector_id = {sector.id} " +
                        ") " +
                        "AND s.id IS NULL";

                if(sector.jefe != null) {
                    strQuery += $" AND u.id <> {sector.jefe.id}";
				}

                SqlCommand query = new SqlCommand(strQuery, conn);

                conn.Open();
                SqlDataReader data = query.ExecuteReader();
                List<UsuarioPropuesto> users = new List<UsuarioPropuesto>();

                if (data.HasRows)
                {
                    UsuarioPropuestoDao uDao = new UsuarioPropuestoDao();
                    while (data.Read())
                    {
                        users.Add(uDao.castDto(data));
                    }
                }

                conn.Close();
                return users;
            }
            catch (Exception e)
            {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }
    }
}
