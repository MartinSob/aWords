namespace Presentacion {
	partial class GestionarFamilia {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarFamilia));
			this.btnEditFamily = new MetroFramework.Controls.MetroButton();
			this.btnDeleteFamily = new MetroFramework.Controls.MetroButton();
			this.cmbFamilias = new MetroFramework.Controls.MetroComboBox();
			this.btnAddFamily = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// btnEditFamily
			// 
			this.btnEditFamily.Location = new System.Drawing.Point(149, 129);
			this.btnEditFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEditFamily.Name = "btnEditFamily";
			this.btnEditFamily.Size = new System.Drawing.Size(71, 23);
			this.btnEditFamily.TabIndex = 11;
			this.btnEditFamily.Tag = "edit";
			this.btnEditFamily.Text = "Editar";
			this.btnEditFamily.UseSelectable = true;
			this.btnEditFamily.Click += new System.EventHandler(this.btnEditFamily_Click);
			// 
			// btnDeleteFamily
			// 
			this.btnDeleteFamily.Location = new System.Drawing.Point(235, 129);
			this.btnDeleteFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDeleteFamily.Name = "btnDeleteFamily";
			this.btnDeleteFamily.Size = new System.Drawing.Size(71, 23);
			this.btnDeleteFamily.TabIndex = 12;
			this.btnDeleteFamily.Tag = "delete";
			this.btnDeleteFamily.Text = "Borrar";
			this.btnDeleteFamily.UseSelectable = true;
			this.btnDeleteFamily.Click += new System.EventHandler(this.btnDeleteFamily_Click);
			// 
			// cmbFamilias
			// 
			this.cmbFamilias.FormattingEnabled = true;
			this.cmbFamilias.ItemHeight = 23;
			this.cmbFamilias.Location = new System.Drawing.Point(62, 86);
			this.cmbFamilias.Name = "cmbFamilias";
			this.cmbFamilias.Size = new System.Drawing.Size(244, 29);
			this.cmbFamilias.TabIndex = 9;
			this.cmbFamilias.UseSelectable = true;
			// 
			// btnAddFamily
			// 
			this.btnAddFamily.Location = new System.Drawing.Point(62, 129);
			this.btnAddFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddFamily.Name = "btnAddFamily";
			this.btnAddFamily.Size = new System.Drawing.Size(71, 23);
			this.btnAddFamily.TabIndex = 10;
			this.btnAddFamily.Tag = "add";
			this.btnAddFamily.Text = "Agregar";
			this.btnAddFamily.UseSelectable = true;
			this.btnAddFamily.Click += new System.EventHandler(this.btnAddFamily_Click);
			// 
			// GestionarFamilia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 216);
			this.Controls.Add(this.btnEditFamily);
			this.Controls.Add(this.btnDeleteFamily);
			this.Controls.Add(this.cmbFamilias);
			this.Controls.Add(this.btnAddFamily);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GestionarFamilia";
			this.Tag = "families";
			this.Text = "Familias";
			this.Load += new System.EventHandler(this.GestionarFamilia_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroButton btnEditFamily;
		private MetroFramework.Controls.MetroButton btnDeleteFamily;
		private MetroFramework.Controls.MetroComboBox cmbFamilias;
		private MetroFramework.Controls.MetroButton btnAddFamily;
	}
}