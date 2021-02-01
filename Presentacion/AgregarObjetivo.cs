using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class AgregarObjetivo : UpdatableForm {
		Objetivo objetivo;
		UpdatableForm callbackForm;
		public Sector sectorUsuario;

		public AgregarObjetivo() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void AgregarObjetivo_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblCerrarAntesDe);
			allControls.Add(lblDescripcion);
			allControls.Add(lblEmpleado);
			allControls.Add(lblNivel);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			updateTrabajadoresList();
		}

		private void updateTrabajadoresList() {
			if(this.sectorUsuario == null) {
				this.sectorUsuario = TrabajadorManager.obtenerSector(Sesion.obtenerSesion().usuario);
			}

			if (sectorUsuario == null) {
				return;
			}

			List<Usuario> trabajadores = SectorManager.obtenerTrabajadores(sectorUsuario);

			if(trabajadores == null || trabajadores.Count == 0) {
				return;
			}

			cbEmpleado.DisplayMember = "Text";
			cbEmpleado.ValueMember = "Value";

			var items = new List<Object> { new ComboboxItem { Text = "", Value = 0 } };
			foreach (Usuario trabajador in trabajadores) {
				items.Add(new ComboboxItem { Text = trabajador.NombreCompleto, Value = trabajador.id });
			}

			cbEmpleado.DataSource = items;
		}

		private void metroButton1_Click(object sender, EventArgs e) {
			lblResponse.Text = "";

			if (DateTime.Parse(dtCerrarAntesDe.Value.ToString("yyyy-MM-dd")).Ticks < DateTime.Now.Ticks) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["pick_valid_date"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			if(txtDescripcion.Text.Equals("") || cbNivel.Text.Equals("")) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["incorrect_data"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			objetivo = new Objetivo {
				descripcion = txtDescripcion.Text,
				nivelIssue = int.Parse(cbNivel.Text),
				fechaCerrarAntesDe = DateTime.Parse( dtCerrarAntesDe.Value.ToString("yyyy-MM-dd") ),
				sector = this.sectorUsuario
			};

			ObjetivoManager.crear(objetivo);

			if (cbEmpleado.SelectedItem != null) {
				int userId = int.Parse((cbEmpleado.SelectedItem as ComboboxItem).Value.ToString());
				if (userId != 0) {
					ObjetivoManager.asignarEmpleado(objetivo, userId);
				}
			}

			MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["created"], Sesion.obtenerSesion().idioma.textos["notification"]);
			this.Close();
		}
	}
}
