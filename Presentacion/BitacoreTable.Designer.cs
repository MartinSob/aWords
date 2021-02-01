namespace Presentacion {
	partial class BitacoreTable {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitacoreTable));
			this.gridBitacora = new MetroFramework.Controls.MetroGrid();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFiltrar = new MetroFramework.Controls.MetroButton();
			this.txtTipo = new MetroFramework.Controls.MetroTextBox();
			this.lblTipo = new MetroFramework.Controls.MetroLabel();
			this.dateFrom = new MetroFramework.Controls.MetroDateTime();
			this.dateTo = new MetroFramework.Controls.MetroDateTime();
			this.lblHyphen = new MetroFramework.Controls.MetroLabel();
			this.messageDetail = new System.Windows.Forms.WebBrowser();
			((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).BeginInit();
			this.SuspendLayout();
			// 
			// gridBitacora
			// 
			this.gridBitacora.AllowUserToAddRows = false;
			this.gridBitacora.AllowUserToDeleteRows = false;
			this.gridBitacora.AllowUserToResizeRows = false;
			this.gridBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridBitacora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridBitacora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridBitacora.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridBitacora.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fecha,
            this.titulo,
            this.descripcion,
            this.tipo,
            this.NombreUsuario});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridBitacora.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridBitacora.EnableHeadersVisualStyles = false;
			this.gridBitacora.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridBitacora.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridBitacora.Location = new System.Drawing.Point(23, 120);
			this.gridBitacora.Name = "gridBitacora";
			this.gridBitacora.ReadOnly = true;
			this.gridBitacora.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridBitacora.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridBitacora.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridBitacora.Size = new System.Drawing.Size(661, 341);
			this.gridBitacora.TabIndex = 0;
			this.gridBitacora.SelectionChanged += new System.EventHandler(this.gridBitacora_SelectionChanged);
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			// 
			// titulo
			// 
			this.titulo.HeaderText = "Titulo";
			this.titulo.Name = "titulo";
			this.titulo.ReadOnly = true;
			// 
			// descripcion
			// 
			this.descripcion.HeaderText = "Descripcion";
			this.descripcion.Name = "descripcion";
			this.descripcion.ReadOnly = true;
			// 
			// tipo
			// 
			this.tipo.HeaderText = "Tipo";
			this.tipo.Name = "tipo";
			this.tipo.ReadOnly = true;
			// 
			// NombreUsuario
			// 
			this.NombreUsuario.HeaderText = "NombreUsuario";
			this.NombreUsuario.Name = "NombreUsuario";
			this.NombreUsuario.ReadOnly = true;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.Location = new System.Drawing.Point(609, 84);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
			this.btnFiltrar.TabIndex = 1;
			this.btnFiltrar.Tag = "filter";
			this.btnFiltrar.Text = "Filtrar";
			this.btnFiltrar.UseSelectable = true;
			this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
			// 
			// txtTipo
			// 
			// 
			// 
			// 
			this.txtTipo.CustomButton.Image = null;
			this.txtTipo.CustomButton.Location = new System.Drawing.Point(91, 1);
			this.txtTipo.CustomButton.Name = "";
			this.txtTipo.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.txtTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtTipo.CustomButton.TabIndex = 1;
			this.txtTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtTipo.CustomButton.UseSelectable = true;
			this.txtTipo.CustomButton.Visible = false;
			this.txtTipo.Lines = new string[0];
			this.txtTipo.Location = new System.Drawing.Point(490, 84);
			this.txtTipo.MaxLength = 32767;
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.PasswordChar = '\0';
			this.txtTipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtTipo.SelectedText = "";
			this.txtTipo.SelectionLength = 0;
			this.txtTipo.SelectionStart = 0;
			this.txtTipo.ShortcutsEnabled = true;
			this.txtTipo.Size = new System.Drawing.Size(113, 23);
			this.txtTipo.TabIndex = 2;
			this.txtTipo.UseSelectable = true;
			this.txtTipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtTipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(439, 88);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(35, 19);
			this.lblTipo.TabIndex = 3;
			this.lblTipo.Tag = "type";
			this.lblTipo.Text = "Tipo";
			// 
			// dateFrom
			// 
			this.dateFrom.Location = new System.Drawing.Point(23, 80);
			this.dateFrom.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(179, 29);
			this.dateFrom.TabIndex = 4;
			// 
			// dateTo
			// 
			this.dateTo.Location = new System.Drawing.Point(229, 80);
			this.dateTo.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(179, 29);
			this.dateTo.TabIndex = 5;
			// 
			// lblHyphen
			// 
			this.lblHyphen.AutoSize = true;
			this.lblHyphen.Location = new System.Drawing.Point(208, 84);
			this.lblHyphen.Name = "lblHyphen";
			this.lblHyphen.Size = new System.Drawing.Size(15, 19);
			this.lblHyphen.TabIndex = 6;
			this.lblHyphen.Text = "-";
			// 
			// messageDetail
			// 
			this.messageDetail.Location = new System.Drawing.Point(690, 120);
			this.messageDetail.MinimumSize = new System.Drawing.Size(20, 20);
			this.messageDetail.Name = "messageDetail";
			this.messageDetail.Size = new System.Drawing.Size(319, 341);
			this.messageDetail.TabIndex = 7;
			// 
			// BitacoreTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1032, 475);
			this.Controls.Add(this.messageDetail);
			this.Controls.Add(this.lblHyphen);
			this.Controls.Add(this.dateTo);
			this.Controls.Add(this.dateFrom);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.txtTipo);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.gridBitacora);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BitacoreTable";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Tag = "bitacore";
			this.Text = "Bitácora";
			this.Load += new System.EventHandler(this.BitacoreTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridBitacora)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroGrid gridBitacora;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
		private MetroFramework.Controls.MetroButton btnFiltrar;
		private MetroFramework.Controls.MetroTextBox txtTipo;
		private MetroFramework.Controls.MetroLabel lblTipo;
		private MetroFramework.Controls.MetroDateTime dateFrom;
		private MetroFramework.Controls.MetroDateTime dateTo;
		private MetroFramework.Controls.MetroLabel lblHyphen;
		private System.Windows.Forms.WebBrowser messageDetail;
	}
}