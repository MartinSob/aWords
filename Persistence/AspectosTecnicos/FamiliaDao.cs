using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BusinessEntity;

namespace Persistence {
	public class FamiliaDao : ConnectionDao {

        public Familia obtener(int id) {
			try {
				SqlCommand query = new SqlCommand("SELECT id, nombre FROM familias WHERE id = @id", conn);
				query.Parameters.AddWithValue("@id", id);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Familia result = null;

				if (data.HasRows) {
					data.Read();
					result = castDTO(data);
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Familia obtener(Usuario usuario) {
			try {
				SqlCommand query = new SqlCommand("SELECT f.id, f.nombre FROM familias f JOIN usuarios u ON u.familia_id = f.id WHERE u.id = @id", conn);
				query.Parameters.AddWithValue("@id", usuario.id);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Familia result = null;

				if (data.HasRows) {
					data.Read();
					result = castDTO(data);
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crear(Familia familia) {
			string[] columns = { "nombre" };
			string[] values = { familia.nombre };
			insert("familias", columns, values);

			return getLastId("familias");
        }

		public bool actualizar(Familia familia) {
			SqlCommand query = new SqlCommand("UPDATE familias SET nombre = @nombre WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", familia.id);
			query.Parameters.AddWithValue("@nombre", familia.nombre);

			return executeQuery(query);
		}

		public bool borrar(int id) {
			if( !deleteById("familias", id) ) {
				return false;
			}

			SqlCommand query = new SqlCommand("UPDATE usuarios SET familia_id = 0 WHERE familia_id = @id", conn);
			query.Parameters.AddWithValue("@id", id);

			return executeQuery(query);
		}

		public List<Familia> obtener(string nombre = null) {
			try {
				string queryTxt = "SELECT id, nombre FROM familias";

				if (nombre != null) {
					queryTxt += $" WHERE nombre LIKE '%{nombre}%'";
				}

				SqlCommand query = new SqlCommand(queryTxt, conn);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Familia> familiasDto = new List<Familia>();

				if (data.HasRows) {
					while (data.Read()) {
						familiasDto.Add(castDTO(data));
					}
				}

				conn.Close();
				return familiasDto;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public bool borrarRelaciones(int familiaId) {
			SqlCommand query = new SqlCommand($"DELETE FROM familia_patente WHERE familia_id = {familiaId}", conn);

			return executeQuery(query);
		}

		public bool modificarFamilia(int userId, int permisoId) {
			SqlCommand query = new SqlCommand("UPDATE usuarios SET familia_id = @familia_id WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", userId);
			query.Parameters.AddWithValue("@familia_id", permisoId);

			return executeQuery(query);
		}

		public bool verSiFamiliaExiste(int id, string nombre) {
			try {
				string queryTxt = $"SELECT id, nombre FROM familias WHERE nombre = '{nombre}'";

				if (id != 0) {
					queryTxt += $" AND id = {id}";
				}

				SqlCommand query = new SqlCommand(queryTxt, conn);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				bool result = false;

				if (data.HasRows) {
					result = true;
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return false;
			}
		}

		public Familia castDTO(SqlDataReader data) {
            Familia result = new Familia();
            result.id = Convert.ToInt32(data["id"]);
            result.nombre = data["nombre"].ToString();

			return result;
        }
	}
}
