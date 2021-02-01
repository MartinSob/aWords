namespace Presentacion {
	partial class RealizarBackup {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarBackup));
			this.btnBackUp = new MetroFramework.Controls.MetroButton();
			this.btnRestore = new MetroFramework.Controls.MetroButton();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// btnBackUp
			// 
			this.btnBackUp.Location = new System.Drawing.Point(59, 109);
			this.btnBackUp.Name = "btnBackUp";
			this.btnBackUp.Size = new System.Drawing.Size(75, 23);
			this.btnBackUp.TabIndex = 3;
			this.btnBackUp.Text = "Back Up";
			this.btnBackUp.UseSelectable = true;
			this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Location = new System.Drawing.Point(59, 139);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(75, 23);
			this.btnRestore.TabIndex = 4;
			this.btnRestore.Tag = "restore";
			this.btnRestore.Text = "Restaurar";
			this.btnRestore.UseSelectable = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 0);
			this.label1.TabIndex = 5;
			// 
			// RealizarBackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 247);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRestore);
			this.Controls.Add(this.btnBackUp);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "RealizarBackup";
			this.Tag = "";
			this.Text = "BackUp/Restore";
			this.Load += new System.EventHandler(this.RealizarBackup_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton btnBackUp;
		private MetroFramework.Controls.MetroButton btnRestore;
		private MetroFramework.Controls.MetroLabel label1;
	}
}