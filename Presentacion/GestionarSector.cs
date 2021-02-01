using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Presentacion {
	public partial class GestionarSector : UpdatableForm {
		public Sector selectedSector = new Sector();

		public GestionarSector() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void GestionarSector_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblNombre);
			allControls.Add(lblPositions);
			allControls.Add(lblBoss);
			allControls.Add(lblLevel);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			loadPuestos();

			if (selectedSector.id != 0) {
				btnSugerirEquipo.Visible = false;

				txtNombre.Text = selectedSector.nombre;
				txtNivel.Text = selectedSector.nivel.ToString();

				SectorManager.obtenerPuestos(selectedSector);
				SectorManager.obtenerJefe(selectedSector);

				updateGrid();
			}
		}
		
		public void updateGrid()
		{
			dgPuestos.Rows.Clear();

			foreach(KeyValuePair<Puesto, Usuario> puesto in selectedSector.puestos) {
				dgPuestos.Rows.Add(puesto.Key.nombre, puesto.Value != null? puesto.Value.NombreCompleto : "");
			}

			if(selectedSector.jefe != null) {
				txtBoss.Text = selectedSector.jefe.NombreCompleto;
			} else {
				txtBoss.Text = "";
			}
		}

		private void loadPuestos() {
			cbType.DisplayMember = "Text";
			cbType.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Puesto puesto in PuestoManager.obtener())
			{
				items.Add(new ComboboxItem { Text = puesto.nombre, Value = puesto.id });
			}

			cbType.DataSource = items;
		}

		private void btnBorrarJefe_Click(object sender, EventArgs e) {
			selectedSector.jefe = null;
			txtBoss.Text = "";
		}

		private void btnSugerir_Click(object sender, EventArgs e) {
			ProponerEmpleado pe = new ProponerEmpleado();
			pe.sector = selectedSector;
			pe.gsForm = this;
			pe.esJefe = true;
			pe.Show();
		}

		public void actualizarJefe(Usuario newTrabajador) {
			this.selectedSector.jefe = newTrabajador;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			selectedSector.nombre = txtNombre.Text;

			if (selectedSector.id != 0) {
				SectorManager.actualizar(selectedSector);
			} else {
				if (SectorManager.verSiExiste(txtNombre.Text)) {
					MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["name_already_used"], Sesion.obtenerSesion().idioma.textos["notification"]);
					return;
				}

				SectorManager.crear(selectedSector);
			}

			this.Close();
		}

		private void btnAddPosition_Click(object sender, EventArgs e)
		{
			if (cbType.SelectedIndex == -1) {
				return;
			}

			var item = (cbType.SelectedItem as ComboboxItem).Value.ToString();
			Puesto newPosition = PuestoManager.obtener(int.Parse((cbType.SelectedItem as ComboboxItem).Value.ToString()));
			selectedSector.puestos.Add(new KeyValuePair<Puesto, Usuario>(newPosition, null));

			updateGrid();
		}

		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
			if (dgPuestos.SelectedRows.Count == 0 || dgPuestos.SelectedRows[0].Cells[1].Value.ToString() != "" )
			{
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["please_add_position"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			ProponerEmpleado pe = new ProponerEmpleado();
			pe.sector = selectedSector;
			pe.puesto = selectedSector.puestos[dgPuestos.SelectedRows[0].Index].Key;
			pe.gsForm = this;
			pe.esJefe = false;
			pe.Show();
		}

		private void btnDeletePosition_Click(object sender, EventArgs e)
		{
			if (dgPuestos.SelectedRows.Count == 0 || dgPuestos.SelectedRows[0].Index == -1)
			{
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["please_add_employee"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			selectedSector.puestos.RemoveAt(dgPuestos.SelectedRows[0].Index);
			updateGrid();
		}

		private void btnVerPerfil_Click(object sender, EventArgs e)
		{
			if (dgPuestos.SelectedRows.Count == 0 || dgPuestos.SelectedRows[0].Index == -1 || selectedSector.puestos[dgPuestos.SelectedRows[0].Index].Value == null)
			{
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["please_add_employee"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			Perfil p = new Perfil(selectedSector.puestos[dgPuestos.SelectedRows[0].Index].Value, false);
			p.Show();
		}

		private void btnSugerirEquipo_Click(object sender, EventArgs e) {
			if (txtNivel.Text == "" || !txtNivel.Text.All(char.IsDigit)) {
				MetroFramework.MetroMessageBox.Show(this, Sesion.obtenerSesion().idioma.textos["please_add_level"], Sesion.obtenerSesion().idioma.textos["notification"]);
				return;
			}

			PropuestaManager.proponerEquipo(selectedSector, int.Parse(txtNivel.Text), true);

			updateGrid();
		}
	}
}
