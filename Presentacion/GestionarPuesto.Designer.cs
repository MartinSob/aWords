namespace Presentacion {
	partial class GestionarPuesto {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPuesto));
			this.txtNombre = new MetroFramework.Controls.MetroTextBox();
			this.lblNombre = new MetroFramework.Controls.MetroLabel();
			this.cmbTipos = new System.Windows.Forms.ComboBox();
			this.btnDelete = new MetroFramework.Controls.MetroButton();
			this.btnEdit = new MetroFramework.Controls.MetroButton();
			this.btnAdd = new MetroFramework.Controls.MetroButton();
			this.addNametxt = new MetroFramework.Controls.MetroTextBox();
			this.addNamelbl = new MetroFramework.Controls.MetroLabel();
			this.gbAdd = new System.Windows.Forms.GroupBox();
			this.addValoraciontxt = new MetroFramework.Controls.MetroTextBox();
			this.addValoracionlbl = new MetroFramework.Controls.MetroLabel();
			this.txtValoracion = new MetroFramework.Controls.MetroTextBox();
			this.lblValoracion = new MetroFramework.Controls.MetroLabel();
			this.gbAdd.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			// 
			// 
			// 
			this.txtNombre.CustomButton.Image = null;
			this.txtNombre.CustomButton.Location = new System.Drawing.Point(94, 1);
			this.txtNombre.CustomButton.Name = "";
			this.txtNombre.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombre.CustomButton.TabIndex = 1;
			this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombre.CustomButton.UseSelectable = true;
			this.txtNombre.CustomButton.Visible = false;
			this.txtNombre.Lines = new string[0];
			this.txtNombre.Location = new System.Drawing.Point(214, 114);
			this.txtNombre.MaxLength = 32767;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.PasswordChar = '\0';
			this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombre.SelectedText = "";
			this.txtNombre.SelectionLength = 0;
			this.txtNombre.SelectionStart = 0;
			this.txtNombre.ShortcutsEnabled = true;
			this.txtNombre.Size = new System.Drawing.Size(211, 23);
			this.txtNombre.TabIndex = 18;
			this.txtNombre.UseSelectable = true;
			this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(40, 114);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(59, 19);
			this.lblNombre.TabIndex = 17;
			this.lblNombre.Tag = "name";
			this.lblNombre.Text = "Nombre";
			// 
			// cmbTipos
			// 
			this.cmbTipos.FormattingEnabled = true;
			this.cmbTipos.Location = new System.Drawing.Point(215, 80);
			this.cmbTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbTipos.Name = "cmbTipos";
			this.cmbTipos.Size = new System.Drawing.Size(211, 21);
			this.cmbTipos.TabIndex = 16;
			this.cmbTipos.SelectedIndexChanged += new System.EventHandler(this.cmbTipos_SelectedIndexChanged);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(369, 184);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(56, 19);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Tag = "delete";
			this.btnDelete.Text = "Borrar";
			this.btnDelete.UseSelectable = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(293, 184);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(56, 19);
			this.btnEdit.TabIndex = 14;
			this.btnEdit.Tag = "edit";
			this.btnEdit.Text = "Editar";
			this.btnEdit.UseSelectable = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(278, 111);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(56, 19);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Tag = "add";
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseSelectable = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// addNametxt
			// 
			// 
			// 
			// 
			this.addNametxt.CustomButton.Image = null;
			this.addNametxt.CustomButton.Location = new System.Drawing.Point(94, 1);
			this.addNametxt.CustomButton.Name = "";
			this.addNametxt.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.addNametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.addNametxt.CustomButton.TabIndex = 1;
			this.addNametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.addNametxt.CustomButton.UseSelectable = true;
			this.addNametxt.CustomButton.Visible = false;
			this.addNametxt.Lines = new string[0];
			this.addNametxt.Location = new System.Drawing.Point(123, 42);
			this.addNametxt.MaxLength = 32767;
			this.addNametxt.Name = "addNametxt";
			this.addNametxt.PasswordChar = '\0';
			this.addNametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.addNametxt.SelectedText = "";
			this.addNametxt.SelectionLength = 0;
			this.addNametxt.SelectionStart = 0;
			this.addNametxt.ShortcutsEnabled = true;
			this.addNametxt.Size = new System.Drawing.Size(211, 23);
			this.addNametxt.TabIndex = 20;
			this.addNametxt.UseSelectable = true;
			this.addNametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.addNametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// addNamelbl
			// 
			this.addNamelbl.AutoSize = true;
			this.addNamelbl.Location = new System.Drawing.Point(30, 46);
			this.addNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.addNamelbl.Name = "addNamelbl";
			this.addNamelbl.Size = new System.Drawing.Size(59, 19);
			this.addNamelbl.TabIndex = 19;
			this.addNamelbl.Tag = "name";
			this.addNamelbl.Text = "Nombre";
			// 
			// gbAdd
			// 
			this.gbAdd.Controls.Add(this.addValoraciontxt);
			this.gbAdd.Controls.Add(this.addValoracionlbl);
			this.gbAdd.Controls.Add(this.addNametxt);
			this.gbAdd.Controls.Add(this.addNamelbl);
			this.gbAdd.Controls.Add(this.btnAdd);
			this.gbAdd.Location = new System.Drawing.Point(40, 232);
			this.gbAdd.Name = "gbAdd";
			this.gbAdd.Size = new System.Drawing.Size(386, 151);
			this.gbAdd.TabIndex = 21;
			this.gbAdd.TabStop = false;
			this.gbAdd.Tag = "add";
			this.gbAdd.Text = "Agregar";
			// 
			// addValoraciontxt
			// 
			// 
			// 
			// 
			this.addValoraciontxt.CustomButton.Image = null;
			this.addValoraciontxt.CustomButton.Location = new System.Drawing.Point(94, 1);
			this.addValoraciontxt.CustomButton.Name = "";
			this.addValoraciontxt.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.addValoraciontxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.addValoraciontxt.CustomButton.TabIndex = 1;
			this.addValoraciontxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.addValoraciontxt.CustomButton.UseSelectable = true;
			this.addValoraciontxt.CustomButton.Visible = false;
			this.addValoraciontxt.Lines = new string[0];
			this.addValoraciontxt.Location = new System.Drawing.Point(123, 71);
			this.addValoraciontxt.MaxLength = 32767;
			this.addValoraciontxt.Name = "addValoraciontxt";
			this.addValoraciontxt.PasswordChar = '\0';
			this.addValoraciontxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.addValoraciontxt.SelectedText = "";
			this.addValoraciontxt.SelectionLength = 0;
			this.addValoraciontxt.SelectionStart = 0;
			this.addValoraciontxt.ShortcutsEnabled = true;
			this.addValoraciontxt.Size = new System.Drawing.Size(211, 23);
			this.addValoraciontxt.TabIndex = 22;
			this.addValoraciontxt.UseSelectable = true;
			this.addValoraciontxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.addValoraciontxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// addValoracionlbl
			// 
			this.addValoracionlbl.AutoSize = true;
			this.addValoracionlbl.Location = new System.Drawing.Point(30, 75);
			this.addValoracionlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.addValoracionlbl.Name = "addValoracionlbl";
			this.addValoracionlbl.Size = new System.Drawing.Size(69, 19);
			this.addValoracionlbl.TabIndex = 21;
			this.addValoracionlbl.Tag = "appreciation";
			this.addValoracionlbl.Text = "Valoracion";
			// 
			// txtValoracion
			// 
			// 
			// 
			// 
			this.txtValoracion.CustomButton.Image = null;
			this.txtValoracion.CustomButton.Location = new System.Drawing.Point(94, 1);
			this.txtValoracion.CustomButton.Name = "";
			this.txtValoracion.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.txtValoracion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtValoracion.CustomButton.TabIndex = 1;
			this.txtValoracion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtValoracion.CustomButton.UseSelectable = true;
			this.txtValoracion.CustomButton.Visible = false;
			this.txtValoracion.Lines = new string[0];
			this.txtValoracion.Location = new System.Drawing.Point(215, 143);
			this.txtValoracion.MaxLength = 32767;
			this.txtValoracion.Name = "txtValoracion";
			this.txtValoracion.PasswordChar = '\0';
			this.txtValoracion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtValoracion.SelectedText = "";
			this.txtValoracion.SelectionLength = 0;
			this.txtValoracion.SelectionStart = 0;
			this.txtValoracion.ShortcutsEnabled = true;
			this.txtValoracion.Size = new System.Drawing.Size(211, 23);
			this.txtValoracion.TabIndex = 23;
			this.txtValoracion.UseSelectable = true;
			this.txtValoracion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtValoracion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblValoracion
			// 
			this.lblValoracion.AutoSize = true;
			this.lblValoracion.Location = new System.Drawing.Point(41, 143);
			this.lblValoracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblValoracion.Name = "lblValoracion";
			this.lblValoracion.Size = new System.Drawing.Size(69, 19);
			this.lblValoracion.TabIndex = 22;
			this.lblValoracion.Tag = "appreciation";
			this.lblValoracion.Text = "Valoracion";
			// 
			// GestionarPuesto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 406);
			this.Controls.Add(this.txtValoracion);
			this.Controls.Add(this.lblValoracion);
			this.Controls.Add(this.gbAdd);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.cmbTipos);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GestionarPuesto";
			this.Tag = "positions";
			this.Text = "Puestos";
			this.Load += new System.EventHandler(this.GestionarTipoSector_Load);
			this.gbAdd.ResumeLayout(false);
			this.gbAdd.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtNombre;
		private MetroFramework.Controls.MetroLabel lblNombre;
		private System.Windows.Forms.ComboBox cmbTipos;
		private MetroFramework.Controls.MetroButton btnDelete;
		private MetroFramework.Controls.MetroButton btnEdit;
		private MetroFramework.Controls.MetroButton btnAdd;
		private MetroFramework.Controls.MetroTextBox addNametxt;
		private MetroFramework.Controls.MetroLabel addNamelbl;
		private System.Windows.Forms.GroupBox gbAdd;
		private MetroFramework.Controls.MetroTextBox addValoraciontxt;
		private MetroFramework.Controls.MetroLabel addValoracionlbl;
		private MetroFramework.Controls.MetroTextBox txtValoracion;
		private MetroFramework.Controls.MetroLabel lblValoracion;
	}
}