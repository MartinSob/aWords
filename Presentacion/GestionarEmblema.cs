using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class GestionarEmblema : UpdatableForm {
		public GestionarEmblema() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void GestionarEmblema_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblNombre);
			allControls.Add(addNamelbl);
			allControls.Add(gbAdd);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			updateEmblemasList();
		}

		private void updateEmblemasList() {
			List<Emblema> emblemas = EmblemaManager.obtener();

			cmbEmblema.DisplayMember = "Text";
			cmbEmblema.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Emblema emblem in emblemas) {
				items.Add(new ComboboxItem { Text = emblem.nombre, Value = emblem.id });
			}

			cmbEmblema.DataSource = items;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (addNametxt.Text.Trim().Equals("")) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["incorrect_data"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			if (EmblemaManager.verSiExiste(addNametxt.Text)) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["name_already_used"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			EmblemaManager.crear(addNametxt.Text);
			updateEmblemasList();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if(cmbEmblema.SelectedIndex == -1) {
				return;
			}
			EmblemaManager.actualizar(new Emblema {
				id = int.Parse((cmbEmblema.SelectedItem as ComboboxItem).Value.ToString()),
				nombre = txtNombre.Text
			});
			updateEmblemasList();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (cmbEmblema.SelectedIndex == -1) {
				return;
			}
			EmblemaManager.borrar(int.Parse((cmbEmblema.SelectedItem as ComboboxItem).Value.ToString()));
			updateEmblemasList();
		}
	}
}
