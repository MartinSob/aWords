namespace Presentacion {
	partial class AgregarFamilia {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFamilia));
			this.lblPatentes = new MetroFramework.Controls.MetroLabel();
			this.gridPatentes = new MetroFramework.Controls.MetroGrid();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hasPatent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNombre = new MetroFramework.Controls.MetroLabel();
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.btnSave = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.gridPatentes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPatentes
			// 
			this.lblPatentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPatentes.AutoSize = true;
			this.lblPatentes.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblPatentes.Location = new System.Drawing.Point(23, 156);
			this.lblPatentes.Name = "lblPatentes";
			this.lblPatentes.Size = new System.Drawing.Size(75, 25);
			this.lblPatentes.TabIndex = 10;
			this.lblPatentes.Tag = "patents";
			this.lblPatentes.Text = "Patentes";
			// 
			// gridPatentes
			// 
			this.gridPatentes.AllowUserToAddRows = false;
			this.gridPatentes.AllowUserToResizeRows = false;
			this.gridPatentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridPatentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridPatentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gridPatentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.gridPatentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridPatentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPatentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hasPatent,
            this.name});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gridPatentes.DefaultCellStyle = dataGridViewCellStyle2;
			this.gridPatentes.EnableHeadersVisualStyles = false;
			this.gridPatentes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.gridPatentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridPatentes.Location = new System.Drawing.Point(22, 183);
			this.gridPatentes.Margin = new System.Windows.Forms.Padding(2);
			this.gridPatentes.MultiSelect = false;
			this.gridPatentes.Name = "gridPatentes";
			this.gridPatentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridPatentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridPatentes.RowHeadersWidth = 82;
			this.gridPatentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridPatentes.RowTemplate.Height = 24;
			this.gridPatentes.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.gridPatentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridPatentes.Size = new System.Drawing.Size(428, 162);
			this.gridPatentes.TabIndex = 5;
			// 
			// id
			// 
			this.id.FillWeight = 90.63071F;
			this.id.HeaderText = "";
			this.id.MinimumWidth = 10;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			this.id.Width = 30;
			// 
			// hasPatent
			// 
			this.hasPatent.FillWeight = 76.14214F;
			this.hasPatent.HeaderText = "";
			this.hasPatent.MinimumWidth = 10;
			this.hasPatent.Name = "hasPatent";
			this.hasPatent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.hasPatent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.hasPatent.Width = 30;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.FillWeight = 133.2271F;
			this.name.HeaderText = "";
			this.name.MinimumWidth = 10;
			this.name.Name = "name";
			this.name.ReadOnly = true;
			// 
			// lblNombre
			// 
			this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(146, 82);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(59, 19);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Tag = "name";
			this.lblNombre.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(110, 1);
			this.txtNombre.CustomButton.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(17, 17);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(215, 80);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(128, 19);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Location = new System.Drawing.Point(383, 352);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(68, 19);
			this.btnSave.TabIndex = 0;
			this.btnSave.Tag = "";
			this.btnSave.Text = "✔";
			this.btnSave.UseSelectable = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// AgregarFamilia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 396);
			this.Controls.Add(this.lblPatentes);
			this.Controls.Add(this.gridPatentes);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.btnSave);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AgregarFamilia";
			this.Tag = "manage_family";
			this.Text = "Gestionar familia";
			this.Load += new System.EventHandler(this.AgregarFamilia_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPatentes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnSave;
		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroLabel lblNombre;
		private MetroFramework.Controls.MetroGrid gridPatentes;
		private MetroFramework.Controls.MetroLabel lblPatentes;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewCheckBoxColumn hasPatent;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
	}
}