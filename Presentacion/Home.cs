using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Presentacion {
	public partial class Home : UpdatableForm {
		Usuario usuarioLoggeado = Sesion.obtenerSesion().usuario;
		bool langLoaded = false;

		public Home() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void Home_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			allControls.Add(lblLang);
			allControls.Add(lblMisObjetivos);
			allControls.Add(lblObjetivosSector);
			allControls.Add(gbManage);

			foreach (TabPage tp in tabs.TabPages) {
				this.allControls.Add(tp);
			}

			cargarIdiomas();

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);
			langLoaded = true;

			loadPermisos();

			lblNotification.Text = NotificacionManager.obtenerCantidad(usuarioLoggeado).ToString();

            updateObjetivosTab();

			updateTeamLeaders();
		}

		private void loadPermisos() {
			if (PermisosManager.obtenerFamilia(usuarioLoggeado) == null) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["error_contact_admin"], Sesion.obtenerSesion().idioma.textos["notification"]);
				this.Close();
				return;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "VerAdmin")) {
				tabs.DisableTab(tabAdmin);
			}

			if (TrabajadorManager.obtenerSectorJefes(usuarioLoggeado).Count == 0) {
				tabs.DisableTab(tabJefe);
			}

			if (SectorManager.obtener(usuarioLoggeado) == null) {
				tabs.DisableTab(tabObjetivos);
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "ABMUsuarios")) {
				adminGroup.Visible = false;
				btnAddUser.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "ABMFamilias")) {
				metroButton1.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "ABMEmblemas")) {
				btnEmblema.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "ABMSectores")) {
				btnSectores.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "ABMPuestos")) {
				btnSectorTypes.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "BajaReconocimientos")) {
				btnRewards.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "Bitacora")) {
				btnBitacora.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "BackUp")) {
				btnBackUp.Enabled = false;
			}

			if (!PermisosManager.verificarPatente(usuarioLoggeado, "DigitoVerificador")) {
				btnRestDV.Enabled = false;
			}
		}

        private void updateObjetivosTab() {
			if (TrabajadorManager.obtenerSector(usuarioLoggeado) == null) {
				return;
			}

            var items = new List<Object>();
            foreach (Objetivo objetivo in ObjetivoManager.obtenerAbiertos(usuarioLoggeado)) {
                items.Add(new ComboboxItem { Text = objetivo.descripcion, Value = objetivo.id });
            }

            lbMyObj.DisplayMember = "Text";
            lbMyObj.ValueMember = "Value";
            lbMyObj.DataSource = items;

			List<Objetivo> objetivos = ObjetivoManager.obtenerAbiertos(usuarioLoggeado.sector);

			var items2 = new List<Object>();
			foreach (Objetivo objetivo in objetivos) {
				if(ObjetivoManager.obtenerEmpleado(objetivo) != null) {
					string itemText = $"({ObjetivoManager.obtenerEmpleado(objetivo).apellido}, {ObjetivoManager.obtenerEmpleado(objetivo).nombre}) {objetivo.descripcion}";
					items2.Add(new ComboboxItem { Text = itemText, Value = objetivo.id });
				} else {
					items2.Add(new ComboboxItem { Text = objetivo.descripcion, Value = objetivo.id });
				}
			}

            lbSectorObj.DisplayMember = "Text";
            lbSectorObj.ValueMember = "Value";
            lbSectorObj.DataSource = items2;
		}

		private void updateTeamLeaders() {
			List<Sector> sectores = TrabajadorManager.obtenerSectorJefes(usuarioLoggeado);

			var items = new List<Object>();
			foreach (Sector sector in sectores) {
				items.Add(new ComboboxItem { Text = sector.nombre, Value = sector.id });
			}

			cmbAdminSectorList.DisplayMember = "Text";
			cmbAdminSectorList.ValueMember = "Value";
			cmbAdminSectorList.DataSource = items;
		}


		#region --- EVENTS ---

		private void btnBackUp_Click(object sender, EventArgs e) {
			RealizarBackup bkp = new RealizarBackup();
			bkp.Show();
		}

		private void btnBitacora_Click(object sender, EventArgs e) {
			BitacoreTable bt = new BitacoreTable();
			bt.Show();
		}

		private void metroButton1_Click(object sender, EventArgs e) {
			DV.actualizarDV();
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			if (SesionManager.cerrarSesion()) {
				this.Close();
			}
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

		private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e) {
			if(langLoaded) {
				IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, int.Parse(cmbLanguage.SelectedValue.ToString()));
			}
		}

		private void btnSearch_Click(object sender, EventArgs e) {
			dgvUsers.Rows.Clear();
			List<Usuario> usuarios = UsuarioManager.obtenerActivos(txtNombre.Text);

			foreach (Usuario usuario in usuarios) {
				dgvUsers.Rows.Add(usuario.id, $"{usuario.apellido}, {usuario.nombre}");
			}
		}

		private void imgProfile_Click(object sender, EventArgs e) {
			Perfil vp = new Perfil(usuarioLoggeado, true);
			vp.Show();
		}

		private void btnAddUser_Click(object sender, EventArgs e) {
			AgregarUsuario aU = new AgregarUsuario();
			aU.Show();
		}

		private void btnProfile_Click(object sender, EventArgs e) {
			if (dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			bool canEditProfile = PermisosManager.verificarPatente(usuarioLoggeado, "EditarPerfil");

			var selectedItem = int.Parse(dgvUsers.SelectedRows[0].Cells["id"].Value.ToString());

			Perfil vp = new Perfil(UsuarioManager.obtener(selectedItem), canEditProfile);
			vp.Show();
		}

		private void btnEmblema_Click(object sender, EventArgs e) {
			GestionarEmblema ge = new GestionarEmblema();
			ge.Show();
		}

		private void btnReconocer_Click(object sender, EventArgs e) {
			if(dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			var selectedItem = int.Parse(dgvUsers.SelectedRows[0].Cells["id"].Value.ToString());

			Usuario selectedUser = UsuarioManager.obtener(selectedItem);

			AgregarExperience ce = new AgregarExperience {
				reconocido = selectedUser
			};
			ce.Show();
		}

		private void btnSectores_Click(object sender, EventArgs e) {
			GestionarSectorLista gs = new GestionarSectorLista();
			gs.Show();
		}

		private void btnSectorTypes_Click(object sender, EventArgs e) {
			GestionarPuesto gts = new GestionarPuesto();
			gts.Show();
		}

		private void imgNotification_Click(object sender, EventArgs e) {
			if (NotificacionManager.obtenerCantidad(usuarioLoggeado).ToString() == "0") {
				return;
			}

			Notificaciones n = new Notificaciones();
			n.Show();
			lblNotification.Text = "0";
		}

		private void btnAgregarObj_Click(object sender, EventArgs e) {
			AgregarObjetivo ao = new AgregarObjetivo();
			ao.Show();
		}

		private void btnEditObjetivo_Click(object sender, EventArgs e) {
			if (lbSectorObj.SelectedItem as ComboboxItem == null) {
				return;
			}

			int objId = int.Parse((lbSectorObj.SelectedItem as ComboboxItem).Value.ToString());

			DetalleObjetivo detObj = new DetalleObjetivo { objective = ObjetivoManager.obtener(objId) };
			detObj.Show();
		}

		// Shouldnt go this way
		private void btnObjNoFinalizado_Click(object sender, EventArgs e) {
			Objetivo obj = new Objetivo {
				id = int.Parse((lbSectorObj.SelectedItem as ComboboxItem).Value.ToString())
			};
			ObjetivoManager.noFinalizado(obj);
			ObjetivoManager.asignarEmpleado(obj, usuarioLoggeado.id);
		}

		private void btnFinalizarObj_Click(object sender, EventArgs e) {
			if (lbMyObj.SelectedItem == null) {
				return;
			}

			Objetivo obj = new Objetivo {
				id = int.Parse((lbMyObj.SelectedItem as ComboboxItem).Value.ToString())
			};
			ObjetivoManager.finalizar(obj);

			updateObjetivosTab();
		}

		private void btnAsignarseObj_Click(object sender, EventArgs e) {
			if (lbSectorObj.SelectedItem == null) {
				return;
			}

			Objetivo obj = new Objetivo {
				id = int.Parse((lbSectorObj.SelectedItem as ComboboxItem).Value.ToString())
			};

            if( !ObjetivoManager.asignarEmpleado(obj, usuarioLoggeado.id) ) {
                MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["objective_taken"], Sesion.obtenerSesion().idioma.textos["notification"]);
                return;
            }

			updateObjetivosTab();
		}

		private void metroButton1_Click_2(object sender, EventArgs e) {
			if (lbMyObj.SelectedItem == null) {
				return;
			}

			int objId = int.Parse((lbMyObj.SelectedItem as ComboboxItem).Value.ToString());

			DetalleObjetivo detObj = new DetalleObjetivo { objective = ObjetivoManager.obtener(objId) };
			detObj.Show();
		}

		private void metroButton1_Click_3(object sender, EventArgs e) {
			GestionarFamilia gf = new GestionarFamilia();
			gf.Show();
		}

		private void btnAdminSectorDetail_Click(object sender, EventArgs e) {
			SectorAdminDetalle sad = new SectorAdminDetalle();

			if (cmbAdminSectorList.SelectedItem == null) {
				return;
			}

			sad.sector = SectorManager.obtener(int.Parse((cmbAdminSectorList.SelectedItem as ComboboxItem).Value.ToString()));
			sad.Show();
		}

		private void btnActualizar_Click(object sender, EventArgs e) {
			this.updateObjetivosTab();
		}

		#endregion

		private void btnEditUser_Click(object sender, EventArgs e) {
			if (dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			var selectedItem = int.Parse(dgvUsers.SelectedRows[0].Cells["id"].Value.ToString());

			Usuario selectedUser = UsuarioManager.obtener(selectedItem);

			AgregarUsuario au = new AgregarUsuario { user = selectedUser };
			au.Show();
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			var selectedItem = int.Parse(dgvUsers.SelectedRows[0].Cells["id"].Value.ToString());

			Usuario selectedUser = UsuarioManager.obtener(selectedItem);

			UsuarioManager.eliminar(selectedUser);
			MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["deleted"], Sesion.obtenerSesion().idioma.textos["notification"]);
		}

		private void btnRewards_Click(object sender, EventArgs e) {
			GestionarReconocimiento gr = new GestionarReconocimiento();
			gr.Show();
		}

		private void btnHelp_Click(object sender, EventArgs e) {
			Ayuda a = new Ayuda();
			a.Show();
		}

		private void btnReport_Click(object sender, EventArgs e) {
			exportData = new SaveFileDialog {
				Filter = "PDF(*.pdf)|*.pdf",
				Title = "Save PDF file",
				InitialDirectory = Directory.GetCurrentDirectory() + "\\..\\..\\..\\",
			};

			if (exportData.ShowDialog() == DialogResult.OK) {
				Process.Start(PropuestaManager.exportPDF(exportData.FileName));
			}
		}
	}
}
