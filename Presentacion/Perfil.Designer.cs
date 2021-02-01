namespace Presentacion {
	partial class Perfil {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
			this.btnPass = new MetroFramework.Controls.MetroButton();
			this.lblSector = new MetroFramework.Controls.MetroLabel();
			this.lblMail = new MetroFramework.Controls.MetroLabel();
			this.txtMail = new MetroFramework.Controls.MetroTextBox();
			this.lblApellido = new MetroFramework.Controls.MetroLabel();
			this.txtApellido = new MetroFramework.Controls.MetroTextBox();
			this.lblNombre = new MetroFramework.Controls.MetroLabel();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.lblUsername = new MetroFramework.Controls.MetroLabel();
			this.tabProfile = new MetroFramework.Controls.MetroTabControl();
			this.tabPersonal = new MetroFramework.Controls.MetroTabPage();
			this.txtDateEnter = new MetroFramework.Controls.MetroTextBox();
			this.lblDateEnter = new MetroFramework.Controls.MetroLabel();
			this.txtPuesto = new MetroFramework.Controls.MetroTextBox();
			this.txtSector = new MetroFramework.Controls.MetroTextBox();
			this.txtPermiso = new MetroFramework.Controls.MetroTextBox();
			this.lblPuesto = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.lblRol = new MetroFramework.Controls.MetroLabel();
			this.tabRecon = new MetroFramework.Controls.MetroTabPage();
			this.lbEmblemasRecibidos = new System.Windows.Forms.ListBox();
			this.lbReconocimientosEnviados = new System.Windows.Forms.ListBox();
			this.lbReconocimientosRecibidos = new System.Windows.Forms.ListBox();
			this.lblEmblemas = new MetroFramework.Controls.MetroLabel();
			this.lblReceived = new MetroFramework.Controls.MetroLabel();
			this.lblSent = new MetroFramework.Controls.MetroLabel();
			this.lblReconocimiento = new MetroFramework.Controls.MetroLabel();
			this.tabPass = new MetroFramework.Controls.MetroTabPage();
			this.lblResponse = new MetroFramework.Controls.MetroLabel();
			this.lblOldPass = new MetroFramework.Controls.MetroLabel();
			this.txtOldPass = new MetroFramework.Controls.MetroTextBox();
			this.lblNewPass = new MetroFramework.Controls.MetroLabel();
			this.txtNewPass = new MetroFramework.Controls.MetroTextBox();
			this.tabProfile.SuspendLayout();
			this.tabPersonal.SuspendLayout();
			this.tabRecon.SuspendLayout();
			this.tabPass.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnPass
			// 
			this.btnPass.Location = new System.Drawing.Point(132, 94);
			this.btnPass.Name = "btnPass";
			this.btnPass.Size = new System.Drawing.Size(161, 23);
			this.btnPass.TabIndex = 3;
			this.btnPass.Tag = "update";
			this.btnPass.Text = "Actualizar";
			this.btnPass.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnPass.UseSelectable = true;
			this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
			// 
			// lblSector
			// 
			this.lblSector.AutoSize = true;
			this.lblSector.Location = new System.Drawing.Point(23, 94);
			this.lblSector.Name = "lblSector";
			this.lblSector.Size = new System.Drawing.Size(46, 19);
			this.lblSector.TabIndex = 10;
			this.lblSector.Text = "Sector";
			this.lblSector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblSector.WrapToLine = true;
			// 
			// lblMail
			// 
			this.lblMail.Location = new System.Drawing.Point(10, 111);
			this.lblMail.Name = "lblMail";
			this.lblMail.Size = new System.Drawing.Size(180, 19);
			this.lblMail.TabIndex = 8;
			this.lblMail.Text = "Mail";
			this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblMail.WrapToLine = true;
			// 
			// txtMail
			// 
			// 
			// 
			// 
			this.txtMail.CustomButton.Image = null;
			this.txtMail.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtMail.CustomButton.Name = "";
			this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtMail.CustomButton.TabIndex = 1;
			this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtMail.CustomButton.UseSelectable = true;
			this.txtMail.CustomButton.Visible = false;
			this.txtMail.Enabled = false;
			this.txtMail.Lines = new string[0];
			this.txtMail.Location = new System.Drawing.Point(196, 107);
			this.txtMail.MaxLength = 32767;
			this.txtMail.Name = "txtMail";
			this.txtMail.PasswordChar = '\0';
			this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMail.SelectedText = "";
			this.txtMail.SelectionLength = 0;
			this.txtMail.SelectionStart = 0;
			this.txtMail.ShortcutsEnabled = true;
			this.txtMail.Size = new System.Drawing.Size(202, 23);
			this.txtMail.TabIndex = 4;
			this.txtMail.UseSelectable = true;
			this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblApellido
			// 
			this.lblApellido.Location = new System.Drawing.Point(10, 81);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(180, 19);
			this.lblApellido.TabIndex = 6;
			this.lblApellido.Tag = "lastname";
			this.lblApellido.Text = "Apellido";
			this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblApellido.WrapToLine = true;
			// 
			// txtApellido
			// 
			// 
			// 
			// 
			this.txtApellido.CustomButton.Image = null;
			this.txtApellido.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtApellido.CustomButton.Name = "";
			this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtApellido.CustomButton.TabIndex = 1;
			this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtApellido.CustomButton.UseSelectable = true;
			this.txtApellido.CustomButton.Visible = false;
			this.txtApellido.Enabled = false;
			this.txtApellido.Lines = new string[0];
			this.txtApellido.Location = new System.Drawing.Point(196, 77);
			this.txtApellido.MaxLength = 32767;
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.PasswordChar = '\0';
			this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtApellido.SelectedText = "";
			this.txtApellido.SelectionLength = 0;
			this.txtApellido.SelectionStart = 0;
			this.txtApellido.ShortcutsEnabled = true;
			this.txtApellido.Size = new System.Drawing.Size(202, 23);
			this.txtApellido.TabIndex = 3;
			this.txtApellido.UseSelectable = true;
			this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(10, 51);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(180, 19);
			this.lblNombre.TabIndex = 4;
			this.lblNombre.Tag = "name";
			this.lblNombre.Text = "Nombre";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNombre.WrapToLine = true;
			// 
			// txtNombre
			// 
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Enabled = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(196, 47);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(202, 23);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblUsername.Location = new System.Drawing.Point(23, 69);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(160, 25);
			this.lblUsername.TabIndex = 2;
			this.lblUsername.Text = "Nombre de usuario";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblUsername.WrapToLine = true;
			// 
			// tabProfile
			// 
			this.tabProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabProfile.Controls.Add(this.tabPersonal);
			this.tabProfile.Controls.Add(this.tabRecon);
			this.tabProfile.Controls.Add(this.tabPass);
			this.tabProfile.Location = new System.Drawing.Point(23, 116);
			this.tabProfile.Name = "tabProfile";
			this.tabProfile.SelectedIndex = 0;
			this.tabProfile.Size = new System.Drawing.Size(766, 383);
			this.tabProfile.TabIndex = 15;
			this.tabProfile.Tag = "";
			this.tabProfile.UseSelectable = true;
			// 
			// tabPersonal
			// 
			this.tabPersonal.Controls.Add(this.txtDateEnter);
			this.tabPersonal.Controls.Add(this.lblDateEnter);
			this.tabPersonal.Controls.Add(this.txtPuesto);
			this.tabPersonal.Controls.Add(this.txtSector);
			this.tabPersonal.Controls.Add(this.txtPermiso);
			this.tabPersonal.Controls.Add(this.lblPuesto);
			this.tabPersonal.Controls.Add(this.metroLabel1);
			this.tabPersonal.Controls.Add(this.lblRol);
			this.tabPersonal.Controls.Add(this.lblMail);
			this.tabPersonal.Controls.Add(this.txtNombre);
			this.tabPersonal.Controls.Add(this.txtMail);
			this.tabPersonal.Controls.Add(this.lblNombre);
			this.tabPersonal.Controls.Add(this.lblApellido);
			this.tabPersonal.Controls.Add(this.txtApellido);
			this.tabPersonal.HorizontalScrollbarBarColor = true;
			this.tabPersonal.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPersonal.HorizontalScrollbarSize = 10;
			this.tabPersonal.Location = new System.Drawing.Point(4, 38);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Size = new System.Drawing.Size(758, 341);
			this.tabPersonal.TabIndex = 0;
			this.tabPersonal.Tag = "personal_data";
			this.tabPersonal.Text = "Datos personales";
			this.tabPersonal.VerticalScrollbarBarColor = true;
			this.tabPersonal.VerticalScrollbarHighlightOnWheel = false;
			this.tabPersonal.VerticalScrollbarSize = 10;
			// 
			// txtDateEnter
			// 
			// 
			// 
			// 
			this.txtDateEnter.CustomButton.Image = null;
			this.txtDateEnter.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtDateEnter.CustomButton.Name = "";
			this.txtDateEnter.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtDateEnter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDateEnter.CustomButton.TabIndex = 1;
			this.txtDateEnter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDateEnter.CustomButton.UseSelectable = true;
			this.txtDateEnter.CustomButton.Visible = false;
			this.txtDateEnter.Enabled = false;
			this.txtDateEnter.Lines = new string[0];
			this.txtDateEnter.Location = new System.Drawing.Point(196, 226);
			this.txtDateEnter.MaxLength = 32767;
			this.txtDateEnter.Name = "txtDateEnter";
			this.txtDateEnter.PasswordChar = '\0';
			this.txtDateEnter.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDateEnter.SelectedText = "";
			this.txtDateEnter.SelectionLength = 0;
			this.txtDateEnter.SelectionStart = 0;
			this.txtDateEnter.ShortcutsEnabled = true;
			this.txtDateEnter.Size = new System.Drawing.Size(202, 23);
			this.txtDateEnter.TabIndex = 40;
			this.txtDateEnter.UseSelectable = true;
			this.txtDateEnter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDateEnter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblDateEnter
			// 
			this.lblDateEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDateEnter.Location = new System.Drawing.Point(10, 230);
			this.lblDateEnter.Name = "lblDateEnter";
			this.lblDateEnter.Size = new System.Drawing.Size(180, 19);
			this.lblDateEnter.TabIndex = 39;
			this.lblDateEnter.Tag = "enter_date";
			this.lblDateEnter.Text = "Fecha ingreso";
			this.lblDateEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblDateEnter.WrapToLine = true;
			// 
			// txtPuesto
			// 
			// 
			// 
			// 
			this.txtPuesto.CustomButton.Image = null;
			this.txtPuesto.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtPuesto.CustomButton.Name = "";
			this.txtPuesto.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPuesto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPuesto.CustomButton.TabIndex = 1;
			this.txtPuesto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPuesto.CustomButton.UseSelectable = true;
			this.txtPuesto.CustomButton.Visible = false;
			this.txtPuesto.Enabled = false;
			this.txtPuesto.Lines = new string[0];
			this.txtPuesto.Location = new System.Drawing.Point(196, 197);
			this.txtPuesto.MaxLength = 32767;
			this.txtPuesto.Name = "txtPuesto";
			this.txtPuesto.PasswordChar = '\0';
			this.txtPuesto.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPuesto.SelectedText = "";
			this.txtPuesto.SelectionLength = 0;
			this.txtPuesto.SelectionStart = 0;
			this.txtPuesto.ShortcutsEnabled = true;
			this.txtPuesto.Size = new System.Drawing.Size(202, 23);
			this.txtPuesto.TabIndex = 38;
			this.txtPuesto.UseSelectable = true;
			this.txtPuesto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPuesto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtSector
			// 
			// 
			// 
			// 
			this.txtSector.CustomButton.Image = null;
			this.txtSector.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtSector.CustomButton.Name = "";
			this.txtSector.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtSector.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtSector.CustomButton.TabIndex = 1;
			this.txtSector.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtSector.CustomButton.UseSelectable = true;
			this.txtSector.CustomButton.Visible = false;
			this.txtSector.Enabled = false;
			this.txtSector.Lines = new string[0];
			this.txtSector.Location = new System.Drawing.Point(196, 167);
			this.txtSector.MaxLength = 32767;
			this.txtSector.Name = "txtSector";
			this.txtSector.PasswordChar = '\0';
			this.txtSector.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSector.SelectedText = "";
			this.txtSector.SelectionLength = 0;
			this.txtSector.SelectionStart = 0;
			this.txtSector.ShortcutsEnabled = true;
			this.txtSector.Size = new System.Drawing.Size(202, 23);
			this.txtSector.TabIndex = 37;
			this.txtSector.UseSelectable = true;
			this.txtSector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtPermiso
			// 
			// 
			// 
			// 
			this.txtPermiso.CustomButton.Image = null;
			this.txtPermiso.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtPermiso.CustomButton.Name = "";
			this.txtPermiso.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtPermiso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPermiso.CustomButton.TabIndex = 1;
			this.txtPermiso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPermiso.CustomButton.UseSelectable = true;
			this.txtPermiso.CustomButton.Visible = false;
			this.txtPermiso.Enabled = false;
			this.txtPermiso.Lines = new string[0];
			this.txtPermiso.Location = new System.Drawing.Point(196, 137);
			this.txtPermiso.MaxLength = 32767;
			this.txtPermiso.Name = "txtPermiso";
			this.txtPermiso.PasswordChar = '\0';
			this.txtPermiso.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPermiso.SelectedText = "";
			this.txtPermiso.SelectionLength = 0;
			this.txtPermiso.SelectionStart = 0;
			this.txtPermiso.ShortcutsEnabled = true;
			this.txtPermiso.Size = new System.Drawing.Size(202, 23);
			this.txtPermiso.TabIndex = 36;
			this.txtPermiso.UseSelectable = true;
			this.txtPermiso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPermiso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblPuesto
			// 
			this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPuesto.Location = new System.Drawing.Point(10, 201);
			this.lblPuesto.Name = "lblPuesto";
			this.lblPuesto.Size = new System.Drawing.Size(180, 19);
			this.lblPuesto.TabIndex = 34;
			this.lblPuesto.Tag = "position";
			this.lblPuesto.Text = "Puesto";
			this.lblPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblPuesto.WrapToLine = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel1.Location = new System.Drawing.Point(10, 171);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(180, 19);
			this.metroLabel1.TabIndex = 32;
			this.metroLabel1.Tag = "";
			this.metroLabel1.Text = "Sector";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroLabel1.WrapToLine = true;
			// 
			// lblRol
			// 
			this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRol.Location = new System.Drawing.Point(10, 141);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(180, 19);
			this.lblRol.TabIndex = 29;
			this.lblRol.Tag = "role";
			this.lblRol.Text = "Permiso";
			this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblRol.WrapToLine = true;
			// 
			// tabRecon
			// 
			this.tabRecon.Controls.Add(this.lbEmblemasRecibidos);
			this.tabRecon.Controls.Add(this.lbReconocimientosEnviados);
			this.tabRecon.Controls.Add(this.lbReconocimientosRecibidos);
			this.tabRecon.Controls.Add(this.lblEmblemas);
			this.tabRecon.Controls.Add(this.lblReceived);
			this.tabRecon.Controls.Add(this.lblSent);
			this.tabRecon.Controls.Add(this.lblReconocimiento);
			this.tabRecon.HorizontalScrollbarBarColor = true;
			this.tabRecon.HorizontalScrollbarHighlightOnWheel = false;
			this.tabRecon.HorizontalScrollbarSize = 10;
			this.tabRecon.Location = new System.Drawing.Point(4, 38);
			this.tabRecon.Name = "tabRecon";
			this.tabRecon.Size = new System.Drawing.Size(758, 341);
			this.tabRecon.TabIndex = 1;
			this.tabRecon.Tag = "rewards";
			this.tabRecon.Text = "Reconocimientos";
			this.tabRecon.VerticalScrollbarBarColor = true;
			this.tabRecon.VerticalScrollbarHighlightOnWheel = false;
			this.tabRecon.VerticalScrollbarSize = 10;
			// 
			// lbEmblemasRecibidos
			// 
			this.lbEmblemasRecibidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbEmblemasRecibidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmblemasRecibidos.FormattingEnabled = true;
			this.lbEmblemasRecibidos.ItemHeight = 16;
			this.lbEmblemasRecibidos.Location = new System.Drawing.Point(514, 47);
			this.lbEmblemasRecibidos.Margin = new System.Windows.Forms.Padding(2);
			this.lbEmblemasRecibidos.Name = "lbEmblemasRecibidos";
			this.lbEmblemasRecibidos.Size = new System.Drawing.Size(244, 208);
			this.lbEmblemasRecibidos.TabIndex = 8;
			// 
			// lbReconocimientosEnviados
			// 
			this.lbReconocimientosEnviados.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbReconocimientosEnviados.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbReconocimientosEnviados.FormattingEnabled = true;
			this.lbReconocimientosEnviados.ItemHeight = 16;
			this.lbReconocimientosEnviados.Location = new System.Drawing.Point(258, 73);
			this.lbReconocimientosEnviados.Margin = new System.Windows.Forms.Padding(2);
			this.lbReconocimientosEnviados.Name = "lbReconocimientosEnviados";
			this.lbReconocimientosEnviados.Size = new System.Drawing.Size(244, 176);
			this.lbReconocimientosEnviados.TabIndex = 7;
			// 
			// lbReconocimientosRecibidos
			// 
			this.lbReconocimientosRecibidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbReconocimientosRecibidos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbReconocimientosRecibidos.FormattingEnabled = true;
			this.lbReconocimientosRecibidos.ItemHeight = 16;
			this.lbReconocimientosRecibidos.Location = new System.Drawing.Point(2, 73);
			this.lbReconocimientosRecibidos.Margin = new System.Windows.Forms.Padding(2);
			this.lbReconocimientosRecibidos.Name = "lbReconocimientosRecibidos";
			this.lbReconocimientosRecibidos.Size = new System.Drawing.Size(244, 176);
			this.lbReconocimientosRecibidos.TabIndex = 6;
			// 
			// lblEmblemas
			// 
			this.lblEmblemas.AutoSize = true;
			this.lblEmblemas.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblEmblemas.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblEmblemas.Location = new System.Drawing.Point(514, 15);
			this.lblEmblemas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEmblemas.Name = "lblEmblemas";
			this.lblEmblemas.Size = new System.Drawing.Size(98, 25);
			this.lblEmblemas.TabIndex = 5;
			this.lblEmblemas.Tag = "emblem";
			this.lblEmblemas.Text = "Emblemas";
			// 
			// lblReceived
			// 
			this.lblReceived.AutoSize = true;
			this.lblReceived.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblReceived.Location = new System.Drawing.Point(2, 50);
			this.lblReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblReceived.Name = "lblReceived";
			this.lblReceived.Size = new System.Drawing.Size(84, 25);
			this.lblReceived.TabIndex = 4;
			this.lblReceived.Tag = "received";
			this.lblReceived.Text = "Recibidos";
			// 
			// lblSent
			// 
			this.lblSent.AutoSize = true;
			this.lblSent.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblSent.Location = new System.Drawing.Point(258, 50);
			this.lblSent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblSent.Name = "lblSent";
			this.lblSent.Size = new System.Drawing.Size(79, 25);
			this.lblSent.TabIndex = 3;
			this.lblSent.Tag = "sent";
			this.lblSent.Text = "Enviados";
			// 
			// lblReconocimiento
			// 
			this.lblReconocimiento.AutoSize = true;
			this.lblReconocimiento.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblReconocimiento.FontWeight = MetroFramework.MetroLabelWeight.Bold;
			this.lblReconocimiento.Location = new System.Drawing.Point(2, 15);
			this.lblReconocimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblReconocimiento.Name = "lblReconocimiento";
			this.lblReconocimiento.Size = new System.Drawing.Size(158, 25);
			this.lblReconocimiento.TabIndex = 2;
			this.lblReconocimiento.Tag = "rewards";
			this.lblReconocimiento.Text = "Reconocimientos";
			// 
			// tabPass
			// 
			this.tabPass.Controls.Add(this.lblResponse);
			this.tabPass.Controls.Add(this.lblOldPass);
			this.tabPass.Controls.Add(this.txtOldPass);
			this.tabPass.Controls.Add(this.lblNewPass);
			this.tabPass.Controls.Add(this.txtNewPass);
			this.tabPass.Controls.Add(this.btnPass);
			this.tabPass.HorizontalScrollbarBarColor = true;
			this.tabPass.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPass.HorizontalScrollbarSize = 10;
			this.tabPass.Location = new System.Drawing.Point(4, 38);
			this.tabPass.Name = "tabPass";
			this.tabPass.Size = new System.Drawing.Size(758, 341);
			this.tabPass.TabIndex = 2;
			this.tabPass.Tag = "password";
			this.tabPass.Text = "Contraseña";
			this.tabPass.VerticalScrollbarBarColor = true;
			this.tabPass.VerticalScrollbarHighlightOnWheel = false;
			this.tabPass.VerticalScrollbarSize = 10;
			// 
			// lblResponse
			// 
			this.lblResponse.AutoSize = true;
			this.lblResponse.ForeColor = System.Drawing.Color.Black;
			this.lblResponse.Location = new System.Drawing.Point(310, 99);
			this.lblResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(0, 0);
			this.lblResponse.TabIndex = 30;
			this.lblResponse.UseCustomForeColor = true;
			// 
			// lblOldPass
			// 
			this.lblOldPass.AutoSize = true;
			this.lblOldPass.Location = new System.Drawing.Point(13, 39);
			this.lblOldPass.Name = "lblOldPass";
			this.lblOldPass.Size = new System.Drawing.Size(104, 19);
			this.lblOldPass.TabIndex = 18;
			this.lblOldPass.Tag = "old_pass";
			this.lblOldPass.Text = "Vieja contraseña";
			// 
			// txtOldPass
			// 
			// 
			// 
			// 
			this.txtOldPass.CustomButton.Image = null;
			this.txtOldPass.CustomButton.Location = new System.Drawing.Point(139, 1);
			this.txtOldPass.CustomButton.Name = "";
			this.txtOldPass.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtOldPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtOldPass.CustomButton.TabIndex = 1;
			this.txtOldPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtOldPass.CustomButton.UseSelectable = true;
			this.txtOldPass.CustomButton.Visible = false;
			this.txtOldPass.Lines = new string[0];
			this.txtOldPass.Location = new System.Drawing.Point(132, 36);
			this.txtOldPass.MaxLength = 32767;
			this.txtOldPass.Name = "txtOldPass";
			this.txtOldPass.PasswordChar = '\0';
			this.txtOldPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtOldPass.SelectedText = "";
			this.txtOldPass.SelectionLength = 0;
			this.txtOldPass.SelectionStart = 0;
			this.txtOldPass.ShortcutsEnabled = true;
			this.txtOldPass.Size = new System.Drawing.Size(161, 23);
			this.txtOldPass.TabIndex = 1;
			this.txtOldPass.UseSelectable = true;
			this.txtOldPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtOldPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblNewPass
			// 
			this.lblNewPass.AutoSize = true;
			this.lblNewPass.Location = new System.Drawing.Point(13, 68);
			this.lblNewPass.Name = "lblNewPass";
			this.lblNewPass.Size = new System.Drawing.Size(113, 19);
			this.lblNewPass.TabIndex = 16;
			this.lblNewPass.Tag = "new_pass";
			this.lblNewPass.Text = "Nueva contraseña";
			// 
			// txtNewPass
			// 
			// 
			// 
			// 
			this.txtNewPass.CustomButton.Image = null;
			this.txtNewPass.CustomButton.Location = new System.Drawing.Point(139, 1);
			this.txtNewPass.CustomButton.Name = "";
			this.txtNewPass.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNewPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNewPass.CustomButton.TabIndex = 1;
			this.txtNewPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNewPass.CustomButton.UseSelectable = true;
			this.txtNewPass.CustomButton.Visible = false;
			this.txtNewPass.Lines = new string[0];
			this.txtNewPass.Location = new System.Drawing.Point(132, 65);
			this.txtNewPass.MaxLength = 32767;
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.PasswordChar = '\0';
			this.txtNewPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNewPass.SelectedText = "";
			this.txtNewPass.SelectionLength = 0;
			this.txtNewPass.SelectionStart = 0;
			this.txtNewPass.ShortcutsEnabled = true;
			this.txtNewPass.Size = new System.Drawing.Size(161, 23);
			this.txtNewPass.TabIndex = 2;
			this.txtNewPass.UseSelectable = true;
			this.txtNewPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNewPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// Perfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 517);
			this.Controls.Add(this.tabProfile);
			this.Controls.Add(this.lblSector);
			this.Controls.Add(this.lblUsername);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Perfil";
			this.Resizable = false;
			this.Tag = "";
			this.Text = "Ver perfil";
			this.Load += new System.EventHandler(this.VerPerfil_Load);
			this.tabProfile.ResumeLayout(false);
			this.tabPersonal.ResumeLayout(false);
			this.tabRecon.ResumeLayout(false);
			this.tabRecon.PerformLayout();
			this.tabPass.ResumeLayout(false);
			this.tabPass.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroLabel lblUsername;
		private MetroFramework.Controls.MetroTextBox txtApellido;
		private MetroFramework.Controls.MetroLabel lblNombre;
		private MetroFramework.Controls.MetroTextBox txtMail;
		private MetroFramework.Controls.MetroLabel lblApellido;
		private MetroFramework.Controls.MetroLabel lblMail;
		private MetroFramework.Controls.MetroLabel lblSector;
		private MetroFramework.Controls.MetroButton btnPass;
		private MetroFramework.Controls.MetroTabControl tabProfile;
		private MetroFramework.Controls.MetroTabPage tabPersonal;
		private MetroFramework.Controls.MetroTabPage tabRecon;
		private MetroFramework.Controls.MetroTabPage tabPass;
		private MetroFramework.Controls.MetroLabel lblNewPass;
		private MetroFramework.Controls.MetroTextBox txtNewPass;
		private MetroFramework.Controls.MetroLabel lblOldPass;
		private MetroFramework.Controls.MetroTextBox txtOldPass;
		private MetroFramework.Controls.MetroLabel lblResponse;
		private MetroFramework.Controls.MetroLabel lblRol;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.ListBox lbEmblemasRecibidos;
		private System.Windows.Forms.ListBox lbReconocimientosEnviados;
		private System.Windows.Forms.ListBox lbReconocimientosRecibidos;
		private MetroFramework.Controls.MetroLabel lblEmblemas;
		private MetroFramework.Controls.MetroLabel lblReceived;
		private MetroFramework.Controls.MetroLabel lblSent;
		private MetroFramework.Controls.MetroLabel lblReconocimiento;
		private MetroFramework.Controls.MetroLabel lblPuesto;
		private MetroFramework.Controls.MetroTextBox txtPuesto;
		private MetroFramework.Controls.MetroTextBox txtSector;
		private MetroFramework.Controls.MetroTextBox txtPermiso;
		private MetroFramework.Controls.MetroTextBox txtDateEnter;
		private MetroFramework.Controls.MetroLabel lblDateEnter;
	}
}