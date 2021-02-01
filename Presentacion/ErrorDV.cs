using BusinessEntity;
using Security;
using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion {
	public partial class ErrorDV : UpdatableForm {
		private OpenFileDialog openFileDialog1;

		public ErrorDV() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
			IdiomaManager.cargar(Sesion.obtenerSesion().idioma);
		}

		private void ErrorDV_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			string[] erorrs = DV.obtenerErrores().Split('\n');
			foreach (string error in erorrs) {
				listErrors.Items.Add(error);
			}

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);
		}

		private void metroButton1_Click(object sender, EventArgs e) {
			BitacoreTable bt = new BitacoreTable();
			bt.Show();
		}

		private void btnRestore_Click(object sender, EventArgs e) {
			openFileDialog1 = new OpenFileDialog {
				Filter = "Database backups (*.bak)|*.bak",
				Title = "Open database backup",
				InitialDirectory = Directory.GetCurrentDirectory() + "\\..\\..\\..\\BackUps\\",
			};

			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				BackUp.realizarRestore(openFileDialog1.FileName, Sesion.obtenerSesion().usuario);
				lblResponse.Text = Sesion.obtenerSesion().idioma.textos["restore_done"];
			}
		}

		private void btnRestDV_Click(object sender, EventArgs e) {
			DV.actualizarDV();
		}
	}
}
