namespace Presentacion
{
	partial class Ayuda
	{
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
			this.view = new Spire.PdfViewer.Forms.PdfViewer();
			this.SuspendLayout();
			// 
			// view
			// 
			this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.view.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
			this.view.FormFillEnabled = false;
			this.view.IgnoreCase = false;
			this.view.IsToolBarVisible = true;
			this.view.Location = new System.Drawing.Point(23, 63);
			this.view.Name = "view";
			this.view.OnRenderPageExceptionEvent = null;
			this.view.Size = new System.Drawing.Size(754, 364);
			this.view.TabIndex = 1;
			this.view.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
			// 
			// Ayuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.view);
			this.Name = "Ayuda";
			this.Tag = "help";
			this.Text = "Ayuda";
			this.Load += new System.EventHandler(this.Ayuda_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Spire.PdfViewer.Forms.PdfViewer view;
	}
}