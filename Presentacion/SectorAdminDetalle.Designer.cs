namespace Presentacion {
	partial class SectorAdminDetalle {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorAdminDetalle));
			this.lbOpenObj = new System.Windows.Forms.ListBox();
			this.btnDetalleMiObjetivo = new MetroFramework.Controls.MetroButton();
			this.btnDetalleObjetivo = new MetroFramework.Controls.MetroButton();
			this.btnObjNoFinalizado = new MetroFramework.Controls.MetroButton();
			this.lbClosedObj = new System.Windows.Forms.ListBox();
			this.lblClosedObj = new MetroFramework.Controls.MetroLabel();
			this.lblOpenObj = new MetroFramework.Controls.MetroLabel();
			this.btnArchivar = new MetroFramework.Controls.MetroButton();
			this.btnAddObj = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// lbOpenObj
			// 
			this.lbOpenObj.FormattingEnabled = true;
			this.lbOpenObj.Location = new System.Drawing.Point(28, 114);
			this.lbOpenObj.Name = "lbOpenObj";
			this.lbOpenObj.Size = new System.Drawing.Size(349, 173);
			this.lbOpenObj.TabIndex = 22;
			// 
			// btnDetalleMiObjetivo
			// 
			this.btnDetalleMiObjetivo.Location = new System.Drawing.Point(267, 293);
			this.btnDetalleMiObjetivo.Name = "btnDetalleMiObjetivo";
			this.btnDetalleMiObjetivo.Size = new System.Drawing.Size(110, 23);
			this.btnDetalleMiObjetivo.TabIndex = 21;
			this.btnDetalleMiObjetivo.Tag = "see_detail";
			this.btnDetalleMiObjetivo.Text = "Detalle";
			this.btnDetalleMiObjetivo.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnDetalleMiObjetivo.UseSelectable = true;
			this.btnDetalleMiObjetivo.Click += new System.EventHandler(this.btnDetalleMiObjetivo_Click);
			// 
			// btnDetalleObjetivo
			// 
			this.btnDetalleObjetivo.Location = new System.Drawing.Point(634, 293);
			this.btnDetalleObjetivo.Name = "btnDetalleObjetivo";
			this.btnDetalleObjetivo.Size = new System.Drawing.Size(110, 23);
			this.btnDetalleObjetivo.TabIndex = 20;
			this.btnDetalleObjetivo.Tag = "see_detail";
			this.btnDetalleObjetivo.Text = "Detalle";
			this.btnDetalleObjetivo.Theme = MetroFramework.MetroThemeStyle.Light;
			this.btnDetalleObjetivo.UseSelectable = true;
			this.btnDetalleObjetivo.Click += new System.EventHandler(this.btnDetalleObjetivo_Click);
			// 
			// btnObjNoFinalizado
			// 
			this.btnObjNoFinalizado.Location = new System.Drawing.Point(518, 293);
			this.btnObjNoFinalizado.Name = "btnObjNoFinalizado";
			this.btnObjNoFinalizado.Size = new System.Drawing.Size(110, 23);
			this.btnObjNoFinalizado.TabIndex = 19;
			this.btnObjNoFinalizado.Tag = "not_finalized";
			this.btnObjNoFinalizado.Text = "No finalizado";
			this.btnObjNoFinalizado.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnObjNoFinalizado.UseSelectable = true;
			this.btnObjNoFinalizado.Click += new System.EventHandler(this.btnObjNoFinalizado_Click);
			// 
			// lbClosedObj
			// 
			this.lbClosedObj.FormattingEnabled = true;
			this.lbClosedObj.Location = new System.Drawing.Point(395, 114);
			this.lbClosedObj.Name = "lbClosedObj";
			this.lbClosedObj.Size = new System.Drawing.Size(349, 173);
			this.lbClosedObj.TabIndex = 18;
			// 
			// lblClosedObj
			// 
			this.lblClosedObj.AutoSize = true;
			this.lblClosedObj.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblClosedObj.Location = new System.Drawing.Point(395, 86);
			this.lblClosedObj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblClosedObj.Name = "lblClosedObj";
			this.lblClosedObj.Size = new System.Drawing.Size(168, 25);
			this.lblClosedObj.TabIndex = 17;
			this.lblClosedObj.Tag = "sector_objectives";
			this.lblClosedObj.Text = "Objetivos finalizados";
			// 
			// lblOpenObj
			// 
			this.lblOpenObj.AutoSize = true;
			this.lblOpenObj.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lblOpenObj.Location = new System.Drawing.Point(27, 85);
			this.lblOpenObj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOpenObj.Name = "lblOpenObj";
			this.lblOpenObj.Size = new System.Drawing.Size(149, 25);
			this.lblOpenObj.TabIndex = 13;
			this.lblOpenObj.Tag = "open_objectives";
			this.lblOpenObj.Text = "Objetivos abiertos";
			// 
			// btnArchivar
			// 
			this.btnArchivar.Location = new System.Drawing.Point(669, 322);
			this.btnArchivar.Name = "btnArchivar";
			this.btnArchivar.Size = new System.Drawing.Size(75, 23);
			this.btnArchivar.TabIndex = 23;
			this.btnArchivar.Tag = "archive";
			this.btnArchivar.Text = "Archivar";
			this.btnArchivar.UseSelectable = true;
			this.btnArchivar.Click += new System.EventHandler(this.btnArchivar_Click);
			// 
			// btnAddObj
			// 
			this.btnAddObj.Location = new System.Drawing.Point(176, 293);
			this.btnAddObj.Name = "btnAddObj";
			this.btnAddObj.Size = new System.Drawing.Size(85, 23);
			this.btnAddObj.TabIndex = 24;
			this.btnAddObj.Tag = "add";
			this.btnAddObj.Text = "Agregar";
			this.btnAddObj.UseSelectable = true;
			this.btnAddObj.Click += new System.EventHandler(this.btnAddObj_Click);
			// 
			// SectorAdminDetalle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 372);
			this.Controls.Add(this.btnAddObj);
			this.Controls.Add(this.btnArchivar);
			this.Controls.Add(this.lbOpenObj);
			this.Controls.Add(this.btnDetalleMiObjetivo);
			this.Controls.Add(this.btnDetalleObjetivo);
			this.Controls.Add(this.btnObjNoFinalizado);
			this.Controls.Add(this.lbClosedObj);
			this.Controls.Add(this.lblClosedObj);
			this.Controls.Add(this.lblOpenObj);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "SectorAdminDetalle";
			this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
			this.Resizable = false;
			this.Text = "SectorAdminDetalle";
			this.Load += new System.EventHandler(this.SectorAdminDetalle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbOpenObj;
		private MetroFramework.Controls.MetroButton btnDetalleMiObjetivo;
		private MetroFramework.Controls.MetroButton btnDetalleObjetivo;
		private MetroFramework.Controls.MetroButton btnObjNoFinalizado;
		private System.Windows.Forms.ListBox lbClosedObj;
		private MetroFramework.Controls.MetroLabel lblClosedObj;
		private MetroFramework.Controls.MetroLabel lblOpenObj;
		private MetroFramework.Controls.MetroButton btnArchivar;
		private MetroFramework.Controls.MetroButton btnAddObj;
	}
}