using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Tests
{
	class DbDependency
	{
		public static void CreateDB() {
			if (!CheckDatabaseExists("aWordsTest")) {

				String str = File.ReadAllText("./script.sql");
				SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

				try {
					IEnumerable<string> commandStrings = Regex.Split(str, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

					myConn.Open();
					foreach (string commandString in commandStrings) {
						if (!string.IsNullOrWhiteSpace(commandString.Trim())) {
							using (var command = new SqlCommand(commandString, myConn)) {
								command.ExecuteNonQuery();
							}
						}
					}

					myConn.Close();
				} catch (System.Exception ex) {
					Console.WriteLine(ex.ToString());
				}
			}
		}

		public static void DropDB() {
			SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

			try {
				IEnumerable<string> commandStrings = Regex.Split(@"USE master;
					ALTER DATABASE[aWordsTest] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
					DROP DATABASE[aWordsTest]; ", @" ^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

				myConn.Open();
				foreach (string commandString in commandStrings) {
					if (!string.IsNullOrWhiteSpace(commandString.Trim())) {
						using (var command = new SqlCommand(commandString, myConn)) {
							command.ExecuteNonQuery();
						}
					}
				}

				myConn.Close();
			} catch (System.Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}

		private static bool CheckDatabaseExists(string databaseName) {
			using (var connection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master")) {
				using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection)) {
					connection.Open();
					var result = command.ExecuteScalar() != DBNull.Value;
					connection.Close();
					return result;
				}
			}
		}
	}
}
