using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Negocio {
	public class EmblemaDao : ConnectionDao {

		public List<Emblema> obtener(int id = 0) {
			try {
				string strQuery = "SELECT id, nombre FROM emblemas";

				if (id != 0) {
					strQuery += $" WHERE id = {id}";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Emblema> emblemas = new List<Emblema>();

				if (data.HasRows) {
					while (data.Read()) {
						emblemas.Add(castDto(data));
					}
				}

				conn.Close();
				return emblemas;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crear(string nombre) {
			string[] columns = { "nombre" };
			string[] values = { nombre };
			insert("emblemas", columns, values);

			return getLastId("emblemas");
		}

		public bool actualizar(Emblema emblema) {
			SqlCommand query = new SqlCommand("UPDATE emblemas SET nombre = @nombre WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", emblema.id);
			query.Parameters.AddWithValue("@nombre", emblema.nombre);

			return executeQuery(query);
		}

		public bool borrar(int id) {
			return deleteById("emblemas", id);
		}

		public List<Emblema> obtenerRecibidos(Usuario us, int limit) {
			string strQuery = "SELECT";

			if (limit != 0) {
				strQuery += $" TOP {limit}";
			}

			strQuery += " e.id, e.nombre FROM emblemas e " +
				"JOIN reconocimientos r ON r.emblema_id = e.id " +
				$"WHERE r.reconocido_id = {us.id}";

			if (limit != 0) {
				strQuery += $" ORDER BY r.id DESC";
			}

			SqlCommand query = new SqlCommand(strQuery, conn);

			conn.Open();
			SqlDataReader data = query.ExecuteReader();
			List<Emblema> emblemas = new List<Emblema>();

			if (data.HasRows) {
				while (data.Read()) {
					emblemas.Add(castDto(data));
				}
			}

			conn.Close();

			return emblemas;
		}

		public int obtenerRecibidos(Usuario us, Emblema em) {
			string strQuery = "SELECT";

			strQuery += " COUNT(e.id) as cant FROM emblemas e " +
				"JOIN reconocimientos r ON r.emblema_id = e.id " +
				$"WHERE r.reconocido_id = {us.id} AND r.emblema_id = {em.id} ";

			SqlCommand query = new SqlCommand(strQuery, conn);

			conn.Open();
			SqlDataReader data = query.ExecuteReader();
			int count = 0;

			if (data.HasRows) {
				while (data.Read()) {
					count = int.Parse(data["cant"].ToString());
				}
			}

			conn.Close();

			return count;
		}

		public bool verSiExiste(string nombre) {
			try {
				string queryTxt = $"SELECT id, nombre FROM emblemas WHERE nombre = '{nombre}'";

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

		public Emblema castDto(SqlDataReader data) {
			Emblema result = new Emblema() {
				id = Convert.ToInt32(data["id"]),
				nombre = data["nombre"].ToString()
			};

			return result;
		}
	}
}
