using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion {
	public class ComboboxItem {
		public string Text { get; set; }
		public object Value { get; set; }

		public override string ToString() {
			return Text;
		}

		// Add items
		// lbMyObj.DisplayMember = "Text";
		// lbMyObj.ValueMember = "Value";

		// var items = new List<Object>();
		// foreach (Objetivo objetivo in Trabajador.castUsuario(Sesion.Usuario).obtenerObjetivos(0)) {
		//	 items.Add(new ComboboxItem { Text = objetivo.Descripcion, Value = objetivo.Id});
		// }

		// lbMyObj.DataSource = items;


		// Select an specific item
		// cbEmpleado.SelectedIndex = cbEmpleado.FindStringExact(objetivo.obtenerEmpleado().NombreCompleto);


		// Use selected item
		// (cmbTipos.SelectedItem as ComboboxItem).Value.ToString()
	}
}
