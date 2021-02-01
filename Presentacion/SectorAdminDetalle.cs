using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class SectorAdminDetalle : UpdatableForm {
		public Sector sector;

		public SectorAdminDetalle() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void SectorAdminDetalle_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			allControls.Add(lblOpenObj);
			allControls.Add(lblClosedObj);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			this.Text = SectorManager.obtener(sector.id).nombre;

			loadOpenObjectives();
			loadClosedObjectives();
		}
		
		private void loadOpenObjectives() {
			var items = new List<Object>();
			foreach (Objetivo objetivo in ObjetivoManager.obtenerAbiertos(this.sector)) {
				string itemText = "";
				if (ObjetivoManager.obtenerEmpleado(objetivo) == null) {
					itemText = $"{objetivo.descripcion}";
				} else {
					itemText = $"({ObjetivoManager.obtenerEmpleado(objetivo).apellido}, {ObjetivoManager.obtenerEmpleado(objetivo).nombre}) {objetivo.descripcion}";
				}
				
				items.Add(new ComboboxItem { Text = itemText, Value = objetivo.id });
			}

			lbOpenObj.DisplayMember = "Text";
			lbOpenObj.ValueMember = "Value";
			lbOpenObj.DataSource = items;
		}

		private void loadClosedObjectives() {
			var items = new List<Object>();
			foreach (Objetivo objetivo in ObjetivoManager.obtenerCerrados(this.sector)) {
				items.Add(new ComboboxItem { Text = objetivo.descripcion, Value = objetivo.id });
			}

			lbClosedObj.DisplayMember = "Text";
			lbClosedObj.ValueMember = "Value";
			lbClosedObj.DataSource = items;
		}

		private void btnDetalleMiObjetivo_Click(object sender, EventArgs e) {
            if (lbOpenObj.SelectedItem == null) {
                return;
            }

            int objId = int.Parse((lbOpenObj.SelectedItem as ComboboxItem).Value.ToString());

			DetalleObjetivo detObj = new DetalleObjetivo { objective = ObjetivoManager.obtener(objId) };
			detObj.Show();
		}

		private void btnDetalleObjetivo_Click(object sender, EventArgs e) {
            if (lbClosedObj.SelectedItem == null) {
                return;
            }

            int objId = int.Parse((lbClosedObj.SelectedItem as ComboboxItem).Value.ToString());

			DetalleObjetivo detObj = new DetalleObjetivo { objective = ObjetivoManager.obtener(objId) };
			detObj.Show();
		}

		private void btnObjNoFinalizado_Click(object sender, EventArgs e) {
            if (lbClosedObj.SelectedItem == null) {
                return;
            }

            Objetivo obj = new Objetivo {
				id = int.Parse((lbClosedObj.SelectedItem as ComboboxItem).Value.ToString())
			};
			ObjetivoManager.noFinalizado(obj);

			//ObjetivoManager.asignarEmpleado(obj, Sesion.obtenerSesion().usuario.id);

			loadOpenObjectives();
			loadClosedObjectives();
		}

		private void btnArchivar_Click(object sender, EventArgs e) {
			if (lbClosedObj.SelectedItem == null) {
				return;
			}

			Objetivo obj = new Objetivo {
				id = int.Parse((lbClosedObj.SelectedItem as ComboboxItem).Value.ToString())
			};

			ObjetivoManager.archivar(obj);

			loadOpenObjectives();
			loadClosedObjectives();
		}

		private void btnAddObj_Click(object sender, EventArgs e) {
			AgregarObjetivo ao = new AgregarObjetivo();
			ao.sectorUsuario = sector;
			ao.Show();
		}
	}
}
