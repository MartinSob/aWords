using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence {
	public class IdiomaDao : ConnectionDao {
		
		public Dictionary<string, string> obtenerTextos(int idiomaId) {
			try {
				SqlCommand query = new SqlCommand("SELECT c.tag, c.texto FROM controles c JOIN idiomas i ON i.id = c.idioma_id WHERE i.id = @idioma", conn);
				query.Parameters.AddWithValue("@idioma", idiomaId);

				conn.Open();
				SqlDataReader data = query.ExecuteReader();

				Dictionary<string, string> result = new Dictionary<string, string>();
				while (data.Read()) {
					result.Add(data["tag"].ToString(), data["texto"].ToString());
				}
				conn.Close();

				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return null;
			}
		}

        public Idioma cargarDefault() {
            try {
                SqlCommand query = new SqlCommand("SELECT TOP 1 id, nombre FROM idiomas i", conn);

                conn.Open();
                SqlDataReader data = query.ExecuteReader();

                Idioma result = new Idioma();
                while (data.Read()) {
                    result = castDto(data);
                }
                conn.Close();

                return result;
            } catch (Exception e) {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }

        public List<Idioma> obtener() {
            try
            {
                SqlCommand query = new SqlCommand("SELECT id, nombre FROM idiomas i", conn);

                conn.Open();
                SqlDataReader data = query.ExecuteReader();

                List<Idioma> result = new List<Idioma>();
                while (data.Read())
                {
                    result.Add(castDto(data));
                }
                conn.Close();

                return result;
            }
            catch (Exception e)
            {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }

        public List<Idioma> obtener(int id) {
            try {
                SqlCommand query = new SqlCommand("SELECT id, nombre FROM idiomas WHERE id = @id", conn);
                query.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader data = query.ExecuteReader();

                List<Idioma> result = new List<Idioma>();
                while (data.Read()) {
                    result.Add(castDto(data));
                }
                conn.Close();

                return result;
            } catch (Exception e) {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }

        public Idioma castDto(SqlDataReader data)
        {
            Idioma result = new Idioma()
            {
                id = Convert.ToInt32(data["id"]),
                nombre = data["nombre"].ToString()
            };

            return result;
        }
    }
}
