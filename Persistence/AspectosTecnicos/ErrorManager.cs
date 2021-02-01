using System;
using System.IO;

namespace Persistence {
	public class ErrorManager {

		public static void agregarMensaje(string errorMsg) {
			using (System.IO.StreamWriter file =
			new System.IO.StreamWriter("./error_log.txt", true)) {
				file.WriteLine(DateTime.Now);
				file.WriteLine("");
				file.WriteLine(errorMsg);
			}
		}
	}
}
