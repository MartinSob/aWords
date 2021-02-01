namespace Presentacion {
	partial class Home {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.imgProfile = new System.Windows.Forms.PictureBox();
			this.lblNotification = new MetroFramework.Controls.MetroLabel();
			this.lblLang = new MetroFramework.Controls.MetroLabel();
			this.cmbLanguage = new MetroFramework.Controls.MetroComboBox();
			this.imgNotification = new System.Windows.Forms.PictureBox();
			this.imgLogout = new System.Windows.Forms.PictureBox();
			this.tabs = new MetroFramework.Controls.MetroTabControl();
			this.tabEmpleados = new MetroFramework.Controls.MetroTabPage();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adminGroup = new System.Windows.Forms.GroupBox();
			this.btnDelete = new MetroFramework.Controls.MetroButton();
			this.btnEditUser = new MetroFramework.Controls.MetroButton();
			this.btnSearch = new MetroFramework.Controls.MetroButton();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.btnProfile = new MetroFramework.Controls.MetroButton();
			this.btnReconocer = new MetroFramework.Controls.MetroButton();
			this.tabAdmin = new MetroFramework.Controls.MetroTabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnReport = new MetroFramework.Controls.MetroButton();
			this.btnBackUp = new MetroFramework.Controls.MetroButton();
			this.btnBitacora = new MetroFramework.Controls.MetroButton();
			this.btnRestDV = new MetroFramework.Controls.MetroButton();
			this.btnAddUser = new MetroFramework.Controls.MetroButton();
			this.gbManage = new System.Windows.Forms.GroupBox();
			this.btnRewards = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.btnEmblema = new MetroFramework.Controls.MetroButton();
			this.btnSectores = new MetroFramework.Controls.MetroButton();
			this.btnSectorTypes = new MetroFramework.Controls.MetroButton();
			this.tabObjetivos = new MetroFramework.Controls.MetroTabPage();
			this.btnActualizar = new MetroFramework.Controls.MetroButton();
			this.lbMyObj = new System.Windows.Forms.ListBox();
			this.btnDetalleMiObjetivo = new MetroFramework.Controls.MetroButton();
			this.btnDetalleObjetivo = new MetroFramework.Controls.MetroButton();
			this.lbSectorObj = new System.Windows.Forms.ListBox();
			this.lblObjetivosSector = new MetroFramework.Controls.MetroLabel();
			this.btnFinalizarObj = new MetroFramework.Controls.MetroButton();
			this.btnAsignarseObj = new MetroFramework.Controls.MetroButton();
			this.btnAgregarObj = new MetroFramework.Controls.MetroButton();
			this.lblMisObjetivos = new MetroFramework.Controls.MetroLabel();
			this.tabJefe = new MetroFramework.Controls.MetroTabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAdminSectorDetail = new MetroFramework.Controls.MetroButton();
			this.cmbAdminSectorList = new MetroFramework.Controls.MetroComboBox();
			this.btnHelp = new MetroFramework.Controls.MetroButton();
			this.exportData = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgNotification)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogout)).BeginInit();
			this.tabs.SuspendLayout();
			this.tabEmpleados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.adminGroup.SuspendLayout();
			this.tabAdmin.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbManage.SuspendLayout();
			this.tabObjetivos.SuspendLayout();
			this.tabJefe.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imgProfile
			// 
			this.imgProfile.BackColor = System.Drawing.Color.Transparent;
			this.imgProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgProfile.BackgroundImage")));
			this.imgProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imgProfile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgProfile.Location = new System.Drawing.Point(754, 33);
			this.imgProfile.Name = "imgProfile";
			this.imgProfile.Size = new System.Drawing.Size(25, 25);
			this.imgProfile.TabIndex = 15;
			this.imgProfile.TabStop = false;
			this.imgProfile.Click += new System.EventHandler(this.imgProfile_Click);
			// 
			// lblNotification
			// 
			this.lblNotification.AutoSize = true;
			this.lblNotification.BackColor = System.Drawing.Color.Transparent;
			this.lblNotification.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblNotification.ForeColor = System.Drawing.Color.Red;
			this.lblNotification.Location = new System.Drawing.Point(728, 20);
			this.lblNotification.Name = "lblNotification";
			this.lblNotification.Size = new System.Drawing.Size(17, 19);
			this.lblNotification.TabIndex = 14;
			this.lblNotification.Text = "2";
			this.lblNotification.UseCustomBackColor = true;
			this.lblNotification.UseCustomForeColor = true;
			// 
			// lblLang
			// 
			this.lblLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblLang.AutoSize = true;
			this.lblLang.Location = new System.Drawing.Point(19, 471);
			this.lblLang.Name = "lblLang";
			this.lblLang.Size = new System.Drawing.Size(50, 19);
			this.lblLang.TabIndex = 13;
			this.lblLang.Tag = "language";
			this.lblLang.Text = "Idioma";
			// 
			// cmbLanguage
			// 
			this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbLanguage.FormattingEnabled = true;
			this.cmbLanguage.ItemHeight = 23;
			this.cmbLanguage.Items.AddRange(new object[] {
            "Castellano",
            "English"});
			this.cmbLanguage.Location = new System.Drawing.Point(121, 466);
			this.cmbLanguage.Name = "cmbLanguage";
			this.cmbLanguage.Size = new System.Drawing.Size(147, 29);
			this.cmbLanguage.TabIndex = 12;
			this.cmbLanguage.UseSelectable = true;
			this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
			// 
			// imgNotification
			// 
			this.imgNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgNotification.BackgroundImage")));
			this.imgNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imgNotification.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgNotification.Location = new System.Drawing.Point(707, 30);
			this.imgNotification.Name = "imgNotification";
			this.imgNotification.Size = new System.Drawing.Size(30, 30);
			this.imgNotification.TabIndex = 2;
			this.imgNotification.TabStop = false;
			this.imgNotification.Click += new System.EventHandler(this.imgNotification_Click);
			// 
			// imgLogout
			// 
			this.imgLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogout.BackgroundImage")));
			this.imgLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.imgLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgLogout.InitialImage = null;
			this.imgLogout.Location = new System.Drawing.Point(797, 33);
			this.imgLogout.Name = "imgLogout";
			this.imgLogout.Size = new System.Drawing.Size(25, 25);
			this.imgLogout.TabIndex = 1;
			this.imgLogout.TabStop = false;
			this.imgLogout.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabEmpleados);
			this.tabs.Controls.Add(this.tabAdmin);
			this.tabs.Controls.Add(this.tabObjetivos);
			this.tabs.Controls.Add(this.tabJefe);
			this.tabs.Location = new System.Drawing.Point(24, 64);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 1;
			this.tabs.Size = new System.Drawing.Size(798, 393);
			this.tabs.TabIndex = 0;
			this.tabs.UseSelectable = true;
			// 
			// tabEmpleados
			// 
			this.tabEmpleados.Controls.Add(this.dgvUsers);
			this.tabEmpleados.Controls.Add(this.adminGroup);
			this.tabEmpleados.Controls.Add(this.btnSearch);
			this.tabEmpleados.Controls.Add(this.txtNombre);
			this.tabEmpleados.Controls.Add(this.btnProfile);
			this.tabEmpleados.Controls.Add(this.btnReconocer);
			this.tabEmpleados.HorizontalScrollbarBarColor = true;
			this.tabEmpleados.HorizontalScrollbarHighlightOnWheel = false;
			this.tabEmpleados.HorizontalScrollbarSize = 10;
			this.tabEmpleados.Location = new System.Drawing.Point(4, 38);
			this.tabEmpleados.Name = "tabEmpleados";
			this.tabEmpleados.Size = new System.Drawing.Size(790, 351);
			this.tabEmpleados.TabIndex = 1;
			this.tabEmpleados.Tag = "employees";
			this.tabEmpleados.Text = "Empleados";
			this.tabEmpleados.VerticalScrollbarBarColor = true;
			this.tabEmpleados.VerticalScrollbarHighlightOnWheel = false;
			this.tabEmpleados.VerticalScrollbarSize = 10;
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.ColumnHeadersVisible = false;
			this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre});
			this.dgvUsers.Location = new System.Drawing.Point(3, 4);
			this.dgvUsers.MultiSelect = false;
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersWidth = 82;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(513, 335);
			this.dgvUsers.TabIndex = 10;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 10;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.MinimumWidth = 10;
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// adminGroup
			// 
			this.adminGroup.BackColor = System.Drawing.Color.Transparent;
			this.adminGroup.Controls.Add(this.btnDelete);
			this.adminGroup.Controls.Add(this.btnEditUser);
			this.adminGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adminGroup.Location = new System.Drawing.Point(522, 33);
			this.adminGroup.Name = "adminGroup";
			this.adminGroup.Size = new System.Drawing.Size(241, 121);
			this.adminGroup.TabIndex = 9;
			this.adminGroup.TabStop = false;
			this.adminGroup.Text = "⚙";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(71, 41);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(114, 23);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Tag = "delete";
			this.btnDelete.Text = "Borrar";
			this.btnDelete.UseSelectable = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEditUser
			// 
			this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditUser.Location = new System.Drawing.Point(71, 70);
			this.btnEditUser.Name = "btnEditUser";
			this.btnEditUser.Size = new System.Drawing.Size(114, 23);
			this.btnEditUser.TabIndex = 8;
			this.btnEditUser.Tag = "edit";
			this.btnEditUser.Text = "Editar";
			this.btnEditUser.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnEditUser.UseSelectable = true;
			this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(724, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(39, 23);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Tag = "";
			this.btnSearch.Text = "🔎";
			this.btnSearch.UseSelectable = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(172, 1);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(522, 4);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(194, 23);
			this.txtNombre.TabIndex = 5;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnProfile
			// 
			this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnProfile.Location = new System.Drawing.Point(603, 316);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(114, 23);
			this.btnProfile.TabIndex = 4;
			this.btnProfile.Tag = "see_profile";
			this.btnProfile.Text = "Ver perfil";
			this.btnProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnProfile.UseSelectable = true;
			this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
			// 
			// btnReconocer
			// 
			this.btnReconocer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnReconocer.Location = new System.Drawing.Point(603, 286);
			this.btnReconocer.Name = "btnReconocer";
			this.btnReconocer.Size = new System.Drawing.Size(114, 23);
			this.btnReconocer.TabIndex = 3;
			this.btnReconocer.Tag = "recognize";
			this.btnReconocer.Text = "Reconocer";
			this.btnReconocer.UseSelectable = true;
			this.btnReconocer.Click += new System.EventHandler(this.btnReconocer_Click);
			// 
			// tabAdmin
			// 
			this.tabAdmin.Controls.Add(this.groupBox2);
			this.tabAdmin.Controls.Add(this.gbManage);
			this.tabAdmin.HorizontalScrollbarBarColor = true;
			this.tabAdmin.HorizontalScrollbarHighlightOnWheel = false;
			this.tabAdmin.HorizontalScrollbarSize = 10;
			this.tabAdmin.Location = new System.Drawing.Point(4, 38);
			this.tabAdmin.Name = "tabAdmin";
			this.tabAdmin.Size = new System.Drawing.Size(790, 351);
			this.tabAdmin.TabIndex = 2;
			this.tabAdmin.Text = "Admin";
			this.tabAdmin.VerticalScrollbarBarColor = true;
			this.tabAdmin.VerticalScrollbarHighlightOnWheel = false;
			this.tabAdmin.VerticalScrollbarSize = 10;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.btnReport);
			this.groupBox2.Controls.Add(this.btnBackUp);
			this.groupBox2.Controls.Add(this.btnBitacora);
			this.groupBox2.Controls.Add(this.btnRestDV);
			this.groupBox2.Controls.Add(this.btnAddUser);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(383, 191);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "⚙";
			// 
			// btnReport
			// 
			this.btnReport.Location = new System.Drawing.Point(30, 146);
			this.btnReport.Margin = new System.Windows.Forms.Padding(2);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(136, 23);
			this.btnReport.TabIndex = 6;
			this.btnReport.Tag = "export_report";
			this.btnReport.Text = "Exportar reporte";
			this.btnReport.UseSelectable = true;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// btnBackUp
			// 
			this.btnBackUp.Location = new System.Drawing.Point(30, 33);
			this.btnBackUp.Name = "btnBackUp";
			this.btnBackUp.Size = new System.Drawing.Size(136, 23);
			this.btnBackUp.TabIndex = 2;
			this.btnBackUp.Text = "Back up";
			this.btnBackUp.UseSelectable = true;
			this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
			// 
			// btnBitacora
			// 
			this.btnBitacora.Location = new System.Drawing.Point(30, 61);
			this.btnBitacora.Name = "btnBitacora";
			this.btnBitacora.Size = new System.Drawing.Size(136, 23);
			this.btnBitacora.TabIndex = 3;
			this.btnBitacora.Tag = "bitacore";
			this.btnBitacora.Text = "Bitacora";
			this.btnBitacora.UseSelectable = true;
			this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
			// 
			// btnRestDV
			// 
			this.btnRestDV.Location = new System.Drawing.Point(30, 89);
			this.btnRestDV.Margin = new System.Windows.Forms.Padding(2);
			this.btnRestDV.Name = "btnRestDV";
			this.btnRestDV.Size = new System.Drawing.Size(136, 23);
			this.btnRestDV.TabIndex = 4;
			this.btnRestDV.Tag = "rest_dv";
			this.btnRestDV.Text = "Restaurar DV";
			this.btnRestDV.UseSelectable = true;
			this.btnRestDV.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Location = new System.Drawing.Point(30, 117);
			this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(136, 23);
			this.btnAddUser.TabIndex = 5;
			this.btnAddUser.Tag = "add_user";
			this.btnAddUser.Text = "Agregar usuario";
			this.btnAddUser.UseSelectable = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// gbManage
			// 
			this.gbManage.BackColor = System.Drawing.Color.Transparent;
			this.gbManage.Controls.Add(this.btnRewards);
			this.gbManage.Controls.Add(this.metroButton1);
			this.gbManage.Controls.Add(this.btnEmblema);
			this.gbManage.Controls.Add(this.btnSectores);
			this.gbManage.Controls.Add(this.btnSectorTypes);
			this.gbManage.Location = new System.Drawing.Point(392, 16);
			this.gbManage.Name = "gbManage";
			this.gbManage.Size = new System.Drawing.Size(395, 186);
			this.gbManage.TabIndex = 16;
			this.gbManage.TabStop = false;
			this.gbManage.Tag = "manage";
			this.gbManage.Text = "Gestionar";
			// 
			// btnRewards
			// 
			this.btnRewards.Location = new System.Drawing.Point(43, 141);
			this.btnRewards.Name = "btnRewards";
			this.btnRewards.Size = new System.Drawing.Size(136, 23);
			this.btnRewards.TabIndex = 15;
			this.btnRewards.Tag = "rewards";
			this.btnRewards.Text = "Reconocimientos";
			this.btnRewards.UseSelectable = true;
			this.btnRewards.Click += new System.EventHandler(this.btnRewards_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(43, 28);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(136, 23);
			this.metroButton1.TabIndex = 14;
			this.metroButton1.Tag = "families";
			this.metroButton1.Text = "Familias";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_3);
			// 
			// btnEmblema
			// 
			this.btnEmblema.Location = new System.Drawing.Point(43, 56);
			this.btnEmblema.Margin = new System.Windows.Forms.Padding(2);
			this.btnEmblema.Name = "btnEmblema";
			this.btnEmblema.Size = new System.Drawing.Size(136, 23);
			this.btnEmblema.TabIndex = 10;
			this.btnEmblema.Tag = "emblems";
			this.btnEmblema.Text = "Emblemas";
			this.btnEmblema.UseSelectable = true;
			this.btnEmblema.Click += new System.EventHandler(this.btnEmblema_Click);
			// 
			// btnSectores
			// 
			this.btnSectores.Location = new System.Drawing.Point(43, 84);
			this.btnSectores.Name = "btnSectores";
			this.btnSectores.Size = new System.Drawing.Size(136, 23);
			this.btnSectores.TabIndex = 12;
			this.btnSectores.Tag = "sectors";
			this.btnSectores.Text = "Sectores";
			this.btnSectores.UseSelectable = true;
			this.btnSectores.Click += new System.EventHandler(this.btnSectores_Click);
			// 
			// btnSectorTypes
			// 
			this.btnSectorTypes.Location = new System.Drawing.Point(43, 112);
			this.btnSectorTypes.Name = "btnSectorTypes";
			this.btnSectorTypes.Size = new System.Drawing.Size(136, 23);
			this.btnSectorTypes.TabIndex = 13;
			this.btnSectorTypes.Tag = "positions";
			this.btnSectorTypes.Text = "Puestos";
			this.btnSectorTypes.UseSelectable = true;
			this.btnSectorTypes.Click += new System.EventHandler(this.btnSectorTypes_Click);
			// 
			// tabObjetivos
			// 
			this.tabObjetivos.Controls.Add(this.btnActualizar);
			this.tabObjetivos.Controls.Add(this.lbMyObj);
			this.tabObjetivos.Controls.Add(this.btnDetalleMiObjetivo);
			this.tabObjetivos.Controls.Add(this.btnDetalleObjetivo);
			this.tabObjetivos.Controls.Add(this.lbSectorObj);
			this.tabObjetivos.Controls.Add(this.lblObjetivosSector);
			this.tabObjetivos.Controls.Add(this.btnFinalizarObj);
			this.tabObjetivos.Controls.Add(this.btnAsignarseObj);
			this.tabObjetivos.Controls.Add(this.btnAgregarObj);
			this.tabObjetivos.Controls.Add(this.lblMisObjetivos);
			this.tabObjetivos.HorizontalScrollbarBarColor = true;
			this.tabObjetivos.HorizontalScrollbarHighlightOnWheel = false;
			this.tabObjetivos.HorizontalScrollbarSize = 8;
			this.tabObjetivos.Location = new System.Drawing.Point(4, 38);
			this.tabObjetivos.Margin = new System.Windows.Forms.Padding(2);
			this.tabObjetivos.Name = "tabObjetivos";
			this.tabObjetivos.Size = new System.Drawing.Size(790, 351);
			this.tabObjetivos.TabIndex = 3;
			this.tabObjetivos.Tag = "my_objectives";
			this.tabObjetivos.Text = "Mis objetivos";
			this.tabObjetivos.VerticalScrollbarBarColor = true;
			this.tabObjetivos.VerticalScrollbarHighlightOnWheel = false;
			this.tabObjetivos.VerticalScrollbarSize = 8;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(388, 42);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 13;
			this.btnActualizar.Tag = "update";
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseSelectable = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// lbMyObj
			// 
			this.lbMyObj.FormattingEnabled = true;
			this.lbMyObj.Location = new System.Drawing.Point(4, 42);
			this.lbMyObj.Name = "lbMyObj";
			this.lbMyObj.Size = new System.Drawing.Size(307, 173);
			this.lbMyObj.TabIndex = 12;
			// 
			// btnDetalleMiObjetivo
			// 
			this.btnDetalleMiObjetivo.Location = new System.Drawing.Point(120, 221);
			this.btnDetalleMiObjetivo.Name = "btnDetalleMiObjetivo";
			this.btnDetalleMiObjetivo.Size = new System.Drawing.Size(110, 23);
			this.btnDetalleMiObjetivo.TabIndex = 11;
			this.btnDetalleMiObjetivo.Tag = "see_detail";
			this.btnDetalleMiObjetivo.Text = "Detalle";
			this.btnDetalleMiObjetivo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnDetalleMiObjetivo.UseSelectable = true;
			this.btnDetalleMiObjetivo.Click += new System.EventHandler(this.metroButton1_Click_2);
			// 
			// btnDetalleObjetivo
			// 
			this.btnDetalleObjetivo.Location = new System.Drawing.Point(675, 221);
			this.btnDetalleObjetivo.Name = "btnDetalleObjetivo";
			this.btnDetalleObjetivo.Size = new System.Drawing.Size(110, 23);
			this.btnDetalleObjetivo.TabIndex = 10;
			this.btnDetalleObjetivo.Tag = "see_detail";
			this.btnDetalleObjetivo.Text = "Detalle";
			this.btnDetalleObjetivo.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnDetalleObjetivo.UseSelectable = true;
			this.btnDetalleObjetivo.Click += new System.EventHandler(this.btnEditObjetivo_Click);
			// 
			// lbSectorObj
			// 
			this.lbSectorObj.FormattingEnabled = true;
			this.lbSectorObj.Location = new System.Drawing.Point(478, 42);
			this.lbSectorObj.Name = "lbSectorObj";
			this.lbSectorObj.Size = new System.Drawing.Size(307, 173);
			this.lbSectorObj.TabIndex = 8;
			// 
			// lblObjetivosSector
			// 
			this.lblObjetivosSector.AutoSize = true;
			this.lblObjetivosSector.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblObjetivosSector.Location = new System.Drawing.Point(478, 14);
			this.lblObjetivosSector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblObjetivosSector.Name = "lblObjetivosSector";
			this.lblObjetivosSector.Size = new System.Drawing.Size(161, 25);
			this.lblObjetivosSector.TabIndex = 7;
			this.lblObjetivosSector.Tag = "sector_objectives";
			this.lblObjetivosSector.Text = "Objetivos del sector";
			// 
			// btnFinalizarObj
			// 
			this.btnFinalizarObj.Location = new System.Drawing.Point(236, 221);
			this.btnFinalizarObj.Name = "btnFinalizarObj";
			this.btnFinalizarObj.Size = new System.Drawing.Size(75, 23);
			this.btnFinalizarObj.TabIndex = 6;
			this.btnFinalizarObj.Tag = "finalize";
			this.btnFinalizarObj.Text = "Finalizar";
			this.btnFinalizarObj.UseSelectable = true;
			this.btnFinalizarObj.Click += new System.EventHandler(this.btnFinalizarObj_Click);
			// 
			// btnAsignarseObj
			// 
			this.btnAsignarseObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAsignarseObj.Location = new System.Drawing.Point(327, 112);
			this.btnAsignarseObj.Name = "btnAsignarseObj";
			this.btnAsignarseObj.Size = new System.Drawing.Size(136, 23);
			this.btnAsignarseObj.TabIndex = 5;
			this.btnAsignarseObj.Tag = "assign_new";
			this.btnAsignarseObj.Text = "< Asignarse nuevo <";
			this.btnAsignarseObj.UseSelectable = true;
			this.btnAsignarseObj.Click += new System.EventHandler(this.btnAsignarseObj_Click);
			// 
			// btnAgregarObj
			// 
			this.btnAgregarObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAgregarObj.Location = new System.Drawing.Point(649, 250);
			this.btnAgregarObj.Name = "btnAgregarObj";
			this.btnAgregarObj.Size = new System.Drawing.Size(136, 23);
			this.btnAgregarObj.TabIndex = 4;
			this.btnAgregarObj.Tag = "add";
			this.btnAgregarObj.Text = "Agregar";
			this.btnAgregarObj.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnAgregarObj.UseSelectable = true;
			this.btnAgregarObj.Click += new System.EventHandler(this.btnAgregarObj_Click);
			// 
			// lblMisObjetivos
			// 
			this.lblMisObjetivos.AutoSize = true;
			this.lblMisObjetivos.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblMisObjetivos.Location = new System.Drawing.Point(3, 13);
			this.lblMisObjetivos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMisObjetivos.Name = "lblMisObjetivos";
			this.lblMisObjetivos.Size = new System.Drawing.Size(110, 25);
			this.lblMisObjetivos.TabIndex = 2;
			this.lblMisObjetivos.Tag = "my_objectives";
			this.lblMisObjetivos.Text = "Mis objetivos";
			// 
			// tabJefe
			// 
			this.tabJefe.Controls.Add(this.groupBox1);
			this.tabJefe.HorizontalScrollbarBarColor = true;
			this.tabJefe.HorizontalScrollbarHighlightOnWheel = false;
			this.tabJefe.HorizontalScrollbarSize = 10;
			this.tabJefe.Location = new System.Drawing.Point(4, 38);
			this.tabJefe.Name = "tabJefe";
			this.tabJefe.Size = new System.Drawing.Size(790, 351);
			this.tabJefe.TabIndex = 4;
			this.tabJefe.Tag = "boss";
			this.tabJefe.Text = "Jefe";
			this.tabJefe.VerticalScrollbarBarColor = true;
			this.tabJefe.VerticalScrollbarHighlightOnWheel = false;
			this.tabJefe.VerticalScrollbarSize = 10;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnAdminSectorDetail);
			this.groupBox1.Controls.Add(this.cmbAdminSectorList);
			this.groupBox1.Location = new System.Drawing.Point(12, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(358, 100);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Admin Sector";
			// 
			// btnAdminSectorDetail
			// 
			this.btnAdminSectorDetail.Location = new System.Drawing.Point(242, 39);
			this.btnAdminSectorDetail.Name = "btnAdminSectorDetail";
			this.btnAdminSectorDetail.Size = new System.Drawing.Size(90, 29);
			this.btnAdminSectorDetail.TabIndex = 11;
			this.btnAdminSectorDetail.Tag = "see_detail";
			this.btnAdminSectorDetail.Text = "Ver detalle";
			this.btnAdminSectorDetail.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnAdminSectorDetail.UseSelectable = true;
			this.btnAdminSectorDetail.Click += new System.EventHandler(this.btnAdminSectorDetail_Click);
			// 
			// cmbAdminSectorList
			// 
			this.cmbAdminSectorList.FormattingEnabled = true;
			this.cmbAdminSectorList.ItemHeight = 23;
			this.cmbAdminSectorList.Location = new System.Drawing.Point(42, 39);
			this.cmbAdminSectorList.Name = "cmbAdminSectorList";
			this.cmbAdminSectorList.Size = new System.Drawing.Size(185, 29);
			this.cmbAdminSectorList.TabIndex = 0;
			this.cmbAdminSectorList.UseSelectable = true;
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(740, 467);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 23);
			this.btnHelp.TabIndex = 18;
			this.btnHelp.Tag = "help";
			this.btnHelp.Text = "Ayuda";
			this.btnHelp.UseSelectable = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(845, 505);
			this.ControlBox = false;
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.imgProfile);
			this.Controls.Add(this.lblNotification);
			this.Controls.Add(this.lblLang);
			this.Controls.Add(this.cmbLanguage);
			this.Controls.Add(this.imgNotification);
			this.Controls.Add(this.imgLogout);
			this.Controls.Add(this.tabs);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Home";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Text = "aWords";
			this.Load += new System.EventHandler(this.Home_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgNotification)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgLogout)).EndInit();
			this.tabs.ResumeLayout(false);
			this.tabEmpleados.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.adminGroup.ResumeLayout(false);
			this.tabAdmin.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.gbManage.ResumeLayout(false);
			this.tabObjetivos.ResumeLayout(false);
			this.tabObjetivos.PerformLayout();
			this.tabJefe.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl tabs;
		private MetroFramework.Controls.MetroTabPage tabEmpleados;
		private MetroFramework.Controls.MetroTabPage tabAdmin;
		private MetroFramework.Controls.MetroButton btnBackUp;
		private MetroFramework.Controls.MetroButton btnBitacora;
		private MetroFramework.Controls.MetroButton btnRestDV;
		private System.Windows.Forms.PictureBox imgLogout;
		private System.Windows.Forms.PictureBox imgNotification;
		private MetroFramework.Controls.MetroLabel lblLang;
		private MetroFramework.Controls.MetroComboBox cmbLanguage;
		private MetroFramework.Controls.MetroButton btnProfile;
		private MetroFramework.Controls.MetroButton btnReconocer;
		private MetroFramework.Controls.MetroButton btnSearch;
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroLabel lblNotification;
		private System.Windows.Forms.PictureBox imgProfile;
		private MetroFramework.Controls.MetroButton btnAddUser;
		private MetroFramework.Controls.MetroButton btnEmblema;
		private MetroFramework.Controls.MetroButton btnSectores;
		private MetroFramework.Controls.MetroButton btnSectorTypes;
		private MetroFramework.Controls.MetroTabPage tabObjetivos;
		private MetroFramework.Controls.MetroLabel lblMisObjetivos;
		private MetroFramework.Controls.MetroButton btnFinalizarObj;
		private MetroFramework.Controls.MetroButton btnAsignarseObj;
		private MetroFramework.Controls.MetroButton btnAgregarObj;
		private System.Windows.Forms.ListBox lbSectorObj;
		private MetroFramework.Controls.MetroLabel lblObjetivosSector;
        private MetroFramework.Controls.MetroButton btnDetalleObjetivo;
        private MetroFramework.Controls.MetroButton btnDetalleMiObjetivo;
		private System.Windows.Forms.ListBox lbMyObj;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroButton btnAdminSectorDetail;
		private MetroFramework.Controls.MetroComboBox cmbAdminSectorList;
		private System.Windows.Forms.GroupBox gbManage;
		private MetroFramework.Controls.MetroButton btnActualizar;
		private System.Windows.Forms.GroupBox groupBox2;
		private MetroFramework.Controls.MetroButton btnEditUser;
		private System.Windows.Forms.GroupBox adminGroup;
		private MetroFramework.Controls.MetroButton btnDelete;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private MetroFramework.Controls.MetroButton btnRewards;
		private MetroFramework.Controls.MetroTabPage tabJefe;
		private MetroFramework.Controls.MetroButton btnHelp;
		private MetroFramework.Controls.MetroButton btnReport;
		private System.Windows.Forms.SaveFileDialog exportData;
	}
}