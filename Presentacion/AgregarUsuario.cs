using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion {
	public partial class AgregarUsuario : UpdatableForm {
		public Usuario user = new Usuario();

		public AgregarUsuario() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void AgregarUsuario_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			allControls.Add(lblApellido);
			allControls.Add(lblMail);
			allControls.Add(lblNombre);
			allControls.Add(lblUsername);
			allControls.Add(lblRol);
			allControls.Add(lblPuesto);

			if (this.user.id == 0) {
				txtUsername.Enabled = true;
			}

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			cargarFamilias();
			cargarPuestos();
			cargarDetalleUsuario();
		}

		private void btnGuardar_Click(object sender, EventArgs e) {
            if (cmbRol.SelectedValue == null || lbPuestos.SelectedValue == null) {
				//lblResponse.Text = Sesion.obtenerSesion().idioma.textos["select_values"];
				return;
            }

            Usuario newUser = new Usuario {
				id = user.id,
				nombreUsuario = txtUsername.Text,
				mail = txtMail.Text,
				nombre = txtNombre.Text,
				apellido = txtApellido.Text,
				permiso = new Familia() { id = int.Parse(cmbRol.SelectedValue.ToString()) },
				puesto = new Puesto() { id = int.Parse(lbPuestos.SelectedValue.ToString()) }
			};

			if(this.user.id == 0) {
				if (TrabajadorManager.crear(newUser) != 0) {
					lblResponse.Text = Sesion.obtenerSesion().idioma.textos["created"];
					lblResponse.ForeColor = Color.Green;
				} else {
					lblResponse.Text = Sesion.obtenerSesion().idioma.textos["error"];
					lblResponse.ForeColor = Color.Red;
				}
			} else {
				TrabajadorManager.actualizar(newUser);
				lblResponse.Text = Sesion.obtenerSesion().idioma.textos["updated"];
				lblResponse.ForeColor = Color.Green;
			}
		}

		private void cargarFamilias() {
			Dictionary<int, string> familias = new Dictionary<int, string>();

			cmbRol.DisplayMember = "Value";
			cmbRol.ValueMember = "Key";

			foreach (Familia fam in PermisosManager.obtenerFamilia()) {
				familias.Add(fam.id, fam.nombre);
			}

			cmbRol.DataSource = new BindingSource(familias, null);
		}

		private void cargarPuestos() {
			List<Puesto> puestos = PuestoManager.obtener();

			lbPuestos.DisplayMember = "Text";
			lbPuestos.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Puesto puesto in puestos) {
				items.Add(new ComboboxItem { Text = puesto.nombre, Value = puesto.id });
			}

			lbPuestos.DataSource = items;
		}

		private void cargarDetalleUsuario() {
			if(this.user == null) { return; }

			this.txtApellido.Text = user.apellido;
			this.txtMail.Text = user.mail;
			this.txtNombre.Text = user.nombre;
			this.txtUsername.Text = user.nombreUsuario;

			PermisosManager.obtenerFamilia(user);
			cmbRol.SelectedIndex = cmbRol.FindStringExact((user.permiso != null ? user.permiso.nombre : (String)""));

			SectorManager.obtener(user);
			txtSector.Text = user.sector != null? user.sector.nombre : "";

			PuestoManager.obtener(user);
			lbPuestos.SelectedIndex = lbPuestos.FindStringExact((user.puesto != null ? user.puesto.nombre : (String)""));
		}
	}
}
