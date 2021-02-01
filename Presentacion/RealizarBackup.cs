using BusinessEntity;
using Security;
using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion {
	public partial class RealizarBackup : UpdatableForm {
		private OpenFileDialog openFileDialog1;

		public RealizarBackup() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void btnBackUp_Click(object sender, EventArgs e) {
			if (BackUp.realizarBackUp(Sesion.obtenerSesion().usuario)) {
				label1.Text = Sesion.obtenerSesion().idioma.textos["bkp_done"];
			} else {
				label1.Text = Sesion.obtenerSesion().idioma.textos["error"];
			}
		}

		private void btnRestore_Click(object sender, EventArgs e) {
			openFileDialog1 = new OpenFileDialog {
				Filter = "Database backups (*.bak)|*.bak",
				Title = "Open database backup",
				InitialDirectory = Directory.GetCurrentDirectory() + "\\..\\..\\..\\BackUps\\",
			};

			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				if (BackUp.realizarRestore(openFileDialog1.FileName, Sesion.obtenerSesion().usuario)) {
					label1.Text = Sesion.obtenerSesion().idioma.textos["restore_done"];
				} else {
					label1.Text = Sesion.obtenerSesion().idioma.textos["error"];
				}
			}
		}

		private void RealizarBackup_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);
		}
	}
}
