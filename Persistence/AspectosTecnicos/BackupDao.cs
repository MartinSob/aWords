using System.Data.SqlClient;
using System.IO;
using System;

namespace Persistence {
	public class BackupDao : ConnectionDao {

		public bool backUp() {
			try {
				SqlCommand query = new SqlCommand("BACKUP DATABASE aWords TO  DISK = @bkpPath", conn);
				string bkpPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\BackUps\\bkp" + getTimestamp(DateTime.Now) + ".bak";
				File.Delete(bkpPath);
				query.Parameters.AddWithValue("@bkpPath", bkpPath);

				conn.Open();
				query.ExecuteNonQuery();
				conn.Close();

				return true;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return false;
			}
		}

		public bool restore(string nombreArchivo) {
			try {
				SqlCommand singleUser = new SqlCommand("ALTER DATABASE aWords SET Single_User WITH Rollback Immediate", conn);
				SqlCommand query = new SqlCommand("USE master; RESTORE DATABASE aWords FROM DISK = @bkpPath WITH REPLACE;", conn);
				SqlCommand multiUser = new SqlCommand("ALTER DATABASE aWords SET Multi_User", conn);

				query.Parameters.AddWithValue("@bkpPath", nombreArchivo);

				conn.Open();
				singleUser.ExecuteNonQuery();
				query.ExecuteNonQuery();
				multiUser.ExecuteNonQuery();
				conn.Close();

				return true;
			} catch (Exception e) {
				ErrorManager.agregarMensaje(e.ToString());
				return false;
			}
		}
	}
}
