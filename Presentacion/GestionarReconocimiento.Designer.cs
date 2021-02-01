namespace Presentacion
{
	partial class GestionarReconocimiento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarReconocimiento));
			this.gridRewards = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reconocedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reconocido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDelete = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.gridRewards)).BeginInit();
			this.SuspendLayout();
			// 
			// gridRewards
			// 
			this.gridRewards.AllowUserToAddRows = false;
			this.gridRewards.AllowUserToDeleteRows = false;
			this.gridRewards.AllowUserToResizeColumns = false;
			this.gridRewards.AllowUserToResizeRows = false;
			this.gridRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridRewards.BackgroundColor = System.Drawing.Color.White;
			this.gridRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Reconocedor,
            this.Reconocido,
            this.Descripcion});
			this.gridRewards.GridColor = System.Drawing.Color.White;
			this.gridRewards.Location = new System.Drawing.Point(23, 82);
			this.gridRewards.MultiSelect = false;
			this.gridRewards.Name = "gridRewards";
			this.gridRewards.ReadOnly = true;
			this.gridRewards.RowHeadersVisible = false;
			this.gridRewards.RowHeadersWidth = 72;
			this.gridRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridRewards.Size = new System.Drawing.Size(517, 345);
			this.gridRewards.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.MinimumWidth = 9;
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Reconocedor
			// 
			this.Reconocedor.HeaderText = "Reconocedor";
			this.Reconocedor.MinimumWidth = 9;
			this.Reconocedor.Name = "Reconocedor";
			this.Reconocedor.ReadOnly = true;
			// 
			// Reconocido
			// 
			this.Reconocido.HeaderText = "Reconocido";
			this.Reconocido.MinimumWidth = 9;
			this.Reconocido.Name = "Reconocido";
			this.Reconocido.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.MinimumWidth = 9;
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(557, 404);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Tag = "delete";
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseSelectable = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// GestionarReconocimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.gridRewards);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GestionarReconocimiento";
			this.Tag = "rewards";
			this.Text = "Reconocimientos";
			this.Load += new System.EventHandler(this.GestionarReconocimiento_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridRewards)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridRewards;
		private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reconocedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reconocido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}