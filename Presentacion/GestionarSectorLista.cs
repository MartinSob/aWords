using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion
{
    public partial class GestionarSectorLista : UpdatableForm
    {
        List<Sector> sectores;

        public GestionarSectorLista() {
            InitializeComponent();
            Sesion.obtenerSesion().idioma.forms.Add(this);
        }

        private void GestionarSectorLista_Load(object sender, EventArgs e) {
            this.allControls = Program.GetAllControls(this);

            IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

            updateSectoresList();
        }

        private void updateSectoresList() {
            sectores = SectorManager.obtener();

            cmbSectores.DisplayMember = "Text";
            cmbSectores.ValueMember = "Value";

            var items = new List<Object>();
            foreach (Sector sector in sectores) {
                items.Add(new ComboboxItem { Text = sector.nombre, Value = sector.id });
            }

            cmbSectores.DataSource = items;
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            GestionarSector gs = new GestionarSector();
            gs.Show();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
            GestionarSector gs = new GestionarSector();
            Sector selectedSector = SectorManager.obtener(int.Parse((cmbSectores.SelectedItem as ComboboxItem).Value.ToString()));

            if(selectedSector == null) {
                return;
			}

            gs.selectedSector = selectedSector;
            gs.Show();
        }

		private void btnDelete_Click(object sender, EventArgs e) {
            if (cmbSectores.SelectedIndex == -1) {
                return;
            }
            SectorManager.borrar(int.Parse((cmbSectores.SelectedItem as ComboboxItem).Value.ToString()));
            updateSectoresList();
        }
	}
}
