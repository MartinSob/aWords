namespace Presentacion {
	partial class Notificaciones {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificaciones));
			this.lbNotificaciones = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lbNotificaciones
			// 
			this.lbNotificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbNotificaciones.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNotificaciones.FormattingEnabled = true;
			this.lbNotificaciones.ItemHeight = 17;
			this.lbNotificaciones.Location = new System.Drawing.Point(20, 60);
			this.lbNotificaciones.Name = "lbNotificaciones";
			this.lbNotificaciones.Size = new System.Drawing.Size(212, 140);
			this.lbNotificaciones.TabIndex = 0;
			// 
			// Notificaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 220);
			this.Controls.Add(this.lbNotificaciones);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Notificaciones";
			this.Load += new System.EventHandler(this.Notificaciones_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbNotificaciones;
	}
}