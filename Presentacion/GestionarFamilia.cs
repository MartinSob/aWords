using BusinessEntity;
using Security;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion {
	public partial class GestionarFamilia : UpdatableForm {
		public GestionarFamilia() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void GestionarFamilia_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			updateFamilyList();
		}

		private void btnDeleteFamily_Click(object sender, EventArgs e) {
			int selectedFamily = int.Parse(cmbFamilias.SelectedValue.ToString());
			if (selectedFamily == PermisosManager.obtenerFamilia(Sesion.obtenerSesion().usuario).id) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["cant_delete_my_family"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			PermisosManager.borrar(new Familia {
                id = selectedFamily
            });
			updateFamilyList();
		}

		private void btnEditFamily_Click(object sender, EventArgs e) {
            if (cmbFamilias.SelectedValue == null) {
                return;
            }
			
			AgregarFamilia ag = new AgregarFamilia() {
				family = PermisosManager.obtenerFamilia(int.Parse(cmbFamilias.SelectedValue.ToString()))
			};
			ag.Show();
		}

		private void btnAddFamily_Click(object sender, EventArgs e) {
			AgregarFamilia ag = new AgregarFamilia() {
				callBack = this
			};
			ag.Show();
		}

		public void updateFamilyList() {
			Dictionary<int, string> familias = new Dictionary<int, string>();
			foreach (Familia fam in PermisosManager.obtenerFamilia()) {
				familias.Add(fam.id, fam.nombre);
			}
			cmbFamilias.DataSource = new BindingSource(familias, null);
			cmbFamilias.DisplayMember = "Value";
			cmbFamilias.ValueMember = "Key";
		}
	}
}
