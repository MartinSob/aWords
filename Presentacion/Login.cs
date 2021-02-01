using BusinessEntity;
using Security;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion {
	public partial class Login : UpdatableForm {

		public Login() {
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e) {
			IdiomaManager.cargarDefault();
			Sesion.obtenerSesion().idioma.forms.Add(this);

			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblUsername);
			allControls.Add(lblPassword);
			allControls.Add(lblLang);

			cargarIdiomas();
		}

		private void metroButton1_Click(object sender, EventArgs e) {
			if (!SesionManager.iniciarSesion(usernameTB.Text, passwordTB.Text)) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["login_failed"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}
			var sesion = Sesion.obtenerSesion();

			MetroFramework.MetroMessageBox.Show(this, sesion.idioma.textos["login_success"], sesion.idioma.textos["notification"]);

			if (!DV.verificarDV()) {
				if ( PermisosManager.verificarPatente(sesion.usuario,"DigitoVerificador") ) {
					ErrorDV error = new ErrorDV();
					error.Show();
					return;
				}

				MetroFramework.MetroMessageBox.Show(this, sesion.idioma.textos["error_contact_admin"], sesion.idioma.textos["notification"]);
				return;
			}

			this.Hide();
			Home h1 = new Home();
			h1.ShowDialog();
			this.Close();
		}

		private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, int.Parse(cmbLanguage.SelectedValue.ToString()));
		}

		private void cargarIdiomas() {
			Dictionary<int, string> idiomas = new Dictionary<int, string>();

			cmbLanguage.DisplayMember = "Value";
			cmbLanguage.ValueMember = "Key";
			
			foreach (Idioma id in IdiomaManager.obtener()) {
				idiomas.Add(id.id, id.nombre);
			}

			cmbLanguage.DataSource = new BindingSource(idiomas, null);
		}
	}
}
