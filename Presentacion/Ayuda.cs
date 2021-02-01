using BusinessEntity;
using System;

namespace Presentacion
{
	public partial class Ayuda : UpdatableForm
	{
		public Ayuda() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void Ayuda_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			string fileName = System.IO.Directory.GetCurrentDirectory() + "\\ManualDeUsuario" + ".pdf";
			view.LoadFromFile(fileName);
		}
	}
}
