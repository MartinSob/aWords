namespace Presentacion {
	partial class ProponerEmpleado {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProponerEmpleado));
			this.btnSearch = new MetroFramework.Controls.MetroButton();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.btnProfile = new MetroFramework.Controls.MetroButton();
			this.btnSelect = new MetroFramework.Controls.MetroButton();
			this.btnSelectProp = new MetroFramework.Controls.MetroButton();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.dgvProposed = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.promedioReconocimientosDeSuperiores = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.porcentajeObjetivosCumplidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.promedioDeNivelObjetivosCumplidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadObjetivosNoCumplidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.promedioNivelReconocimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadReconocimientos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emblemasRecibidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbPuestoFijo = new System.Windows.Forms.CheckBox();
			this.updateRec = new MetroFramework.Controls.MetroButton();
			this.useEmblem = new System.Windows.Forms.CheckBox();
			this.cmbEmblema = new System.Windows.Forms.ComboBox();
			this.iid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProposed)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(778, 310);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(34, 24);
			this.btnSearch.TabIndex = 10;
			this.btnSearch.Tag = "";
			this.btnSearch.Text = "🔎";
			this.btnSearch.UseSelectable = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtNombre
			// 
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
			this.txtNombre.Location = new System.Drawing.Point(618, 281);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(194, 23);
			this.txtNombre.TabIndex = 9;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnProfile
			// 
			this.btnProfile.Location = new System.Drawing.Point(698, 378);
			this.btnProfile.Name = "btnProfile";
			this.btnProfile.Size = new System.Drawing.Size(114, 23);
			this.btnProfile.TabIndex = 8;
			this.btnProfile.Tag = "see_profile";
			this.btnProfile.Text = "Ver perfil";
			this.btnProfile.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnProfile.UseSelectable = true;
			this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(698, 407);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(114, 24);
			this.btnSelect.TabIndex = 14;
			this.btnSelect.Tag = "select";
			this.btnSelect.Text = "Seleccionar";
			this.btnSelect.UseSelectable = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnSelectProp
			// 
			this.btnSelectProp.Location = new System.Drawing.Point(685, 75);
			this.btnSelectProp.Name = "btnSelectProp";
			this.btnSelectProp.Size = new System.Drawing.Size(134, 24);
			this.btnSelectProp.TabIndex = 15;
			this.btnSelectProp.Tag = "select";
			this.btnSelectProp.Text = "Seleccionar";
			this.btnSelectProp.UseSelectable = true;
			this.btnSelectProp.Click += new System.EventHandler(this.btnSelectProp_Click);
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
            this.iid,
            this.Nombre});
			this.dgvUsers.Location = new System.Drawing.Point(26, 281);
			this.dgvUsers.MultiSelect = false;
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RowHeadersWidth = 82;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(573, 160);
			this.dgvUsers.TabIndex = 16;
			// 
			// dgvProposed
			// 
			this.dgvProposed.AllowUserToAddRows = false;
			this.dgvProposed.AllowUserToDeleteRows = false;
			this.dgvProposed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvProposed.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProposed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProposed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProposed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.empleado,
            this.posicion,
            this.valor,
            this.promedioReconocimientosDeSuperiores,
            this.porcentajeObjetivosCumplidos,
            this.promedioDeNivelObjetivosCumplidos,
            this.cantidadObjetivosNoCumplidos,
            this.promedioNivelReconocimiento,
            this.cantidadReconocimientos,
            this.emblemasRecibidos});
			this.dgvProposed.GridColor = System.Drawing.Color.WhiteSmoke;
			this.dgvProposed.Location = new System.Drawing.Point(26, 75);
			this.dgvProposed.Margin = new System.Windows.Forms.Padding(2);
			this.dgvProposed.MultiSelect = false;
			this.dgvProposed.Name = "dgvProposed";
			this.dgvProposed.ReadOnly = true;
			this.dgvProposed.RowHeadersVisible = false;
			this.dgvProposed.RowHeadersWidth = 82;
			this.dgvProposed.RowTemplate.Height = 33;
			this.dgvProposed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProposed.Size = new System.Drawing.Size(654, 201);
			this.dgvProposed.TabIndex = 17;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 10;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			this.id.Width = 21;
			// 
			// empleado
			// 
			this.empleado.HeaderText = "Empleado";
			this.empleado.MinimumWidth = 10;
			this.empleado.Name = "empleado";
			this.empleado.ReadOnly = true;
			this.empleado.Width = 79;
			// 
			// posicion
			// 
			this.posicion.HeaderText = "Puesto";
			this.posicion.Name = "posicion";
			this.posicion.ReadOnly = true;
			this.posicion.Width = 65;
			// 
			// valor
			// 
			this.valor.HeaderText = "Valor";
			this.valor.MinimumWidth = 10;
			this.valor.Name = "valor";
			this.valor.ReadOnly = true;
			this.valor.Width = 56;
			// 
			// promedioReconocimientosDeSuperiores
			// 
			this.promedioReconocimientosDeSuperiores.HeaderText = "Promedio reconocimientos de superiores";
			this.promedioReconocimientosDeSuperiores.MinimumWidth = 10;
			this.promedioReconocimientosDeSuperiores.Name = "promedioReconocimientosDeSuperiores";
			this.promedioReconocimientosDeSuperiores.ReadOnly = true;
			this.promedioReconocimientosDeSuperiores.Width = 159;
			// 
			// porcentajeObjetivosCumplidos
			// 
			this.porcentajeObjetivosCumplidos.HeaderText = "Porcentaje objetivos cumplidos";
			this.porcentajeObjetivosCumplidos.MinimumWidth = 10;
			this.porcentajeObjetivosCumplidos.Name = "porcentajeObjetivosCumplidos";
			this.porcentajeObjetivosCumplidos.ReadOnly = true;
			this.porcentajeObjetivosCumplidos.Width = 162;
			// 
			// promedioDeNivelObjetivosCumplidos
			// 
			this.promedioDeNivelObjetivosCumplidos.HeaderText = "Promedio nivel objetivos cumplidos";
			this.promedioDeNivelObjetivosCumplidos.MinimumWidth = 10;
			this.promedioDeNivelObjetivosCumplidos.Name = "promedioDeNivelObjetivosCumplidos";
			this.promedioDeNivelObjetivosCumplidos.ReadOnly = true;
			this.promedioDeNivelObjetivosCumplidos.Width = 136;
			// 
			// cantidadObjetivosNoCumplidos
			// 
			this.cantidadObjetivosNoCumplidos.HeaderText = "Cantidad objetivos no cumplidos";
			this.cantidadObjetivosNoCumplidos.MinimumWidth = 10;
			this.cantidadObjetivosNoCumplidos.Name = "cantidadObjetivosNoCumplidos";
			this.cantidadObjetivosNoCumplidos.ReadOnly = true;
			this.cantidadObjetivosNoCumplidos.Width = 125;
			// 
			// promedioNivelReconocimiento
			// 
			this.promedioNivelReconocimiento.HeaderText = "Promedio nivel reconocimiento";
			this.promedioNivelReconocimiento.MinimumWidth = 10;
			this.promedioNivelReconocimiento.Name = "promedioNivelReconocimiento";
			this.promedioNivelReconocimiento.ReadOnly = true;
			this.promedioNivelReconocimiento.Width = 160;
			// 
			// cantidadReconocimientos
			// 
			this.cantidadReconocimientos.HeaderText = "Cantidad reconocimientos";
			this.cantidadReconocimientos.MinimumWidth = 10;
			this.cantidadReconocimientos.Name = "cantidadReconocimientos";
			this.cantidadReconocimientos.ReadOnly = true;
			this.cantidadReconocimientos.Width = 141;
			// 
			// emblemasRecibidos
			// 
			this.emblemasRecibidos.HeaderText = "Emblemas recibidos";
			this.emblemasRecibidos.MinimumWidth = 10;
			this.emblemasRecibidos.Name = "emblemasRecibidos";
			this.emblemasRecibidos.ReadOnly = true;
			this.emblemasRecibidos.Width = 114;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPuestoFijo);
			this.groupBox1.Controls.Add(this.updateRec);
			this.groupBox1.Controls.Add(this.useEmblem);
			this.groupBox1.Controls.Add(this.cmbEmblema);
			this.groupBox1.Location = new System.Drawing.Point(685, 105);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(134, 126);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "emblem";
			this.groupBox1.Text = "Emblema";
			// 
			// cbPuestoFijo
			// 
			this.cbPuestoFijo.AutoSize = true;
			this.cbPuestoFijo.Checked = true;
			this.cbPuestoFijo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbPuestoFijo.Location = new System.Drawing.Point(6, 58);
			this.cbPuestoFijo.Name = "cbPuestoFijo";
			this.cbPuestoFijo.Size = new System.Drawing.Size(86, 17);
			this.cbPuestoFijo.TabIndex = 19;
			this.cbPuestoFijo.Text = "Filtrar puesto";
			this.cbPuestoFijo.UseVisualStyleBackColor = true;
			// 
			// updateRec
			// 
			this.updateRec.Location = new System.Drawing.Point(14, 89);
			this.updateRec.Name = "updateRec";
			this.updateRec.Size = new System.Drawing.Size(102, 24);
			this.updateRec.TabIndex = 19;
			this.updateRec.Tag = "update";
			this.updateRec.Text = "Actualizar";
			this.updateRec.UseSelectable = true;
			this.updateRec.Click += new System.EventHandler(this.updateRec_Click);
			// 
			// useEmblem
			// 
			this.useEmblem.AutoSize = true;
			this.useEmblem.Location = new System.Drawing.Point(6, 29);
			this.useEmblem.Name = "useEmblem";
			this.useEmblem.Size = new System.Drawing.Size(15, 14);
			this.useEmblem.TabIndex = 1;
			this.useEmblem.UseVisualStyleBackColor = true;
			// 
			// cmbEmblema
			// 
			this.cmbEmblema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEmblema.FormattingEnabled = true;
			this.cmbEmblema.Location = new System.Drawing.Point(25, 25);
			this.cmbEmblema.Name = "cmbEmblema";
			this.cmbEmblema.Size = new System.Drawing.Size(102, 21);
			this.cmbEmblema.TabIndex = 0;
			// 
			// iid
			// 
			this.iid.HeaderText = "id";
			this.iid.MinimumWidth = 10;
			this.iid.Name = "iid";
			this.iid.ReadOnly = true;
			this.iid.Visible = false;
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.MinimumWidth = 10;
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// ProponerEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(842, 465);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvProposed);
			this.Controls.Add(this.dgvUsers);
			this.Controls.Add(this.btnSelectProp);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnProfile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProponerEmpleado";
			this.Tag = "suggest";
			this.Text = "Proponer";
			this.Load += new System.EventHandler(this.ProponerEmpleado_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProposed)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MetroFramework.Controls.MetroButton btnSearch;
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroButton btnProfile;
		private MetroFramework.Controls.MetroButton btnSelect;
		private MetroFramework.Controls.MetroButton btnSelectProp;
        private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.DataGridView dgvProposed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbEmblema;
		private System.Windows.Forms.CheckBox useEmblem;
		private MetroFramework.Controls.MetroButton updateRec;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
		private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
		private System.Windows.Forms.DataGridViewTextBoxColumn valor;
		private System.Windows.Forms.DataGridViewTextBoxColumn promedioReconocimientosDeSuperiores;
		private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeObjetivosCumplidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn promedioDeNivelObjetivosCumplidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadObjetivosNoCumplidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn promedioNivelReconocimiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadReconocimientos;
		private System.Windows.Forms.DataGridViewTextBoxColumn emblemasRecibidos;
		private System.Windows.Forms.CheckBox cbPuestoFijo;
		private System.Windows.Forms.DataGridViewTextBoxColumn iid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
	}
}