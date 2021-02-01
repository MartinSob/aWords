using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace Presentacion {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Check DB installation
			if (ConfigurationManager.AppSettings["database"].ToString() == "false" && !CheckDatabaseExists("aWords")) {
				try {
					createDatabase();
					UpdateValue();
				} catch (Exception ex) {
					Console.WriteLine(ex.ToString());
				}
			}

			Application.Run(new Login());
		}

		private static List<System.Windows.Forms.Control> GetAllControls(System.Windows.Forms.Control container, List<System.Windows.Forms.Control> list) {
			foreach (System.Windows.Forms.Control c in container.Controls) {
				if (c.Controls.Count > 0)
					list = GetAllControls(c, list);
				else
					list.Add(c);
			}

			return list;
		}

		public static List<System.Windows.Forms.Control> GetAllControls(System.Windows.Forms.Control container) {
			return GetAllControls(container, new List<System.Windows.Forms.Control>());
		}

		private static void UpdateValue() {
			var xmlDoc = new XmlDocument();
			xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
			xmlDoc.SelectSingleNode("//appSettings/add[@key='database']").Attributes["value"].Value = "true";
			xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

			ConfigurationManager.RefreshSection("appSettings");
		}

		private static void createDatabase() {
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

		private static bool CheckDatabaseExists(string databaseName) {
			using (var connection = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master")) {
				using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection)) {
					connection.Open();
					return (command.ExecuteScalar() != DBNull.Value);
				}
			}
		}
	}
}
