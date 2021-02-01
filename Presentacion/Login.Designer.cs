namespace Presentacion {
	partial class Login {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblPassword = new MetroFramework.Controls.MetroLabel();
			this.lblUsername = new MetroFramework.Controls.MetroLabel();
			this.passwordTB = new MetroFramework.Controls.MetroTextBox();
			this.usernameTB = new MetroFramework.Controls.MetroTextBox();
			this.btnLogin = new MetroFramework.Controls.MetroButton();
			this.cmbLanguage = new MetroFramework.Controls.MetroComboBox();
			this.lblLang = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(20, 60);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(0, 67);
			this.pictureBox1.MinimumSize = new System.Drawing.Size(202, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(432, 67);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// lblPassword
			// 
			this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(92, 224);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(75, 19);
			this.lblPassword.TabIndex = 8;
			this.lblPassword.Tag = "password";
			this.lblPassword.Text = "Contraseña";
			// 
			// lblUsername
			// 
			this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(92, 194);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(124, 19);
			this.lblUsername.TabIndex = 8;
			this.lblUsername.Tag = "username";
			this.lblUsername.Text = "Nombre de usuario";
			// 
			// passwordTB
			// 
			this.passwordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.passwordTB.CustomButton.Image = null;
			this.passwordTB.CustomButton.Location = new System.Drawing.Point(113, 1);
			this.passwordTB.CustomButton.Name = "";
			this.passwordTB.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.passwordTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.passwordTB.CustomButton.TabIndex = 1;
			this.passwordTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.passwordTB.CustomButton.UseSelectable = true;
			this.passwordTB.CustomButton.Visible = false;
			this.passwordTB.Lines = new string[0];
			this.passwordTB.Location = new System.Drawing.Point(232, 219);
			this.passwordTB.MaxLength = 32767;
			this.passwordTB.Name = "passwordTB";
			this.passwordTB.PasswordChar = '*';
			this.passwordTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordTB.SelectedText = "";
			this.passwordTB.SelectionLength = 0;
			this.passwordTB.SelectionStart = 0;
			this.passwordTB.ShortcutsEnabled = true;
			this.passwordTB.Size = new System.Drawing.Size(135, 23);
			this.passwordTB.TabIndex = 2;
			this.passwordTB.UseSelectable = true;
			this.passwordTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.passwordTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// usernameTB
			// 
			this.usernameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.usernameTB.CustomButton.Image = null;
			this.usernameTB.CustomButton.Location = new System.Drawing.Point(113, 1);
			this.usernameTB.CustomButton.Name = "";
			this.usernameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.usernameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.usernameTB.CustomButton.TabIndex = 1;
			this.usernameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.usernameTB.CustomButton.UseSelectable = true;
			this.usernameTB.CustomButton.Visible = false;
			this.usernameTB.Lines = new string[0];
			this.usernameTB.Location = new System.Drawing.Point(232, 190);
			this.usernameTB.MaxLength = 32767;
			this.usernameTB.Name = "usernameTB";
			this.usernameTB.PasswordChar = '\0';
			this.usernameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.usernameTB.SelectedText = "";
			this.usernameTB.SelectionLength = 0;
			this.usernameTB.SelectionStart = 0;
			this.usernameTB.ShortcutsEnabled = true;
			this.usernameTB.Size = new System.Drawing.Size(135, 23);
			this.usernameTB.TabIndex = 1;
			this.usernameTB.UseSelectable = true;
			this.usernameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.usernameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.Location = new System.Drawing.Point(266, 270);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(101, 23);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Tag = "login";
			this.btnLogin.Text = "Iniciar sesion";
			this.btnLogin.UseSelectable = true;
			this.btnLogin.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// cmbLanguage
			// 
			this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmbLanguage.FormattingEnabled = true;
			this.cmbLanguage.ItemHeight = 23;
			this.cmbLanguage.Items.AddRange(new object[] {
            "Castellano",
            "English"});
			this.cmbLanguage.Location = new System.Drawing.Point(115, 357);
			this.cmbLanguage.Name = "cmbLanguage";
			this.cmbLanguage.Size = new System.Drawing.Size(147, 29);
			this.cmbLanguage.TabIndex = 10;
			this.cmbLanguage.UseSelectable = true;
			this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
			// 
			// lblLang
			// 
			this.lblLang.AutoSize = true;
			this.lblLang.Location = new System.Drawing.Point(13, 362);
			this.lblLang.Name = "lblLang";
			this.lblLang.Size = new System.Drawing.Size(50, 19);
			this.lblLang.TabIndex = 11;
			this.lblLang.Tag = "language";
			this.lblLang.Text = "Idioma";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 395);
			this.Controls.Add(this.lblLang);
			this.Controls.Add(this.cmbLanguage);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.passwordTB);
			this.Controls.Add(this.usernameTB);
			this.Controls.Add(this.btnLogin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Tag = "login";
			this.Text = "Iniciar sesión";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton btnLogin;
		private MetroFramework.Controls.MetroTextBox usernameTB;
		private MetroFramework.Controls.MetroTextBox passwordTB;
		private MetroFramework.Controls.MetroLabel lblUsername;
		private MetroFramework.Controls.MetroLabel lblPassword;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroComboBox cmbLanguage;
		private MetroFramework.Controls.MetroLabel lblLang;
	}
}

