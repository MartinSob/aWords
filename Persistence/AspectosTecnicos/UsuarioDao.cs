using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence {
    public partial class UsuarioDao : ConnectionDao {

		public Usuario login(string username, string password) {
			try {
				SqlCommand query = new SqlCommand("SELECT password FROM usuarios WHERE nombre_usuario = @username AND activo = 1", conn);
				query.Parameters.AddWithValue("@username", username);

				Usuario user = null;
				conn.Open();
				SqlDataReader data = query.ExecuteReader();

				while (data.Read()) {
					if (data["password"].ToString() == password) {
						user = new Usuario();
					}
				}
				conn.Close();

				if (user != null) {
					user = obtenerPorNombreUsuario(username);
				}

				return user;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public int sumarIntentoFallido(string username) {
			try {
				SqlCommand queryGet = new SqlCommand("SELECT intentos_fallidos FROM usuarios WHERE nombre_usuario = @username", conn);
				queryGet.Parameters.AddWithValue("@username", username);
				conn.Open();
				SqlDataReader data = queryGet.ExecuteReader();
				int intentosFallidos = 0;

				if (data.HasRows) {
					data.Read();
					intentosFallidos = Convert.ToInt32(data["intentos_fallidos"]);
				}

				conn.Close();

				intentosFallidos++;

				SqlCommand querySet = new SqlCommand("UPDATE usuarios SET intentos_fallidos = @intentos_fallidos WHERE nombre_usuario = @username", conn);
				querySet.Parameters.AddWithValue("@username", username);
				querySet.Parameters.AddWithValue("@intentos_fallidos", intentosFallidos);

				executeQuery(querySet);

				return intentosFallidos;

			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return 0;
			}
		}

		public void resetearIntentosFallidos(string username) {
			try {
				SqlCommand querySet = new SqlCommand("UPDATE usuarios SET intentos_fallidos = @intentos_fallidos WHERE nombre_usuario = @username", conn);
				querySet.Parameters.AddWithValue("@username", username);
				querySet.Parameters.AddWithValue("@intentos_fallidos", 0);

				executeQuery(querySet);

			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return;
			}
		}

		public Usuario obtenerPorNombreUsuario(string username) {
			try {
				SqlCommand query = new SqlCommand("SELECT id, nombre_usuario, mail, password, nombre, apellido, fecha_entrada FROM usuarios WHERE nombre_usuario = @username", conn);
				query.Parameters.AddWithValue("@username", username);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario user = null;

				if (data.HasRows) {
					data.Read();
					user = castDto(data);
				}

				conn.Close();
				return user;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public string obtenerPasswordPorId(int id) {
			try {
				SqlCommand query = new SqlCommand("SELECT password FROM usuarios WHERE id = @id", conn);
				query.Parameters.AddWithValue("@id", id);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				string pass = null;

				if (data.HasRows) {
					data.Read();
					pass = data["password"].ToString();
				}

				conn.Close();
				return pass;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Usuario> obtener(string name = null) {
			try {
				string strQuery = "SELECT id, nombre_usuario, mail, password, nombre, apellido, fecha_entrada " +
					"FROM usuarios";

				if (name != null) {
					strQuery += " WHERE nombre LIKE CONCAT('%', @name, '%') OR apellido LIKE CONCAT('%', @name, '%')";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);
				query.Parameters.AddWithValue("@name", name);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Usuario> users = new List<Usuario>();

				if (data.HasRows) {
					while (data.Read()) {
						users.Add(castDto(data));
					}
				}

				conn.Close();
				return users;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public List<Usuario> obtenerActivos(string name = null) {
			try {
				string strQuery = "SELECT id, nombre_usuario, mail, password, nombre, apellido, fecha_entrada " +
					"FROM usuarios WHERE activo = 1";

				if (name != null) {
					strQuery += " AND ( nombre LIKE CONCAT('%', @name, '%') OR apellido LIKE CONCAT('%', @name, '%') )";
				}

				SqlCommand query = new SqlCommand(strQuery, conn);
				query.Parameters.AddWithValue("@name", name);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				List<Usuario> users = new List<Usuario>();

				if (data.HasRows) {
					while (data.Read()) {
						users.Add(castDto(data));
					}
				}

				conn.Close();
				return users;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public Usuario obtener(int id) {
			try {
				string strQuery = "SELECT id, nombre_usuario, mail, password, nombre, apellido, fecha_entrada " +
					$"FROM usuarios WHERE id = {id}";

				SqlCommand query = new SqlCommand(strQuery, conn);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				Usuario user = null;

				if (data.HasRows) {
					data.Read();
					user = castDto(data);
				}

				conn.Close();
				return user;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

		public bool actualizar(Usuario user) {
			SqlCommand query = new SqlCommand("UPDATE usuarios SET mail = @mail, nombre = @nombre, apellido = @apellido WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", user.id);
			query.Parameters.AddWithValue("@mail", user.mail);
			query.Parameters.AddWithValue("@nombre", user.nombre);
			query.Parameters.AddWithValue("@apellido", user.apellido);

			return executeQuery(query);
		}

		public bool eliminar(int id) {
			SqlCommand query = new SqlCommand("UPDATE usuarios SET activo = 0 WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", id);

			return executeQuery(query);
		}

		public int crear(Usuario us, string pass, Familia fam = null) {
			List<string> columns = new List<string> { "nombre_usuario", "mail", "nombre", "apellido" , "password", "fecha_entrada", "activo", "intentos_fallidos" };
			List<string> values = new List<string> { us.nombreUsuario, us.mail, us.nombre, us.apellido, pass, DateTime.Today.ToString(), 1.ToString(), 0.ToString() };

			if(fam != null) {
				columns.Add("familia_id");
				values.Add(fam.id.ToString());
			}

			return insert("usuarios", columns.ToArray(), values.ToArray());
		}

		public bool actualizarPassword(int id, string newPass) {
			SqlCommand query = new SqlCommand("UPDATE usuarios SET password = @password WHERE id = @id", conn);
			query.Parameters.AddWithValue("@id", id);
			query.Parameters.AddWithValue("@password", newPass);

			return executeQuery(query);
		}

		public Usuario castDto(SqlDataReader data) {
			Usuario result = new Usuario();
			result.id = Convert.ToInt32(data["id"]);
			result.nombreUsuario = data["nombre_usuario"].ToString();
			result.nombre = data["nombre"].ToString();
			result.apellido = data["apellido"].ToString();
			result.mail = data["mail"].ToString();
			result.fechaEntrada = DateTime.Parse(data["fecha_entrada"].ToString());

			return result;
		}
    }
}
