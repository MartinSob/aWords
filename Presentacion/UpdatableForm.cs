using BusinessEntity;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public class UpdatableForm : MetroFramework.Forms.MetroForm, iUpdatable {
		protected List<System.Windows.Forms.Control> allControls = new List<System.Windows.Forms.Control>();

		public virtual void actulizarTextos() {
			if (this.Tag != null && this.Text != "" && Sesion.obtenerSesion().idioma.textos.ContainsKey(this.Tag.ToString())) {
				this.Text = Sesion.obtenerSesion().idioma.textos[this.Tag.ToString()];
			}

			foreach (System.Windows.Forms.Control ctrl in allControls) {
				if (ctrl.Tag != null && ctrl.Tag.ToString() != "") {
					string asd = ctrl.Tag.ToString();
					ctrl.Text = Sesion.obtenerSesion().idioma.textos[ctrl.Tag.ToString()];
				}
			}

			this.Refresh();
		}

		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatableForm));
			this.SuspendLayout();
			// 
			// UpdatableForm
			// 
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpdatableForm";
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
			this.Load += new System.EventHandler(this.UpdatableForm_Load);
			this.ResumeLayout(false);

		}

		private void UpdatableForm_Load(object sender, EventArgs e) {
		}
	}
}
