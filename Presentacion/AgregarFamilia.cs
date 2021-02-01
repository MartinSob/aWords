using BusinessEntity;
using Security;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion {
	public partial class AgregarFamilia : UpdatableForm {
		public Familia family;
		public GestionarFamilia callBack;

		public AgregarFamilia() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void AgregarFamilia_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			allControls.Add(lblNombre);
			allControls.Add(lblPatentes);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			if (this.family != null) {
				txtNombre.Text = family.nombre;
			}

			List<Patente> allPatentes = PermisosManager.obtenerPatentes();
			foreach (Patente patente in allPatentes) {
				bool checkBox = false;
				if (family != null) {
					int index = PermisosManager.obtenerPatentes(family).FindIndex(pat => pat.id == patente.id);
					if (index >= 0) {
						checkBox = true;
					}
				}
				gridPatentes.Rows.Add(patente.id.ToString(), checkBox, patente.nombre);
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (txtNombre.Text.Equals("")) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["incorrect_data"], Sesion.obtenerSesion().idioma.textos["notification"]);
			}

			if (PermisosManager.verSiFamiliaExiste(family != null ? family.id : 0, txtNombre.Text) && family == null) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["name_already_used"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			List<Permiso> truePatentes = new List<Permiso>();

			foreach (DataGridViewRow row in gridPatentes.Rows) {
				bool check = bool.Parse(this.gridPatentes[1, row.Index].Value.ToString());
				if (check) {
					int id = int.Parse(this.gridPatentes[0, row.Index].Value.ToString());
					truePatentes.Add(PermisosManager.obtenerPatente(id));
				}
			}

			if (family == null) {
				PermisosManager.crear(new Familia {
					nombre = txtNombre.Text,
					patentes = truePatentes
				});
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["created"], Sesion.obtenerSesion().idioma.textos["notification"]);
				callBack.updateFamilyList();
				this.Close();
			} else {
				family.nombre = txtNombre.Text;
                PermisosManager.actualizar(family, truePatentes);
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["updated"], Sesion.obtenerSesion().idioma.textos["notification"]);
			}
		}

		private void txtValoracion_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
