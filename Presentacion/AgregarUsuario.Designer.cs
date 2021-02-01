namespace Presentacion {
	partial class AgregarUsuario {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
			this.txtUsername = new MetroFramework.Controls.MetroTextBox();
			this.lblUsername = new MetroFramework.Controls.MetroLabel();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.lblMail = new MetroFramework.Controls.MetroLabel();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.txtMail = new MetroFramework.Controls.MetroTextBox();
			this.lblNombre = new MetroFramework.Controls.MetroLabel();
			this.lblApellido = new MetroFramework.Controls.MetroLabel();
			this.txtApellido = new MetroFramework.Controls.MetroTextBox();
			this.lblRol = new MetroFramework.Controls.MetroLabel();
			this.cmbRol = new MetroFramework.Controls.MetroComboBox();
			this.lblResponse = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.lbPuestos = new MetroFramework.Controls.MetroComboBox();
			this.lblPuesto = new MetroFramework.Controls.MetroLabel();
			this.txtSector = new MetroFramework.Controls.MetroTextBox();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtUsername.CustomButton.Image = null;
			this.txtUsername.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtUsername.CustomButton.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsername.CustomButton.Name = "";
			this.txtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtUsername.CustomButton.TabIndex = 1;
			this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtUsername.CustomButton.UseSelectable = true;
			this.txtUsername.CustomButton.Visible = false;
			this.txtUsername.Enabled = false;
			this.txtUsername.Lines = new string[0];
			this.txtUsername.Location = new System.Drawing.Point(235, 78);
			this.txtUsername.MaxLength = 32767;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.PasswordChar = '\0';
			this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtUsername.SelectedText = "";
			this.txtUsername.SelectionLength = 0;
			this.txtUsername.SelectionStart = 0;
			this.txtUsername.ShortcutsEnabled = true;
			this.txtUsername.Size = new System.Drawing.Size(202, 23);
			this.txtUsername.TabIndex = 1;
			this.txtUsername.UseSelectable = true;
			this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsername.Location = new System.Drawing.Point(49, 78);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(180, 23);
			this.lblUsername.TabIndex = 23;
			this.lblUsername.Tag = "username";
			this.lblUsername.Text = "Nombre de usuario";
			this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblUsername.WrapToLine = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.Location = new System.Drawing.Point(383, 311);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(55, 23);
			this.btnGuardar.TabIndex = 26;
			this.btnGuardar.Tag = "";
			this.btnGuardar.Text = "✔";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblMail
			// 
			this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMail.Location = new System.Drawing.Point(49, 167);
			this.lblMail.Name = "lblMail";
			this.lblMail.Size = new System.Drawing.Size(180, 19);
			this.lblMail.TabIndex = 21;
			this.lblMail.Text = "Mail";
			this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblMail.WrapToLine = true;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtNombre.CustomButton.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(235, 107);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(202, 23);
			this.txtNombre.TabIndex = 16;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtMail
			// 
			this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtMail.CustomButton.Image = null;
			this.txtMail.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtMail.CustomButton.Margin = new System.Windows.Forms.Padding(4);
			this.txtMail.CustomButton.Name = "";
			this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtMail.CustomButton.TabIndex = 1;
			this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtMail.CustomButton.UseSelectable = true;
			this.txtMail.CustomButton.Visible = false;
			this.txtMail.Lines = new string[0];
			this.txtMail.Location = new System.Drawing.Point(235, 165);
			this.txtMail.MaxLength = 32767;
			this.txtMail.Name = "txtMail";
			this.txtMail.PasswordChar = '\0';
			this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtMail.SelectedText = "";
			this.txtMail.SelectionLength = 0;
			this.txtMail.SelectionStart = 0;
			this.txtMail.ShortcutsEnabled = true;
			this.txtMail.Size = new System.Drawing.Size(202, 23);
			this.txtMail.TabIndex = 20;
			this.txtMail.UseSelectable = true;
			this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblNombre
			// 
			this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombre.Location = new System.Drawing.Point(49, 109);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(180, 19);
			this.lblNombre.TabIndex = 17;
			this.lblNombre.Tag = "name";
			this.lblNombre.Text = "Nombre";
			this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblNombre.WrapToLine = true;
			// 
			// lblApellido
			// 
			this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblApellido.Location = new System.Drawing.Point(49, 138);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(180, 19);
			this.lblApellido.TabIndex = 19;
			this.lblApellido.Tag = "lastname";
			this.lblApellido.Text = "Apellido";
			this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblApellido.WrapToLine = true;
			// 
			// txtApellido
			// 
			this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtApellido.CustomButton.Image = null;
			this.txtApellido.CustomButton.Location = new System.Drawing.Point(180, 1);
			this.txtApellido.CustomButton.Margin = new System.Windows.Forms.Padding(4);
			this.txtApellido.CustomButton.Name = "";
			this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtApellido.CustomButton.TabIndex = 1;
			this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtApellido.CustomButton.UseSelectable = true;
			this.txtApellido.CustomButton.Visible = false;
			this.txtApellido.Lines = new string[0];
			this.txtApellido.Location = new System.Drawing.Point(235, 136);
			this.txtApellido.MaxLength = 32767;
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.PasswordChar = '\0';
			this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtApellido.SelectedText = "";
			this.txtApellido.SelectionLength = 0;
			this.txtApellido.SelectionStart = 0;
			this.txtApellido.ShortcutsEnabled = true;
			this.txtApellido.Size = new System.Drawing.Size(202, 23);
			this.txtApellido.TabIndex = 18;
			this.txtApellido.UseSelectable = true;
			this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblRol
			// 
			this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblRol.Location = new System.Drawing.Point(49, 197);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(180, 19);
			this.lblRol.TabIndex = 27;
			this.lblRol.Tag = "role";
			this.lblRol.Text = "Permiso";
			this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblRol.WrapToLine = true;
			// 
			// cmbRol
			// 
			this.cmbRol.FormattingEnabled = true;
			this.cmbRol.ItemHeight = 23;
			this.cmbRol.Location = new System.Drawing.Point(235, 193);
			this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
			this.cmbRol.Name = "cmbRol";
			this.cmbRol.Size = new System.Drawing.Size(203, 29);
			this.cmbRol.TabIndex = 28;
			this.cmbRol.UseSelectable = true;
			// 
			// lblResponse
			// 
			this.lblResponse.AutoSize = true;
			this.lblResponse.ForeColor = System.Drawing.Color.Black;
			this.lblResponse.Location = new System.Drawing.Point(17, 315);
			this.lblResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(0, 0);
			this.lblResponse.TabIndex = 29;
			this.lblResponse.UseCustomForeColor = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel1.Location = new System.Drawing.Point(49, 231);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(180, 19);
			this.metroLabel1.TabIndex = 30;
			this.metroLabel1.Tag = "";
			this.metroLabel1.Text = "Sector";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroLabel1.WrapToLine = true;
			// 
			// lbPuestos
			// 
			this.lbPuestos.FormattingEnabled = true;
			this.lbPuestos.ItemHeight = 23;
			this.lbPuestos.Location = new System.Drawing.Point(235, 260);
			this.lbPuestos.Margin = new System.Windows.Forms.Padding(2);
			this.lbPuestos.Name = "lbPuestos";
			this.lbPuestos.Size = new System.Drawing.Size(203, 29);
			this.lbPuestos.TabIndex = 33;
			this.lbPuestos.UseSelectable = true;
			// 
			// lblPuesto
			// 
			this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPuesto.Location = new System.Drawing.Point(49, 265);
			this.lblPuesto.Name = "lblPuesto";
			this.lblPuesto.Size = new System.Drawing.Size(180, 19);
			this.lblPuesto.TabIndex = 32;
			this.lblPuesto.Tag = "position";
			this.lblPuesto.Text = "Puesto";
			this.lblPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblPuesto.WrapToLine = true;
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
			this.txtSector.Location = new System.Drawing.Point(236, 229);
			this.txtSector.MaxLength = 32767;
			this.txtSector.Name = "txtSector";
			this.txtSector.PasswordChar = '\0';
			this.txtSector.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtSector.SelectedText = "";
			this.txtSector.SelectionLength = 0;
			this.txtSector.SelectionStart = 0;
			this.txtSector.ShortcutsEnabled = true;
			this.txtSector.Size = new System.Drawing.Size(202, 23);
			this.txtSector.TabIndex = 34;
			this.txtSector.UseSelectable = true;
			this.txtSector.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtSector.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// AgregarUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 366);
			this.Controls.Add(this.txtSector);
			this.Controls.Add(this.lbPuestos);
			this.Controls.Add(this.lblPuesto);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lblResponse);
			this.Controls.Add(this.cmbRol);
			this.Controls.Add(this.lblRol);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblMail);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.txtApellido);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AgregarUsuario";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Tag = "user";
			this.Text = "Usuario";
			this.Load += new System.EventHandler(this.AgregarUsuario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroLabel lblMail;
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroTextBox txtMail;
		private MetroFramework.Controls.MetroLabel lblNombre;
		private MetroFramework.Controls.MetroLabel lblApellido;
		private MetroFramework.Controls.MetroTextBox txtApellido;
		private MetroFramework.Controls.MetroTextBox txtUsername;
		private MetroFramework.Controls.MetroLabel lblUsername;
		private MetroFramework.Controls.MetroLabel lblRol;
		private MetroFramework.Controls.MetroComboBox cmbRol;
		private MetroFramework.Controls.MetroLabel lblResponse;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox lbPuestos;
		private MetroFramework.Controls.MetroLabel lblPuesto;
		private MetroFramework.Controls.MetroTextBox txtSector;
	}
}