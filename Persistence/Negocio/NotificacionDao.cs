using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Negocio {
	public class NotificacionDao : ConnectionDao {

		public List<Notificacion> obtener(Usuario us) {
			try {
				string strQuery = $"SELECT id, fecha_creacion, leido, texto FROM notificaciones WHERE usuario_id = {us.id} AND leido = 0";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Notificacion> notificaciones = new List<Notificacion>();

				if (data.HasRows) {
					while (data.Read()) {
						notificaciones.Add(castDto(data));
					}
				}

				conn.Close();
				return notificaciones;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int obtenerCantidad(Usuario us) {
			try {
				string strQuery = $"SELECT count(id) as cantidad FROM notificaciones WHERE usuario_id = {us.id} AND leido = 0";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				int count = 0;

				if (data.HasRows) {
					while (data.Read()) {
						count = int.Parse(data["cantidad"].ToString());
					}
				}

				conn.Close();
				return count;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return 0;
			}
		}

		public int crear(Notificacion notif) {
			string[] columns = { "usuario_id", "fecha_creacion", "leido", "texto" };
			string[] values = { notif.usuario.id.ToString(), DateTime.Now.ToString(), "0", notif.texto };
			insert("notificaciones", columns, values);

			return getLastId("notificaciones");
		}

		public bool leerTodas(Usuario us) {
			SqlCommand query = new SqlCommand("UPDATE notificaciones SET leido = 1 WHERE usuario_id = @id", conn);
			query.Parameters.AddWithValue("@id", us.id);

			return executeQuery(query);
		}

		public Notificacion castDto(SqlDataReader data) {
			Notificacion result = new Notificacion() {
				id = Convert.ToInt32(data["id"]),
				fechaCreacion = DateTime.Parse(data["fecha_creacion"].ToString()),
				leido = int.Parse(data["leido"].ToString()) == 0 ? false : true,
				texto = data["texto"].ToString()
			};

			return result;
		}
	}
}
