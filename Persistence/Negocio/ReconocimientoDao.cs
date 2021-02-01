using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Negocio {
	public class ReconocimientoDao : ConnectionDao {

		public int crear(Reconocimiento reco) {
			string[] columns = { "reconocedor_id", "reconocido_id", "descripcion", "emblema_id", "fecha", "valoracion" };
			string[] values = { reco.reconocedor.id.ToString(), reco.reconocido.id.ToString(), reco.descripcion, reco.emblema.id.ToString(), reco.fecha.ToString(), reco.valoracion.ToString() };
			insert("reconocimientos", columns, values);

			return getLastId("reconocimientos");
		}

		public List<Reconocimiento> obtener(int id = 0) {
			try {
				string strQuery = "SELECT";

				strQuery += " id, reconocedor_id, reconocido_id, descripcion, fecha, valoracion FROM reconocimientos";

				if (id != 0) {
					strQuery += $" WHERE id = {id}";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Reconocimiento> reconocimientos = new List<Reconocimiento>();

				if (data.HasRows) {
					while (data.Read()) {
						reconocimientos.Add(castDto(data));
					}
				}

				conn.Close();

				return reconocimientos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Usuario obtenerReconocedor(Reconocimiento reco) {
			try {
				string strQuery = "SELECT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada FROM usuarios u " +
					$"JOIN reconocimientos r ON r.reconocedor_id = u.id WHERE r.id = {reco.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario trabajador = null;

				if (data.HasRows) {
					data.Read();
					UsuarioDao usuarioDao = new UsuarioDao();
					trabajador = usuarioDao.castDto(data);
				}

				conn.Close();

				return trabajador;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Usuario obtenerReconocido(Reconocimiento reco) {
			try {
				string strQuery = "SELECT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada FROM usuarios u " +
					$"JOIN reconocimientos r ON r.reconocido_id = u.id WHERE r.id = {reco.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario trabajador = null;

				if (data.HasRows) {
					data.Read();
					UsuarioDao usuarioDao = new UsuarioDao();
					trabajador = usuarioDao.castDto(data);
				}

				conn.Close();

				return trabajador;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Emblema obtenerEmblema(Reconocimiento reco) {
			try {
				string strQuery = "SELECT e.id, e.nombre FROM emblemas e " +
					$"JOIN reconocimientos r ON r.emblema_id = e.id WHERE r.id = {reco.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Emblema emblema = null;

				if (data.HasRows) {
					data.Read();
					EmblemaDao emblemaDao = new EmblemaDao();
					emblema = emblemaDao.castDto(data);
				}

				conn.Close();

				return emblema;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Reconocimiento> obtenerEnviados(Usuario us, int limit) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " id, reconocedor_id, reconocido_id, descripcion, fecha, valoracion FROM reconocimientos " +
					$"WHERE reconocedor_id = {us.id}";

				if (limit != 0) {
					strQuery += $" ORDER BY id DESC";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Reconocimiento> reconocimientos = new List<Reconocimiento>();

				if (data.HasRows) {
					while (data.Read()) {
						reconocimientos.Add(castDto(data));
					}
				}

				conn.Close();

				return reconocimientos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Reconocimiento> obtenerRecibidos(Usuario us, int limit) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " id, reconocedor_id, reconocido_id, descripcion, fecha, valoracion FROM reconocimientos " +
					$"WHERE reconocido_id = {us.id}";

				if (limit != 0) {
					strQuery += $" ORDER BY id DESC";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Reconocimiento> reconocimientos = new List<Reconocimiento>();

				if (data.HasRows) {
					while (data.Read()) {
						reconocimientos.Add(castDto(data));
					}
				}

				conn.Close();

				return reconocimientos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Reconocimiento> obtenerRecibidosDeSuperiores(Usuario usuario) {
			try {
				string strQuery = "SELECT";

				var threeMonthsAgo = DateTime.Now.AddDays(-90);

				strQuery += " id, reconocedor_id, reconocido_id, descripcion, fecha, valoracion FROM reconocimientos " +
					$"WHERE reconocido_id = {usuario.id} AND valoracion > 1 AND fecha > '{threeMonthsAgo.ToString("yyyy-MM-dd")}' ";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Reconocimiento> reconocimientos = new List<Reconocimiento>();

				if (data.HasRows) {
					while (data.Read()) {
						reconocimientos.Add(castDto(data));
					}
				}

				conn.Close();

				return reconocimientos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Reconocimiento> obtenerUltimosRecibidos(Usuario usuario) {
			try {
				string strQuery = "SELECT";

				var twoMonthsAgo = DateTime.Now.AddDays(-60);

				strQuery += " id, reconocedor_id, reconocido_id, descripcion, fecha, valoracion FROM reconocimientos " +
					$"WHERE reconocido_id = {usuario.id} AND fecha > '{twoMonthsAgo.ToString("yyyy-MM-dd")}' ";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Reconocimiento> reconocimientos = new List<Reconocimiento>();

				if (data.HasRows) {
					while (data.Read()) {
						reconocimientos.Add(castDto(data));
					}
				}

				conn.Close();

				return reconocimientos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public bool borrar(int id) {
			return deleteById("reconocimientos", id);
		}

		public Reconocimiento castDto(SqlDataReader data) {
			return new Reconocimiento {
				id = Convert.ToInt32(data["id"]),
				descripcion = data["descripcion"].ToString(),
				fecha = DateTime.Parse(data["fecha"].ToString()),
				valoracion = Convert.ToInt32(data["valoracion"]),
			};
		}
	}
}