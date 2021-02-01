namespace Presentacion {
	partial class DetalleObjetivo {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleObjetivo));
			this.cbNivel = new MetroFramework.Controls.MetroComboBox();
			this.lblResponse = new MetroFramework.Controls.MetroLabel();
			this.dtCerrarAntesDe = new System.Windows.Forms.DateTimePicker();
			this.cbEmpleado = new MetroFramework.Controls.MetroComboBox();
			this.lblEmpleado = new MetroFramework.Controls.MetroLabel();
			this.btnGuardar = new MetroFramework.Controls.MetroButton();
			this.lblCerrarAntesDe = new MetroFramework.Controls.MetroLabel();
			this.lblNivel = new MetroFramework.Controls.MetroLabel();
			this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
			this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
			this.lblFCreacion = new MetroFramework.Controls.MetroLabel();
			this.txtFCreacion = new MetroFramework.Controls.MetroTextBox();
			this.txtFAsignacion = new MetroFramework.Controls.MetroTextBox();
			this.lblFAsignacion = new MetroFramework.Controls.MetroLabel();
			this.txtFCierre = new MetroFramework.Controls.MetroTextBox();
			this.lblFCierre = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
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
			this.cbNivel.Location = new System.Drawing.Point(279, 170);
			this.cbNivel.Name = "cbNivel";
			this.cbNivel.Size = new System.Drawing.Size(237, 29);
			this.cbNivel.TabIndex = 30;
			this.cbNivel.UseSelectable = true;
			// 
			// lblResponse
			// 
			this.lblResponse.AutoSize = true;
			this.lblResponse.Location = new System.Drawing.Point(115, 286);
			this.lblResponse.Name = "lblResponse";
			this.lblResponse.Size = new System.Drawing.Size(0, 0);
			this.lblResponse.TabIndex = 29;
			// 
			// dtCerrarAntesDe
			// 
			this.dtCerrarAntesDe.Location = new System.Drawing.Point(279, 242);
			this.dtCerrarAntesDe.Name = "dtCerrarAntesDe";
			this.dtCerrarAntesDe.Size = new System.Drawing.Size(237, 20);
			this.dtCerrarAntesDe.TabIndex = 28;
			// 
			// cbEmpleado
			// 
			this.cbEmpleado.FormattingEnabled = true;
			this.cbEmpleado.ItemHeight = 23;
			this.cbEmpleado.Location = new System.Drawing.Point(279, 206);
			this.cbEmpleado.Name = "cbEmpleado";
			this.cbEmpleado.Size = new System.Drawing.Size(237, 29);
			this.cbEmpleado.TabIndex = 27;
			this.cbEmpleado.UseSelectable = true;
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Location = new System.Drawing.Point(114, 216);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(126, 19);
			this.lblEmpleado.TabIndex = 26;
			this.lblEmpleado.Tag = "employee_assigned";
			this.lblEmpleado.Text = "Empleado asignado";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(419, 404);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(97, 23);
			this.btnGuardar.TabIndex = 25;
			this.btnGuardar.Tag = "save";
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseSelectable = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblCerrarAntesDe
			// 
			this.lblCerrarAntesDe.AutoSize = true;
			this.lblCerrarAntesDe.Location = new System.Drawing.Point(114, 243);
			this.lblCerrarAntesDe.Name = "lblCerrarAntesDe";
			this.lblCerrarAntesDe.Size = new System.Drawing.Size(100, 19);
			this.lblCerrarAntesDe.TabIndex = 24;
			this.lblCerrarAntesDe.Tag = "close_before";
			this.lblCerrarAntesDe.Text = "Cerrar antes de";
			// 
			// lblNivel
			// 
			this.lblNivel.AutoSize = true;
			this.lblNivel.Location = new System.Drawing.Point(114, 180);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(38, 19);
			this.lblNivel.TabIndex = 23;
			this.lblNivel.Tag = "level";
			this.lblNivel.Text = "Nivel";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(114, 78);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
			this.lblDescripcion.TabIndex = 22;
			this.lblDescripcion.Tag = "description";
			this.lblDescripcion.Text = "Descripcion";
			// 
			// txtDescripcion
			// 
			// 
			// 
			// 
			this.txtDescripcion.CustomButton.Image = null;
			this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(76, 1);
			this.txtDescripcion.CustomButton.Name = "";
			this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(40, 42);
			this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDescripcion.CustomButton.TabIndex = 1;
			this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDescripcion.CustomButton.UseSelectable = true;
			this.txtDescripcion.CustomButton.Visible = false;
			this.txtDescripcion.Lines = new string[0];
			this.txtDescripcion.Location = new System.Drawing.Point(279, 78);
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
			this.txtDescripcion.TabIndex = 21;
			this.txtDescripcion.UseSelectable = true;
			this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblFCreacion
			// 
			this.lblFCreacion.AutoSize = true;
			this.lblFCreacion.Location = new System.Drawing.Point(114, 273);
			this.lblFCreacion.Name = "lblFCreacion";
			this.lblFCreacion.Size = new System.Drawing.Size(96, 19);
			this.lblFCreacion.TabIndex = 31;
			this.lblFCreacion.Tag = "date_creation";
			this.lblFCreacion.Text = "Fecha creacion";
			// 
			// txtFCreacion
			// 
			// 
			// 
			// 
			this.txtFCreacion.CustomButton.Image = null;
			this.txtFCreacion.CustomButton.Location = new System.Drawing.Point(108, 1);
			this.txtFCreacion.CustomButton.Name = "";
			this.txtFCreacion.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.txtFCreacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFCreacion.CustomButton.TabIndex = 1;
			this.txtFCreacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFCreacion.CustomButton.UseSelectable = true;
			this.txtFCreacion.CustomButton.Visible = false;
			this.txtFCreacion.Enabled = false;
			this.txtFCreacion.Lines = new string[] {
        "metroTextBox1"};
			this.txtFCreacion.Location = new System.Drawing.Point(279, 269);
			this.txtFCreacion.MaxLength = 32767;
			this.txtFCreacion.Name = "txtFCreacion";
			this.txtFCreacion.PasswordChar = '\0';
			this.txtFCreacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFCreacion.SelectedText = "";
			this.txtFCreacion.SelectionLength = 0;
			this.txtFCreacion.SelectionStart = 0;
			this.txtFCreacion.ShortcutsEnabled = true;
			this.txtFCreacion.Size = new System.Drawing.Size(237, 23);
			this.txtFCreacion.TabIndex = 32;
			this.txtFCreacion.Text = "metroTextBox1";
			this.txtFCreacion.UseSelectable = true;
			this.txtFCreacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFCreacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtFAsignacion
			// 
			// 
			// 
			// 
			this.txtFAsignacion.CustomButton.Image = null;
			this.txtFAsignacion.CustomButton.Location = new System.Drawing.Point(108, 1);
			this.txtFAsignacion.CustomButton.Name = "";
			this.txtFAsignacion.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.txtFAsignacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFAsignacion.CustomButton.TabIndex = 1;
			this.txtFAsignacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFAsignacion.CustomButton.UseSelectable = true;
			this.txtFAsignacion.CustomButton.Visible = false;
			this.txtFAsignacion.Enabled = false;
			this.txtFAsignacion.Lines = new string[] {
        "metroTextBox2"};
			this.txtFAsignacion.Location = new System.Drawing.Point(279, 299);
			this.txtFAsignacion.MaxLength = 32767;
			this.txtFAsignacion.Name = "txtFAsignacion";
			this.txtFAsignacion.PasswordChar = '\0';
			this.txtFAsignacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFAsignacion.SelectedText = "";
			this.txtFAsignacion.SelectionLength = 0;
			this.txtFAsignacion.SelectionStart = 0;
			this.txtFAsignacion.ShortcutsEnabled = true;
			this.txtFAsignacion.Size = new System.Drawing.Size(237, 23);
			this.txtFAsignacion.TabIndex = 34;
			this.txtFAsignacion.Text = "metroTextBox2";
			this.txtFAsignacion.UseSelectable = true;
			this.txtFAsignacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFAsignacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblFAsignacion
			// 
			this.lblFAsignacion.AutoSize = true;
			this.lblFAsignacion.Location = new System.Drawing.Point(114, 303);
			this.lblFAsignacion.Name = "lblFAsignacion";
			this.lblFAsignacion.Size = new System.Drawing.Size(108, 19);
			this.lblFAsignacion.TabIndex = 33;
			this.lblFAsignacion.Tag = "date_asignation";
			this.lblFAsignacion.Text = "Fecha asignacion";
			// 
			// txtFCierre
			// 
			// 
			// 
			// 
			this.txtFCierre.CustomButton.Image = null;
			this.txtFCierre.CustomButton.Location = new System.Drawing.Point(108, 1);
			this.txtFCierre.CustomButton.Name = "";
			this.txtFCierre.CustomButton.Size = new System.Drawing.Size(10, 11);
			this.txtFCierre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtFCierre.CustomButton.TabIndex = 1;
			this.txtFCierre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtFCierre.CustomButton.UseSelectable = true;
			this.txtFCierre.CustomButton.Visible = false;
			this.txtFCierre.Enabled = false;
			this.txtFCierre.Lines = new string[] {
        "metroTextBox3"};
			this.txtFCierre.Location = new System.Drawing.Point(279, 330);
			this.txtFCierre.MaxLength = 32767;
			this.txtFCierre.Name = "txtFCierre";
			this.txtFCierre.PasswordChar = '\0';
			this.txtFCierre.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtFCierre.SelectedText = "";
			this.txtFCierre.SelectionLength = 0;
			this.txtFCierre.SelectionStart = 0;
			this.txtFCierre.ShortcutsEnabled = true;
			this.txtFCierre.Size = new System.Drawing.Size(237, 23);
			this.txtFCierre.TabIndex = 36;
			this.txtFCierre.Text = "metroTextBox3";
			this.txtFCierre.UseSelectable = true;
			this.txtFCierre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtFCierre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lblFCierre
			// 
			this.lblFCierre.AutoSize = true;
			this.lblFCierre.Location = new System.Drawing.Point(114, 334);
			this.lblFCierre.Name = "lblFCierre";
			this.lblFCierre.Size = new System.Drawing.Size(80, 19);
			this.lblFCierre.TabIndex = 35;
			this.lblFCierre.Tag = "date_close";
			this.lblFCierre.Text = "Fecha cierre";
			// 
			// DetalleObjetivo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 450);
			this.Controls.Add(this.txtFCierre);
			this.Controls.Add(this.lblFCierre);
			this.Controls.Add(this.txtFAsignacion);
			this.Controls.Add(this.lblFAsignacion);
			this.Controls.Add(this.txtFCreacion);
			this.Controls.Add(this.lblFCreacion);
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
			this.Name = "DetalleObjetivo";
			this.Tag = "see_detail";
			this.Text = "Detalle";
			this.Load += new System.EventHandler(this.DetalleObjetivo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroComboBox cbNivel;
		private MetroFramework.Controls.MetroLabel lblResponse;
		private System.Windows.Forms.DateTimePicker dtCerrarAntesDe;
		private MetroFramework.Controls.MetroComboBox cbEmpleado;
		private MetroFramework.Controls.MetroLabel lblEmpleado;
		private MetroFramework.Controls.MetroButton btnGuardar;
		private MetroFramework.Controls.MetroLabel lblCerrarAntesDe;
		private MetroFramework.Controls.MetroLabel lblNivel;
		private MetroFramework.Controls.MetroLabel lblDescripcion;
		private MetroFramework.Controls.MetroTextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel lblFCreacion;
		private MetroFramework.Controls.MetroTextBox txtFCreacion;
		private MetroFramework.Controls.MetroTextBox txtFAsignacion;
		private MetroFramework.Controls.MetroLabel lblFAsignacion;
		private MetroFramework.Controls.MetroTextBox txtFCierre;
		private MetroFramework.Controls.MetroLabel lblFCierre;
	}
}