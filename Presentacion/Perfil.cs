using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion {
	public partial class Perfil : UpdatableForm {
		public Usuario usuario;

		public Perfil(Usuario user, bool editable) {
			InitializeComponent();

			usuario = user;

			Sesion.obtenerSesion().idioma.forms.Add(this);
			IdiomaManager.cargar(Sesion.obtenerSesion().idioma);
		}

		private void VerPerfil_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblApellido);
			allControls.Add(lblMail);
			allControls.Add(lblNewPass);
			allControls.Add(lblNombre);
			allControls.Add(lblRol);
			allControls.Add(lblEmblemas);
			allControls.Add(lblReconocimiento);
			allControls.Add(lblSent);
			allControls.Add(lblReceived);
			allControls.Add(lblPuesto);
			allControls.Add(lblOldPass);
			allControls.Add(lblDateEnter);

			foreach (TabPage tp in tabProfile.TabPages) {
				this.allControls.Add(tp);
			}

			if (this.usuario.id != Sesion.obtenerSesion().usuario.id) {
				txtOldPass.Enabled = false;
				txtNewPass.Enabled = false;
				btnPass.Enabled = false;
			}

			this.Text = usuario.apellido + ", " + usuario.nombre;
			lblUsername.Text = usuario.nombreUsuario;

			Sector sector = TrabajadorManager.obtenerSector(usuario);
			lblSector.Text = sector != null? sector.nombre : "" ;

			txtApellido.Text = usuario.apellido;
			txtNombre.Text = usuario.nombre;
			txtMail.Text = usuario.mail;
			txtSector.Text = sector != null ? sector.nombre : "";
			txtPuesto.Text = PuestoManager.obtener(usuario).nombre;
			txtDateEnter.Text = usuario.fechaEntrada.ToString();

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			var fami = PermisosManager.obtenerFamilia(usuario);
			txtPermiso.Text = fami != null ? fami.nombre : "";

			cargarContenidos();
		}

		private void btnPass_Click(object sender, EventArgs e) {
			if( UsuarioManager.actualizarPassword(usuario, txtOldPass.Text, txtNewPass.Text) ) {
				lblResponse.Text = Sesion.obtenerSesion().idioma.textos["updated"];
				lblResponse.ForeColor = Color.Green;
			} else {
				lblResponse.Text = Sesion.obtenerSesion().idioma.textos["error"];
				lblResponse.ForeColor = Color.Red;
			}
		}

		private void cargarContenidos() {
			List<Reconocimiento> reconocimientosEnviados = ReconocimientoManager.obtenerEnviados(usuario, 8);

			lbReconocimientosEnviados.DisplayMember = "Text";
			lbReconocimientosEnviados.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Reconocimiento reconocimiento in reconocimientosEnviados) {
				items.Add(new ComboboxItem { Text = ReconocimientoManager.obtenerReconocedor(reconocimiento).NombreCompleto + ": " + reconocimiento.descripcion, Value = reconocimiento.id });
			}

			lbReconocimientosEnviados.DataSource = items;


            List<Reconocimiento> reconocimientosRecibidos = ReconocimientoManager.obtenerRecibidos(usuario, 8);
            lbReconocimientosRecibidos.DisplayMember = "Text";
			lbReconocimientosRecibidos.ValueMember = "Value";

            var items2 = new List<Object>();
            foreach (Reconocimiento reconocimiento in reconocimientosRecibidos) {
                items2.Add(new ComboboxItem { Text = ReconocimientoManager.obtenerReconocedor(reconocimiento).NombreCompleto + ": " + reconocimiento.descripcion, Value = reconocimiento.id });
			}

			lbReconocimientosRecibidos.DataSource = items2;


            List<Emblema> emblemasRecibidos = EmblemaManager.obtener(usuario, 8);
            lbEmblemasRecibidos.DisplayMember = "Text";
			lbEmblemasRecibidos.ValueMember = "Value";
            
            var items3 = new List<Object>();
            foreach (Emblema emblema in emblemasRecibidos) {
                items3.Add(new ComboboxItem { Text = emblema.nombre, Value = emblema.id });
			}

			lbEmblemasRecibidos.DataSource = items3;
		}
	}
}
