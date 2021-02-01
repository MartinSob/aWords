using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Windows.Forms;

namespace Presentacion
{
	public partial class GestionarReconocimiento : UpdatableForm
	{
		public GestionarReconocimiento() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void GestionarReconocimiento_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			this.updateGrid();
		}

		public override void actulizarTextos() {
			base.actulizarTextos();
			updateGrid();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			var selectedItem = int.Parse(gridRewards.SelectedRows[0].Cells["id"].Value.ToString());

			Reconocimiento selectedReward = ReconocimientoManager.obtener(selectedItem)[0];

			ReconocimientoManager.borrar(selectedReward);
			MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["deleted"], Sesion.obtenerSesion().idioma.textos["notification"]);

			this.updateGrid();
		}

		private void updateGrid() {
			gridRewards.Columns.Clear();

			gridRewards.Columns.Add(new DataGridViewTextBoxColumn {
				Name = "id",
				HeaderText = "id",
				Visible = false
			});
			gridRewards.Columns.Add("Reconocedor", Sesion.obtenerSesion().idioma.textos["recognizer"]);
			gridRewards.Columns.Add("Reconocido", Sesion.obtenerSesion().idioma.textos["recognized"]);
			gridRewards.Columns.Add("Descripcion", Sesion.obtenerSesion().idioma.textos["description"]);

			gridRewards.Rows.Clear();
			var reconocimientos = ReconocimientoManager.obtener();

			foreach (Reconocimiento reconocimiento in reconocimientos) {
				gridRewards.Rows.Add(reconocimiento.id,
					ReconocimientoManager.obtenerReconocedor(reconocimiento).NombreCompleto,
					ReconocimientoManager.obtenerReconocido(reconocimiento).NombreCompleto
					, reconocimiento.descripcion
				);
			}
		}
	}
}
