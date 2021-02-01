using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class AgregarExperience : UpdatableForm {
		public Usuario reconocido;

		public AgregarExperience() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void CreateExperience_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			allControls.Add(lblDescripcion);
			allControls.Add(lblReconocido);
			allControls.Add(lblEmblema);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			fillEmblemasList();

			txtReconocido.Text = reconocido.NombreCompleto;
		}

		private void fillEmblemasList() {
			List<Emblema> emblemas = EmblemaManager.obtener();

			cmbEmblema.DisplayMember = "Text";
			cmbEmblema.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Emblema emblem in emblemas) {
				items.Add(new ComboboxItem { Text = emblem.nombre, Value = emblem.id });
			}

			cmbEmblema.DataSource = items;
		}

		private void btnReconocer_Click(object sender, EventArgs e) {
            if (txtReconocido.Text == null || txtReconocido.Text == "" || cmbEmblema.SelectedItem == null) {
                return;
            }

			if (reconocido == Sesion.obtenerSesion().usuario) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["cant_recognize_myself"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			int emblemaId = int.Parse( (cmbEmblema.SelectedItem as ComboboxItem).Value.ToString() );
			Emblema emblema = EmblemaManager.obtener( int.Parse( (cmbEmblema.SelectedItem as ComboboxItem).Value.ToString() ) )[0];

			ReconocimientoManager.crear(new Reconocimiento {
				reconocedor = Sesion.obtenerSesion().usuario,
				reconocido = reconocido,
				descripcion = txtDescripcion.Text,
				emblema = emblema
			});

			NotificacionManager.enviar(new Notificacion{ usuario = reconocido, texto = "experience_sent" });

			MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["recognize_create_success"], Sesion.obtenerSesion().idioma.textos["notification"]);
			this.Close();
		}
	}
}
