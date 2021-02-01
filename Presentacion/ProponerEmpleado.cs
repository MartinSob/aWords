using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion {
	public partial class ProponerEmpleado : UpdatableForm {
		public GestionarSector gsForm = null;
		public Sector sector = null;
		public Puesto puesto = null;
		public Emblema emblema = null;
		public bool esJefe = false;
		public bool puestoFijo = true;

		public ProponerEmpleado() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void ProponerEmpleado_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			cbPuestoFijo.Visible = !esJefe;

			fillEmblemasList();

			fillRecomended();
		}

		private void fillEmblemasList() {
			List<Emblema> emblemas = EmblemaManager.obtener();

			cmbEmblema.DisplayMember = "Text";
			cmbEmblema.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Emblema emblem in emblemas) {
				items.Add(new ComboboxItem { Text = emblem.nombre, Value = emblem.id });
			}

			cmbEmblema.DataSource = items;
		}

		private void fillRecomended() {
			dgvProposed.Rows.Clear();

			List<UsuarioPropuesto> usuarioPropuestos = PropuestaManager.obtener(sector, 5, sector.nivel, puesto, esJefe, emblema, puestoFijo);

			foreach (UsuarioPropuesto up in usuarioPropuestos) {
				dgvProposed.Rows.Add(up.id, up.NombreCompleto, PuestoManager.obtener(up).nombre, up.valorEstadistico,
					up.promedioReconocimientosDeSuperiores,
					up.porcentajeObjetivosCumplidos,
					up.promedioDeNivelObjetivosCumplidos,
					up.cantidadObjetivosNoCumplidos,
					up.promedioNivelReconocimiento,
					up.cantidadReconocimientos,
					up.emblemasRecibidos
					);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			dgvUsers.Rows.Clear();
			List<Usuario> usuarios = UsuarioManager.obtenerActivos(txtNombre.Text);

			foreach (Usuario usuario in usuarios) {
				dgvUsers.Rows.Add(usuario.id, $"{usuario.apellido}, {usuario.nombre}");
			}
		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
			if (dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			bool canEditProfile = PermisosManager.verificarPatente(Sesion.obtenerSesion().usuario, "EditarPerfil");

			var selectedItem = int.Parse(dgvUsers.SelectedRows[0].Cells["iid"].Value.ToString());

			Perfil vp = new Perfil(UsuarioManager.obtener(selectedItem), canEditProfile);
			vp.Show();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if(dgvUsers.SelectedRows.Count == 0) {
				return;
			}

			var user = UsuarioManager.obtener(int.Parse(dgvUsers.SelectedRows[0].Cells["iid"].Value.ToString()));

			if (!esJefe) {
				// To avoid reference removing
				var position = PuestoManager.obtener(sector.puestos.FindAll(p => p.Key == puesto && p.Value == null)[0].Key.id);

				sector.puestos.Remove(sector.puestos.FindAll(p => p.Key == puesto && p.Value == null)[0]);
				sector.puestos.Add(new KeyValuePair<Puesto, Usuario>(position, user));
			} else {
				sector.jefe = user;
			}

			gsForm.updateGrid();
			this.Close();
		}

		private void btnSelectProp_Click(object sender, EventArgs e)
		{
			if (dgvProposed.SelectedRows.Count == 0) {
				return;
			}

			var user = UsuarioManager.obtener(int.Parse(dgvProposed.SelectedRows[0].Cells["id"].Value.ToString()));

			if (!esJefe) {
				// To avoid reference removing
				var position = PuestoManager.obtener(sector.puestos.FindAll(p => p.Key == puesto && p.Value == null)[0].Key.id);

				sector.puestos.Remove(sector.puestos.FindAll(p => p.Key == puesto && p.Value == null)[0]);
				sector.puestos.Add(new KeyValuePair<Puesto, Usuario>(position, user));
			} else {
				sector.jefe = user;
			}

			gsForm.updateGrid();
			this.Close();
		}

		private void updateRec_Click(object sender, EventArgs e) {
			if(useEmblem.Checked) {
				emblema = EmblemaManager.obtener(int.Parse((cmbEmblema.SelectedItem as ComboboxItem).Value.ToString()))[0];
			} else {
				emblema = null;
			}

			puestoFijo = cbPuestoFijo.Checked;

			fillRecomended();
		}
	}
}
