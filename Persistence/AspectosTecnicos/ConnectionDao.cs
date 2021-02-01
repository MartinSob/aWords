using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Persistence {

	public abstract class ConnectionDao
	{
		protected SqlConnection conn;
		private string dateFormat = "yyyy-MM-dd HH:mm:ss";

		public ConnectionDao() {
			try {
				this.conn = new SqlConnection(ConfigurationManager.ConnectionStrings["local"].ConnectionString.ToString());
			} catch(Exception e) {
				Console.WriteLine(e);
			}
		}

		public bool isForeignKey(string colName) {
			if(colName.Length < 4) {
				return false;
			}

			if (colName.Substring(colName.Length - 3, 3).Equals("_id")) {
				return true;
			}

			return false;
		}

		public bool deleteById(string table, int id) {
			try {
				if (conn.State == ConnectionState.Open) {
					return false;
				}

				SqlCommand query = new SqlCommand($"DELETE FROM {table} WHERE id = {id}", conn);

				conn.Open();
				query.ExecuteNonQuery();
				conn.Close();
				return true;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return false;
			}
		}

		public int insert(string table, string[] columns, string[] values) {
			try {
				StringBuilder queryString = new StringBuilder().AppendFormat("INSERT INTO {0} (", table);
				
				for(int i = 0; i<columns.Length; i++) {
					if(i != 0) {
						queryString.Append(", ");
					}

					queryString.Append(columns[i]);
				}

				queryString.Append(") VALUES (");

				for (int i = 0; i < columns.Length; i++) {
					if (i != 0) {
						queryString.Append(", ");
					}

					queryString.Append("@" + columns[i]);
				}

				queryString.Append(")");

				SqlCommand query = new SqlCommand(queryString.ToString(), conn);

				query.Parameters.AddWithValue("@table", table);
				for (int i = 0; i < columns.Length; i++) {
					if(values[i] == null) {
						query.Parameters.AddWithValue("@" + columns[i], DBNull.Value);
					} else {
						query.Parameters.AddWithValue("@" + columns[i], Truncate(values[i],200));
					}
				}

				if (conn.State == ConnectionState.Open) {
					return 0;
				}

				conn.Open();
				query.ExecuteNonQuery();
				conn.Close();

				return getLastId(table);
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return 0;
			}
		}

		public bool executeQuery(SqlCommand strQuery) {
			try {
				if (conn.State == ConnectionState.Open) {
					return false;
				}

				conn.Open();
				strQuery.ExecuteNonQuery();
				conn.Close();

				return true;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return false;
			}
		}

		public string Truncate(string value, int maxChars) {
			return value.Length <= maxChars ? value : value.Substring(0, maxChars) + " ...";
		}

		public int getLastId(string table) {
			try {
				if (conn.State == ConnectionState.Open) {
					return 0;
				}

				SqlCommand query = new SqlCommand($"SELECT TOP 1 id FROM {table} ORDER BY ID DESC", conn);
				conn.Open();
				SqlDataReader data = query.ExecuteReader();
				int result = 0;

				if (data.HasRows) {
					data.Read();
					result = int.Parse(data["id"].ToString());
				}

				conn.Close();
				return result;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return 0;
			}
		}

		public bool ColumnExists(IDataReader reader, string columnName) {
			for (int i = 0; i < reader.FieldCount; i++) {
				if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase)) {
					return true;
				}
			}

			return false;
		}

		public string getTimestamp(DateTime value) {
			return value.ToString("yyyyMMdd");
		}
	}
}
