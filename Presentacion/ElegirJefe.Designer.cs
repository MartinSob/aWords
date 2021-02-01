namespace Presentacion {
	partial class ElegirJefe {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirJefe));
			this.cbUsuarios = new System.Windows.Forms.ComboBox();
			this.btnEnviar = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// cbUsuarios
			// 
			this.cbUsuarios.FormattingEnabled = true;
			this.cbUsuarios.Location = new System.Drawing.Point(50, 85);
			this.cbUsuarios.Name = "cbUsuarios";
			this.cbUsuarios.Size = new System.Drawing.Size(272, 21);
			this.cbUsuarios.TabIndex = 0;
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(247, 144);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(75, 23);
			this.btnEnviar.TabIndex = 1;
			this.btnEnviar.Tag = "save";
			this.btnEnviar.Text = "Guardar";
			this.btnEnviar.UseSelectable = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// ElegirJefe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 216);
			this.Controls.Add(this.btnEnviar);
			this.Controls.Add(this.cbUsuarios);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ElegirJefe";
			this.Text = "Elegir jefe";
			this.Load += new System.EventHandler(this.SelectBoss_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbUsuarios;
		private MetroFramework.Controls.MetroButton btnEnviar;
	}
}