using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence {
	public class PatenteDao : ConnectionDao {
		public List<Permiso> obtenerPorFamilia(int id) {
			try {
				SqlCommand query = new SqlCommand("SELECT p.id, p.nombre FROM patentes p JOIN familia_patente fp ON fp.patente_id = p.id WHERE fp.familia_id = @id", conn);
				query.Parameters.AddWithValue("@id", id);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Permiso> result = new List<Permiso>();

				if (data.HasRows) {
					while (data.Read()) {
						result.Add(castDTO(data));
					}
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Patente> obtener(int id = 0) {
			try {
                string sqlQuery = "SELECT p.id, p.nombre FROM patentes p";

                if(id != 0)
                {
                    sqlQuery += $" WHERE id = {id}";
                }

				SqlCommand query = new SqlCommand(sqlQuery, conn);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
                List<Patente> result = new List<Patente>();

                if (data.HasRows) {
					while (data.Read()) {
                        result.Add(castDTO(data));
                    }
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crearRelacion(int familiaId, int patenteId) {
			string[] columns = { "familia_id", "patente_id" };
			string[] values = { familiaId.ToString(), patenteId.ToString() };
			return insert("familia_patente", columns, values);
		}

		public Patente castDTO(SqlDataReader data) {
			Patente result = new Patente();
			result.id = Convert.ToInt32(data["id"]);
			result.nombre = data["nombre"].ToString();

			return result;
		}
	}
}
