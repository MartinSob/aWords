using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Persistence.Negocio {
	public class SectorDao : ConnectionDao {
		
		public List<Sector> obtener(string name = null) {
			try {
				string strQuery = "SELECT id, nombre, nivel FROM sectores WHERE borrado = 0 ";

				if (name != null) {
					strQuery += $" AND nombre = {name}";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Sector> premios = new List<Sector>();

				if (data.HasRows) {
					while (data.Read()) {
						premios.Add(castDto(data));
					}
				}

				conn.Close();
				return premios;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Sector obtener(int id) {
			try {
				string strQuery = $"SELECT id, nombre, nivel FROM sectores WHERE borrado = 0 AND id = {id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Sector premio = null;

				if (data.HasRows) {
					while (data.Read()) {
						premio = castDto(data);
					}
				}

				conn.Close();
				return premio;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Sector obtener(Usuario usuario) {
			try {
				string strQuery = $"SELECT s.id, s.nombre, s.nivel FROM sectores s " +
					$"JOIN sector_puesto_usuario spu ON spu.sector_id = s.id " +
					$"WHERE s.borrado = 0 AND spu.usuario_id = {usuario.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Sector premio = null;

				if (data.HasRows) {
					while (data.Read()) {
						premio = castDto(data);
					}
				}

				conn.Close();
				return premio;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Sector> obtenerPorJefeId(int id) {
			try {
				string strQuery = $"SELECT id, nombre, nivel FROM sectores WHERE borrado = 0 AND jefe_id = {id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Sector> sectores = new List<Sector>();

				if (data.HasRows) {
					while (data.Read()) {
						sectores.Add(castDto(data));
					}
				}

				conn.Close();
				return sectores;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crear(Sector sector) {
			SectorDao sDao = new SectorDao();
			List<string> columnas = new List<string>();
			List<string> valores = new List<string>();

			columnas.Add("nombre");
			valores.Add(sector.nombre);

			columnas.Add("nivel");
			valores.Add(sector.nivel.ToString());

			if (sector.jefe != null) {
				columnas.Add("jefe_id");
				valores.Add(sector.jefe.id.ToString());
			}

			sector.id = insert("sectores", columnas.ToArray(), valores.ToArray());

			foreach (KeyValuePair<Puesto, Usuario> puesto in sector.puestos) {
				if (puesto.Value != null && sDao.obtener(puesto.Value) != null) {
					actualizarUsuario(puesto.Value.id);
				}

				agregarPuesto(sector.id, puesto);
			}

			return sector.id;
		}

		public bool actualizar(Sector sector) {
			SectorDao sDao = new SectorDao();
			string strQuery = "UPDATE sectores SET nombre = @nombre, nivel = @nivel";

			if (sector.jefe != null) {
				strQuery += ", jefe_id = @jefeId";
			}

			strQuery += " WHERE id = @id";

			SqlCommand query = new SqlCommand(strQuery, conn);
			query.Parameters.AddWithValue("@id", sector.id);
			query.Parameters.AddWithValue("@nombre", sector.nombre);
			query.Parameters.AddWithValue("@nivel", sector.nivel);

			if (sector.jefe != null) {
				query.Parameters.AddWithValue("@jefeId", sector.jefe.id);
			}

			borrarPuestos(sector.id);

			foreach (KeyValuePair<Puesto, Usuario> puesto in sector.puestos) {
				if (puesto.Value != null && sDao.obtener(puesto.Value) != null) {
					actualizarUsuario(puesto.Value.id);
				}

				agregarPuesto(sector.id, puesto);
			}

			return executeQuery(query);
		}

		public int agregarPuesto(int sectorId, KeyValuePair<Puesto, Usuario> puesto) {
			string[] columns = { "sector_id", "puesto_id", "usuario_id" };
			string[] values = { sectorId.ToString(), puesto.Key.id.ToString() };

			if (puesto.Value == null) {
				var asd = values.ToList();
				asd.Add(null);
				values = asd.ToArray();
			} else {
				var asd = values.ToList();
				asd.Add(puesto.Value.id.ToString());
				values = asd.ToArray();
			}
			
			insert("sector_puesto_usuario", columns, values);

			return getLastId("puestos");
		}

		public bool borrar(int id) {
			string strQuery = "UPDATE sectores SET borrado = 1 WHERE id = @id; DELETE FROM sector_puesto_usuario WHERE sector_id = @sectorId";

			SqlCommand query = new SqlCommand(strQuery, conn);
			query.Parameters.AddWithValue("@id", id);
			query.Parameters.AddWithValue("@sectorId", id);

			this.borrarPuestos(id);

			return executeQuery(query);
		}

		public bool actualizarUsuario(int userId) {
			string strQuery = "UPDATE sector_puesto_usuario SET usuario_id = NULL WHERE usuario_id = @userId ";

			SqlCommand query = new SqlCommand(strQuery, conn);
			query.Parameters.AddWithValue("@userId", userId);

			return executeQuery(query);
		}

		public bool borrarPuestos(int sectorId) {
			string strQuery = "DELETE FROM sector_puesto_usuario WHERE sector_id = @sectorId";

			SqlCommand query = new SqlCommand(strQuery, conn);
			query.Parameters.AddWithValue("@sectorId", sectorId);

			return executeQuery(query);
		}

		public List<KeyValuePair<Puesto, Usuario>> obtenerPuestos(int sectorId) {
			try {
				string strQuery = $"SELECT spu.sector_id, spu.puesto_id, spu.usuario_id " +
					$"FROM sector_puesto_usuario spu " +
					$"WHERE spu.sector_id = {sectorId} ";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<int[]> sectorArrayList = new List<int[]>();

				if (!data.HasRows) {
					conn.Close();
					return new List<KeyValuePair<Puesto, Usuario>>();
				}

				while (data.Read()) {
					sectorArrayList.Add(new int[] {
						int.Parse(data["puesto_id"].ToString()),
						data["usuario_id"].ToString() == "" ? 0 : int.Parse(data["usuario_id"].ToString())
					});
				}

				conn.Close();

				PuestoDao puestoDao = new PuestoDao();
				UsuarioDao usuarioDao = new UsuarioDao();
				List<KeyValuePair<Puesto, Usuario>> puestos = new List<KeyValuePair<Puesto, Usuario>>();

				foreach (int[] sectorArray in sectorArrayList) {
					puestos.Add(new KeyValuePair<Puesto, Usuario>(puestoDao.obtener(sectorArray[0])[0], usuarioDao.obtener(sectorArray[1])));
				}

				return puestos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Usuario obtenerJefe(int sectorId) {
			try {
				string strQuery = $"SELECT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada FROM usuarios u " +
					$"JOIN sectores s ON s.jefe_id = u.id " +
					$"WHERE s.id = {sectorId}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario usuario = null;

				if (data.HasRows) {
					UsuarioDao usuarioDao = new UsuarioDao();
					while (data.Read()) {
						usuario = usuarioDao.castDto(data);
					}
				}

				conn.Close();
				return usuario;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Usuario> obtenerTrabajadores(int sectorId) {
			try {
				string strQuery = $"SELECT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada FROM usuarios u " +
					$"JOIN sector_puesto_usuario spu ON spu.usuario_id = u.id WHERE spu.sector_id = {sectorId}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Usuario> trabajadores = new List<Usuario>();

				if (data.HasRows) {
					UsuarioDao usuarioDao = new UsuarioDao();
					while (data.Read()) {
						trabajadores.Add(usuarioDao.castDto(data));
					}
				}

				conn.Close();
				return trabajadores;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Sector castDto(SqlDataReader data) {
			Sector result = new Sector() {
				id = Convert.ToInt32(data["id"]),
				nombre = data["nombre"].ToString(),
				nivel = Convert.ToInt32(data["nivel"])
			};

			return result;
		}

		public bool verSiExiste(string nombre) {
			try {
				string queryTxt = $"SELECT id FROM sectores WHERE borrado = 0 AND nombre = '{nombre}'";

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
	}
}
