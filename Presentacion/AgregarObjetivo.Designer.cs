namespace Presentacion {
	partial class AgregarObjetivo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarObjetivo));
			this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
			this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
			this.lblNivel = new MetroFramework.Controls.MetroLabel();
			this.lblCerrarAntesDe = new MetroFramework.Controls.MetroLabel();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.lblEmpleado = new MetroFramework.Controls.MetroLabel();
			this.cbEmpleado = new MetroFramework.Controls.MetroComboBox();
			this.dtCerrarAntesDe = new System.Windows.Forms.DateTimePicker();
			this.lblResponse = new MetroFramework.Controls.MetroLabel();
			this.cbNivel = new MetroFramework.Controls.MetroComboBox();
			this.SuspendLayout();
			// 
			// txtDescripcion
			// 
			// 
			// 
			// 
			this.txtDescripcion.CustomButton.Image = null;
			this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(153, 2);
			this.txtDescripcion.CustomButton.Name = "";
			this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(81, 81);
			this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDescripcion.CustomButton.TabIndex = 1;
			this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDescripcion.CustomButton.UseSelectable = true;
			this.txtDescripcion.CustomButton.Visible = false;
			this.txtDescripcion.Lines = new string[0];
			this.txtDescripcion.Location = new System.Drawing.Point(249, 86);
			this.txtDescripcion.MaxLength = 32767;
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.PasswordChar = '\0';
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDescripcion.SelectedText = "";
			this.txtDescripcion.SelectionLength = 0;
			this.txtDescripcion.SelectionStart = 0;
			this.txtDescripcion.ShortcutsEnabled = true;
			this.txtDescripcion.Size = new System.Drawing.Size(237, 86);
			this.txtDescripcion.TabIndex = 0;
			this.txtDescripcion.UseSelectable = true;
			this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(84, 86);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
			this.lblDescripcion.TabIndex = 1;
			this.lblDescripcion.Tag = "description";
			this.lblDescripcion.Text = "Descripcion";
			// 
			// lblNivel
			// 
			this.lblNivel.AutoSize = true;
			this.lblNivel.Location = new System.Drawing.Point(84, 186);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(38, 19);
			this.lblNivel.TabIndex = 2;
			this.lblNivel.Tag = "level";
			this.lblNivel.Text = "Nivel";
			// 
			// lblCerrarAntesDe
			// 
			this.lblCerrarAntesDe.AutoSize = true;
			this.lblCerrarAntesDe.Location = new System.Drawing.Point(85, 250);
			this.lblCerrarAntesDe.Name = "lblCerrarAntesDe";
			this.lblCerrarAntesDe.Size = new System.Drawing.Size(100, 19);
			this.lblCerrarAntesDe.TabIndex = 10;
			this.lblCerrarAntesDe.Tag = "close_before";
			this.lblCerrarAntesDe.Text = "Cerrar antes de";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(390, 290);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(97, 23);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Tag = "save";
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Location = new System.Drawing.Point(85, 218);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(126, 19);
			this.lblEmpleado.TabIndex = 13;
			this.lblEmpleado.Tag = "employee_assigned";
			this.lblEmpleado.Text = "Empleado asignado";
			// 
			// cbEmpleado
			// 
			this.cbEmpleado.FormattingEnabled = true;
			this.cbEmpleado.ItemHeight = 23;
			this.cbEmpleado.Location = new System.Drawing.Point(250, 211);
			this.cbEmpleado.Name = "cbEmpleado";
			this.cbEmpleado.Size = new System.Drawing.Size(236, 29);
			this.cbEmpleado.TabIndex = 17;
			this.cbEmpleado.UseSelectable = true;
			// 
			// dtCerrarAntesDe
			// 
			this.dtCerrarAntesDe.Location = new System.Drawing.Point(250, 248);
			this.dtCerrarAntesDe.Name = "dtCerrarAntesDe";
			this.dtCerrarAntesDe.Size = new System.Drawing.Size(236, 20);
			this.dtCerrarAntesDe.TabIndex = 18;
			// 
			// lblResponse
			// 
			this.lblResponse.AutoSize = true;
			this.lblResponse.Location = new System.Drawing.Point(85, 294);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(0, 0);
			this.lblResponse.TabIndex = 19;
			// 
			// cbNivel
			// 
			this.cbNivel.FormattingEnabled = true;
			this.cbNivel.ItemHeight = 23;
			this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cbNivel.Location = new System.Drawing.Point(249, 177);
			this.cbNivel.Name = "cbNivel";
			this.cbNivel.Size = new System.Drawing.Size(236, 29);
			this.cbNivel.TabIndex = 20;
			this.cbNivel.UseSelectable = true;
			// 
			// AgregarObjetivo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 364);
			this.Controls.Add(this.cbNivel);
			this.Controls.Add(this.lblResponse);
			this.Controls.Add(this.dtCerrarAntesDe);
			this.Controls.Add(this.cbEmpleado);
			this.Controls.Add(this.lblEmpleado);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblCerrarAntesDe);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.txtDescripcion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AgregarObjetivo";
			this.Tag = "objective";
			this.Text = "Objetivo";
			this.Load += new System.EventHandler(this.AgregarObjetivo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel lblDescripcion;
		private MetroFramework.Controls.MetroLabel lblNivel;
		private MetroFramework.Controls.MetroLabel lblCerrarAntesDe;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroLabel lblEmpleado;
		private MetroFramework.Controls.MetroComboBox cbEmpleado;
		private System.Windows.Forms.DateTimePicker dtCerrarAntesDe;
		private MetroFramework.Controls.MetroLabel lblResponse;
		private MetroFramework.Controls.MetroComboBox cbNivel;
	}
}