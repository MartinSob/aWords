using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.Negocio {
	public class ObjetivoDao : ConnectionDao {

        public Objetivo obtener(int id) {
			try {
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de, o.archivado FROM objetivos o " +
					$"WHERE o.id = {id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Objetivo objetivo = null;

				if (data.HasRows) {
					while (data.Read()) {
						objetivo = castDto(data);
					}
				}

				conn.Close();
				return objetivo;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int crear(Objetivo obj) {
			List<string> columnas = new List<string> { "descripcion", "nivel_issue", "fecha_creacion", "fecha_cerrar_antes_de", "sector_id" };
			List<string> valores = new List<string> { obj.descripcion, obj.nivelIssue.ToString(), DateTime.Now.ToString(), obj.fechaCerrarAntesDe.ToString(), obj.sector.id.ToString() };

			return insert("objetivos", columnas.ToArray(), valores.ToArray());
		}

		public bool asignarTrabajador(int objId, int usId) {
			SqlCommand query = new SqlCommand("UPDATE objetivos SET usuario_id = @user, fecha_asignacion = @date WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", objId);
			query.Parameters.AddWithValue("@user", usId);
			query.Parameters.AddWithValue("@date", DateTime.Now.ToString());

			return executeQuery(query);
		}

        public bool finalizar(int objId) {
            SqlCommand query = new SqlCommand("UPDATE objetivos SET fecha_cierre = @date WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", objId);
            query.Parameters.AddWithValue("@date", DateTime.Now.ToString());

			return executeQuery(query);
		}

        public bool archivar(int objId) {
            SqlCommand query = new SqlCommand("UPDATE objetivos SET archivado = 1 WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", objId);

			return executeQuery(query);
		}

        public bool noFinalizado(int objId) {
            SqlCommand query = new SqlCommand("UPDATE objetivos SET fecha_cierre = NULL WHERE id = @id", conn);
            query.Parameters.AddWithValue("@id", objId);

			return executeQuery(query);
		}

        public bool borrar(int id) {
			return deleteById("objetivos", id);
		}

        public int agregarNoCumplido(ObjetivoNoCumplido obj) {
            List<string> columnas = new List<string> { "usuario_id", "objetivo_id", "tipo", "fecha" };
            List<string> valores = new List<string> { obj.empleado.id.ToString(), obj.id.ToString(), obj.tipo, DateTime.Now.ToString() };

            return insert("objetivos_no_cumplidos", columnas.ToArray(), valores.ToArray());
        }

        public List<Objetivo> obtener(Usuario us, int limit = 0) {
			try { 
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.usuario_id = {us.id}";

				if (limit != 0) {
					strQuery += $" ORDER BY o.id DESC";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerAbiertos(Usuario usuario, int limit = 0) {
			try { 
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.usuario_id = {usuario.id} AND o.fecha_cierre IS NULL";

				if (limit != 0) {
					strQuery += $" ORDER BY o.id DESC";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerCerrados(Usuario usuario, int limit = 0) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.usuario_id = {usuario.id} AND o.fecha_cierre IS NOT NULL";

				if (limit != 0) {
					strQuery += $" ORDER BY o.id DESC";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtener(Sector sector, int limit = 0) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id}";

				//if (conAsignado) {
				//	strQuery += " AND o.usuario_id IS NOT NULL";
				//}

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerAbiertos(Sector sector) {
			try {
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.fecha_cierre IS NULL AND o.archivado = 0 ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerAbiertosSinAsignado(Sector sector, int limit = 0) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.fecha_cierre IS NULL AND o.usuario_id IS NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerAbiertosConAsignado(Sector sector, int limit = 0) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.fecha_cierre IS NULL AND o.usuario_id IS NOT NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerCerrados(Sector sector, int limit = 0) {
			try {
				string strQuery = "SELECT";

				if (limit != 0) {
					strQuery += $" TOP {limit}";
				}

				strQuery += " o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.fecha_cierre IS NOT NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerCerradosNoArchivados(Sector sector) {
			try {
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.archivado = 0 AND o.fecha_cierre IS NOT NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> obtenerCerradosSinCalificacion(Sector sector) {
			try {
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.sector_id = {sector.id} AND o.fecha_cierre IS NOT NULL AND o.nivel_issue IS NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Usuario obtenerEmpleado(Objetivo obj) {
			try {
				string strQuery = "SELECT u.id, u.nombre_usuario, u.mail, u.nombre, u.apellido, u.fecha_entrada FROM usuarios u " +
					"JOIN objetivos o ON o.usuario_id = u.id " +
					$"WHERE o.id = {obj.id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario trabajador = null;

				if (data.HasRows) {
					UsuarioDao usuarioDao = new UsuarioDao();
					while (data.Read()) {
						trabajador = usuarioDao.castDto(data);
					}
				}

				conn.Close();

				return trabajador;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Sector obtenerSector(int objId) {
			try {
				string strQuery = "SELECT s.id, s.nombre FROM sectores s " +
					"JOIN objetivos o ON o.sector_id = s.id " +
					$"WHERE o.id = {objId}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Sector sector = null;

				if (data.HasRows) {
					SectorDao sectorDao = new SectorDao();
					sector = sectorDao.castDto(data);
				}

				conn.Close();

				return sector;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Objetivo castDto(SqlDataReader data) {
            DateTime? nullDate = null;

			return new Objetivo() {
				id = int.Parse(data["id"].ToString()),
				descripcion = data["descripcion"].ToString(),
				nivelIssue = data["nivel_issue"].ToString() != "" ? int.Parse(data["nivel_issue"].ToString()) : 0,
				fechaAsignacion = data["fecha_asignacion"].ToString() != "" ? DateTime.Parse(data["fecha_asignacion"].ToString()) : nullDate,
				fechaCerrarAntesDe = DateTime.Parse(data["fecha_cerrar_antes_de"].ToString()),
				fechaCreacion = DateTime.Parse(data["fecha_creacion"].ToString()),
				fechaFin = data["fecha_cierre"].ToString() != "" ? DateTime.Parse(data["fecha_cierre"].ToString()) : nullDate,
				archivado = this.ColumnExists(data, "archivado") && data["archivado"].ToString() == "1" ? true : false
			};
		}
	
		public List<Objetivo> obtenerFinalizados(Usuario usuario) {
			try {
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					$"WHERE o.usuario_id = {usuario.id} AND o.archivado = 1 ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows) {
					while (data.Read()) {
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		// Devuelve una lista de objetivos que no tienen un objetivo_fallido para ese usuario-objetivo
		public List<Objetivo> objetivosCumplidos(Usuario usuario)
		{
			try
			{
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, " +
					"o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					"LEFT JOIN objetivos_no_cumplidos onc ON onc.objetivo_id = o.id AND onc.usuario_id = o.usuario_id " +
					$"WHERE o.usuario_id = {usuario.id} AND o.archivado = 1 AND onc.id IS NULL";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows)
				{
					while (data.Read())
					{
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			}
			catch (Exception e)
			{
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Objetivo> ultimosObjetivosNoCumplidos(Usuario usuario)
		{
			try
			{
				string strQuery = "SELECT o.id, o.descripcion, o.usuario_id, o.sector_id, o.nivel_issue, o.fecha_creacion, " +
					"o.fecha_asignacion, o.fecha_cierre, o.fecha_cerrar_antes_de FROM objetivos o " +
					"LEFT JOIN objetivos_no_cumplidos onc ON onc.objetivo_id = o.id AND onc.usuario_id = o.usuario_id " +
					$"WHERE onc.usuario_id = {usuario.id} ";

				strQuery += " ORDER BY o.id DESC";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Objetivo> objetivos = new List<Objetivo>();

				if (data.HasRows)
				{
					while (data.Read())
					{
						objetivos.Add(castDto(data));
					}
				}

				conn.Close();

				return objetivos;
			}
			catch (Exception e)
			{
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}
	}
}