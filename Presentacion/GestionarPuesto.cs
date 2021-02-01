using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion {
	public partial class GestionarPuesto : UpdatableForm {
		List<Puesto> tiposSector;

		public GestionarPuesto() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void GestionarTipoSector_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblNombre);
			allControls.Add(lblValoracion);
			allControls.Add(addNamelbl);
			allControls.Add(addValoracionlbl);
			allControls.Add(gbAdd);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			updateTiposList();
		}

		private void updateTiposList() {
			cmbTipos.DisplayMember = "Text";
			cmbTipos.ValueMember = "Value";

			var items = new List<Object>();
			tiposSector = PuestoManager.obtener();

			foreach (Puesto tipoSector in tiposSector) {
				items.Add(new ComboboxItem { Text = tipoSector.nombre, Value = tipoSector.id });
			}

			cmbTipos.DataSource = items;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			if (addNametxt.Text.Trim().Equals("") || addValoraciontxt.Text.Trim().Equals("")) {
				return;
			}
			PuestoManager.crear(new Puesto {
				nombre = addNametxt.Text,
				valoracion = int.Parse(addValoraciontxt.Text)
			});
			updateTiposList();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (cmbTipos.SelectedIndex == -1) {
				return;
			}
			PuestoManager.actualizar(new Puesto {
				id = int.Parse((cmbTipos.SelectedItem as ComboboxItem).Value.ToString()),
				nombre = txtNombre.Text,
				valoracion = int.Parse(txtValoracion.Text)
			});
			updateTiposList();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (cmbTipos.SelectedIndex == -1) {
				return;
			}
			PuestoManager.borrar(int.Parse((cmbTipos.SelectedItem as ComboboxItem).Value.ToString()));
			updateTiposList();
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e) {
			int selectedId = int.Parse((cmbTipos.SelectedItem as ComboboxItem).Value.ToString());
			Puesto selectedSector = tiposSector.Find(c => c.id == selectedId);

			txtNombre.Text = selectedSector.nombre;
			txtValoracion.Text = selectedSector.valoracion.ToString();
		}
	}
}
