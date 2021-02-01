namespace Presentacion {
	partial class GestionarSector {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarSector));
			this.btnSugerirEquipo = new MetroFramework.Controls.MetroButton();
			this.txtBoss = new MetroFramework.Controls.MetroTextBox();
			this.btnSave = new MetroFramework.Controls.MetroButton();
			this.txtNivel = new MetroFramework.Controls.MetroTextBox();
			this.lblLevel = new MetroFramework.Controls.MetroLabel();
			this.btnVerPerfil = new MetroFramework.Controls.MetroButton();
			this.btnAddPosition = new MetroFramework.Controls.MetroButton();
			this.btnDeletePosition = new MetroFramework.Controls.MetroButton();
			this.btnAddEmployee = new MetroFramework.Controls.MetroButton();
			this.btnBorrarJefe = new MetroFramework.Controls.MetroButton();
			this.btnSugerir = new MetroFramework.Controls.MetroButton();
			this.lblBoss = new MetroFramework.Controls.MetroLabel();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.lblNombre = new MetroFramework.Controls.MetroLabel();
			this.lblPositions = new System.Windows.Forms.GroupBox();
			this.dgPuestos = new System.Windows.Forms.DataGridView();
			this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblPositions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgPuestos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSugerirEquipo
			// 
			this.btnSugerirEquipo.Location = new System.Drawing.Point(26, 161);
			this.btnSugerirEquipo.Margin = new System.Windows.Forms.Padding(2);
			this.btnSugerirEquipo.Name = "btnSugerirEquipo";
			this.btnSugerirEquipo.Size = new System.Drawing.Size(436, 29);
			this.btnSugerirEquipo.TabIndex = 36;
			this.btnSugerirEquipo.Tag = "suggest";
			this.btnSugerirEquipo.Text = "Sugerir";
			this.btnSugerirEquipo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnSugerirEquipo.UseSelectable = true;
			this.btnSugerirEquipo.Click += new System.EventHandler(this.btnSugerirEquipo_Click);
			// 
			// txtBoss
			// 
			// 
			// 
			// 
			this.txtBoss.CustomButton.Image = null;
			this.txtBoss.CustomButton.Location = new System.Drawing.Point(196, 1);
			this.txtBoss.CustomButton.Name = "";
			this.txtBoss.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtBoss.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtBoss.CustomButton.TabIndex = 1;
			this.txtBoss.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtBoss.CustomButton.UseSelectable = true;
			this.txtBoss.CustomButton.Visible = false;
			this.txtBoss.Enabled = false;
			this.txtBoss.Lines = new string[0];
			this.txtBoss.Location = new System.Drawing.Point(116, 438);
			this.txtBoss.MaxLength = 32767;
			this.txtBoss.Name = "txtBoss";
			this.txtBoss.PasswordChar = '\0';
			this.txtBoss.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtBoss.SelectedText = "";
			this.txtBoss.SelectionLength = 0;
			this.txtBoss.SelectionStart = 0;
			this.txtBoss.ShortcutsEnabled = true;
			this.txtBoss.Size = new System.Drawing.Size(218, 23);
			this.txtBoss.TabIndex = 35;
			this.txtBoss.UseSelectable = true;
			this.txtBoss.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtBoss.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(26, 500);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(65, 19);
			this.btnSave.TabIndex = 34;
			this.btnSave.Tag = "";
			this.btnSave.Text = "✔";
			this.btnSave.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnSave.UseSelectable = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNivel
			// 
			// 
			// 
			// 
			this.txtNivel.CustomButton.Image = null;
			this.txtNivel.CustomButton.Location = new System.Drawing.Point(324, 1);
			this.txtNivel.CustomButton.Name = "";
			this.txtNivel.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNivel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNivel.CustomButton.TabIndex = 1;
			this.txtNivel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNivel.CustomButton.UseSelectable = true;
			this.txtNivel.CustomButton.Visible = false;
			this.txtNivel.Lines = new string[0];
			this.txtNivel.Location = new System.Drawing.Point(116, 120);
			this.txtNivel.MaxLength = 32767;
			this.txtNivel.Name = "txtNivel";
			this.txtNivel.PasswordChar = '\0';
			this.txtNivel.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNivel.SelectedText = "";
			this.txtNivel.SelectionLength = 0;
			this.txtNivel.SelectionStart = 0;
			this.txtNivel.ShortcutsEnabled = true;
			this.txtNivel.Size = new System.Drawing.Size(346, 23);
			this.txtNivel.TabIndex = 33;
			this.txtNivel.UseSelectable = true;
			this.txtNivel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNivel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.Location = new System.Drawing.Point(27, 120);
			this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(38, 19);
			this.lblLevel.TabIndex = 32;
			this.lblLevel.Tag = "level";
			this.lblLevel.Text = "Nivel";
			// 
			// btnVerPerfil
			// 
			this.btnVerPerfil.Location = new System.Drawing.Point(311, 387);
			this.btnVerPerfil.Margin = new System.Windows.Forms.Padding(2);
			this.btnVerPerfil.Name = "btnVerPerfil";
			this.btnVerPerfil.Size = new System.Drawing.Size(151, 29);
			this.btnVerPerfil.TabIndex = 31;
			this.btnVerPerfil.Tag = "see_profile";
			this.btnVerPerfil.Text = "Ver perfil";
			this.btnVerPerfil.UseSelectable = true;
			this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
			// 
			// btnAddPosition
			// 
			this.btnAddPosition.Location = new System.Drawing.Point(35, 59);
			this.btnAddPosition.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddPosition.Name = "btnAddPosition";
			this.btnAddPosition.Size = new System.Drawing.Size(84, 23);
			this.btnAddPosition.TabIndex = 30;
			this.btnAddPosition.Tag = "add";
			this.btnAddPosition.Text = "Agregar";
			this.btnAddPosition.UseSelectable = true;
			this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
			// 
			// btnDeletePosition
			// 
			this.btnDeletePosition.Location = new System.Drawing.Point(311, 350);
			this.btnDeletePosition.Margin = new System.Windows.Forms.Padding(2);
			this.btnDeletePosition.Name = "btnDeletePosition";
			this.btnDeletePosition.Size = new System.Drawing.Size(151, 29);
			this.btnDeletePosition.TabIndex = 29;
			this.btnDeletePosition.Tag = "delete";
			this.btnDeletePosition.Text = "Eliminar";
			this.btnDeletePosition.UseSelectable = true;
			this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.Location = new System.Drawing.Point(311, 313);
			this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(151, 29);
			this.btnAddEmployee.TabIndex = 26;
			this.btnAddEmployee.Tag = "add";
			this.btnAddEmployee.Text = "Agregar empleado";
			this.btnAddEmployee.UseSelectable = true;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// btnBorrarJefe
			// 
			this.btnBorrarJefe.Location = new System.Drawing.Point(346, 438);
			this.btnBorrarJefe.Name = "btnBorrarJefe";
			this.btnBorrarJefe.Size = new System.Drawing.Size(26, 23);
			this.btnBorrarJefe.TabIndex = 25;
			this.btnBorrarJefe.Text = "X";
			this.btnBorrarJefe.UseSelectable = true;
			this.btnBorrarJefe.Click += new System.EventHandler(this.btnBorrarJefe_Click);
			// 
			// btnSugerir
			// 
			this.btnSugerir.Location = new System.Drawing.Point(378, 438);
			this.btnSugerir.Name = "btnSugerir";
			this.btnSugerir.Size = new System.Drawing.Size(84, 23);
			this.btnSugerir.TabIndex = 23;
			this.btnSugerir.Tag = "suggest";
			this.btnSugerir.Text = "Sugerir";
			this.btnSugerir.UseSelectable = true;
			this.btnSugerir.Click += new System.EventHandler(this.btnSugerir_Click);
			// 
			// lblBoss
			// 
			this.lblBoss.AutoSize = true;
			this.lblBoss.Location = new System.Drawing.Point(26, 442);
			this.lblBoss.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblBoss.Name = "lblBoss";
			this.lblBoss.Size = new System.Drawing.Size(32, 19);
			this.lblBoss.TabIndex = 22;
			this.lblBoss.Tag = "boss";
			this.lblBoss.Text = "Jefe";
			// 
			// cbType
			// 
			this.cbType.FormattingEnabled = true;
			this.cbType.Location = new System.Drawing.Point(8, 23);
			this.cbType.Margin = new System.Windows.Forms.Padding(2);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(132, 21);
			this.cbType.TabIndex = 19;
			// 
			// txtNombre
			// 
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(324, 1);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(116, 70);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(346, 23);
			this.txtNombre.TabIndex = 18;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(26, 75);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(59, 19);
			this.lblNombre.TabIndex = 17;
			this.lblNombre.Tag = "name";
			this.lblNombre.Text = "Nombre";
			// 
			// lblPositions
			// 
			this.lblPositions.Controls.Add(this.cbType);
			this.lblPositions.Controls.Add(this.btnAddPosition);
			this.lblPositions.Location = new System.Drawing.Point(311, 206);
			this.lblPositions.Margin = new System.Windows.Forms.Padding(2);
			this.lblPositions.Name = "lblPositions";
			this.lblPositions.Padding = new System.Windows.Forms.Padding(2);
			this.lblPositions.Size = new System.Drawing.Size(151, 96);
			this.lblPositions.TabIndex = 37;
			this.lblPositions.TabStop = false;
			this.lblPositions.Tag = "positions";
			this.lblPositions.Text = "Puestos";
			// 
			// dgPuestos
			// 
			this.dgPuestos.AllowUserToAddRows = false;
			this.dgPuestos.AllowUserToDeleteRows = false;
			this.dgPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgPuestos.BackgroundColor = System.Drawing.Color.White;
			this.dgPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPuestos.ColumnHeadersVisible = false;
			this.dgPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.puesto,
            this.usuario});
			this.dgPuestos.Location = new System.Drawing.Point(26, 206);
			this.dgPuestos.Margin = new System.Windows.Forms.Padding(2);
			this.dgPuestos.MultiSelect = false;
			this.dgPuestos.Name = "dgPuestos";
			this.dgPuestos.ReadOnly = true;
			this.dgPuestos.RowHeadersVisible = false;
			this.dgPuestos.RowHeadersWidth = 82;
			this.dgPuestos.RowTemplate.Height = 33;
			this.dgPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPuestos.Size = new System.Drawing.Size(276, 210);
			this.dgPuestos.TabIndex = 38;
			// 
			// puesto
			// 
			this.puesto.FillWeight = 130.7692F;
			this.puesto.HeaderText = "puesto";
			this.puesto.MinimumWidth = 10;
			this.puesto.Name = "puesto";
			this.puesto.ReadOnly = true;
			// 
			// usuario
			// 
			this.usuario.FillWeight = 130.7692F;
			this.usuario.HeaderText = "usuario";
			this.usuario.MinimumWidth = 10;
			this.usuario.Name = "usuario";
			this.usuario.ReadOnly = true;
			// 
			// GestionarSector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(494, 539);
			this.Controls.Add(this.dgPuestos);
			this.Controls.Add(this.lblPositions);
			this.Controls.Add(this.btnSugerirEquipo);
			this.Controls.Add(this.txtBoss);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtNivel);
			this.Controls.Add(this.lblLevel);
			this.Controls.Add(this.btnVerPerfil);
			this.Controls.Add(this.btnDeletePosition);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.btnBorrarJefe);
			this.Controls.Add(this.btnSugerir);
			this.Controls.Add(this.lblBoss);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GestionarSector";
			this.Tag = "sectors";
			this.Text = "Sectores";
			this.Load += new System.EventHandler(this.GestionarSector_Load);
			this.lblPositions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgPuestos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroLabel lblNombre;
		private System.Windows.Forms.ComboBox cbType;
		private MetroFramework.Controls.MetroLabel lblBoss;
		private MetroFramework.Controls.MetroButton btnSugerir;
		private MetroFramework.Controls.MetroButton btnBorrarJefe;
		private MetroFramework.Controls.MetroButton btnAddEmployee;
		private MetroFramework.Controls.MetroButton btnDeletePosition;
		private MetroFramework.Controls.MetroButton btnAddPosition;
		private MetroFramework.Controls.MetroButton btnVerPerfil;
		private MetroFramework.Controls.MetroTextBox txtNivel;
		private MetroFramework.Controls.MetroLabel lblLevel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtBoss;
        private MetroFramework.Controls.MetroButton btnSugerirEquipo;
        private System.Windows.Forms.GroupBox lblPositions;
        private System.Windows.Forms.DataGridView dgPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}