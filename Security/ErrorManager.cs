using System;
using System.IO;

namespace Security {
	public class ErrorManager {

		public static void agregarMensaje(string errorMsg) {
			Persistence.ErrorManager.agregarMensaje(errorMsg);
		}
	}
}
