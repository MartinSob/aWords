using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Negocio {
	public class PuestoDao : ConnectionDao {

		public List<Puesto> obtener(int id = 0) {
			try {
				string strQuery = "SELECT id, nombre, valoracion FROM puestos";

				if (id != 0) {
					strQuery += $" WHERE id = {id}";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Puesto> tiposSector = new List<Puesto>();

				if (data.HasRows) {
					while (data.Read()) {
						tiposSector.Add(castDto(data));
					}
				}

				conn.Close();
				return tiposSector;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crear(Puesto puesto) {
			string[] columns = { "nombre", "valoracion" };
			string[] values = { puesto.nombre, puesto.valoracion.ToString() };
			insert("puestos", columns, values);

			return getLastId("puestos");
		}

		public bool actualizar(Puesto puesto) {
			SqlCommand query = new SqlCommand("UPDATE puestos SET nombre = @nombre, valoracion = @valoracion WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", puesto.id);
			query.Parameters.AddWithValue("@nombre", puesto.nombre);
			query.Parameters.AddWithValue("@valoracion", puesto.valoracion);

			return executeQuery(query);
		}

		public bool borrar(int id) {
			return deleteById("puestos", id);
		}

		public Puesto obtener(Usuario usuario) {
			try {
				string strQuery = $"SELECT p.id, p.nombre, p.valoracion FROM puestos p JOIN usuarios u ON u.puesto_id = p.id WHERE u.id = {usuario.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Puesto puesto = new Puesto();

				if (data.HasRows) {
					while (data.Read()) {
						puesto = castDto(data);
					}
				}

				conn.Close();
				return puesto;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Puesto castDto(SqlDataReader data) {
			Puesto result = new Puesto() {
				id = Convert.ToInt32(data["id"]),
				nombre = data["nombre"].ToString(),
				valoracion = Convert.ToInt32(data["valoracion"]),
			};

			return result;
		}
	}
}
