namespace Presentacion
{
    partial class GestionarSectorLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarSectorLista));
			this.cmbSectores = new System.Windows.Forms.ComboBox();
			this.btnDelete = new MetroFramework.Controls.MetroButton();
			this.btnEdit = new MetroFramework.Controls.MetroButton();
			this.btnAdd = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// cmbSectores
			// 
			this.cmbSectores.FormattingEnabled = true;
			this.cmbSectores.Location = new System.Drawing.Point(62, 84);
			this.cmbSectores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbSectores.Name = "cmbSectores";
			this.cmbSectores.Size = new System.Drawing.Size(220, 21);
			this.cmbSectores.TabIndex = 20;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(216, 133);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(65, 19);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Tag = "delete";
			this.btnDelete.Text = "Borrar";
			this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.btnDelete.UseSelectable = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(138, 133);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(65, 19);
			this.btnEdit.TabIndex = 18;
			this.btnEdit.Tag = "edit";
			this.btnEdit.Text = "Editar";
			this.btnEdit.UseSelectable = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(62, 133);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(65, 19);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Tag = "add";
			this.btnAdd.Text = "Agregar";
			this.btnAdd.UseSelectable = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// GestionarSectorLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 190);
			this.Controls.Add(this.cmbSectores);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "GestionarSectorLista";
			this.Padding = new System.Windows.Forms.Padding(10, 31, 10, 10);
			this.Tag = "sectors";
			this.Text = "Sectores";
			this.Load += new System.EventHandler(this.GestionarSectorLista_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSectores;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}