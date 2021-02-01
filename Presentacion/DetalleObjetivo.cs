using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class DetalleObjetivo : UpdatableForm {
		public Objetivo objective;

		public DetalleObjetivo() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void DetalleObjetivo_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblCerrarAntesDe);
			allControls.Add(lblDescripcion);
			allControls.Add(lblEmpleado);
			allControls.Add(lblFAsignacion);
			allControls.Add(lblFCierre);
			allControls.Add(lblFCreacion);
			allControls.Add(lblNivel);

			updateTrabajadoresList();

			txtDescripcion.Text = objective.descripcion;
			txtFAsignacion.Text = objective.fechaAsignacion.ToString();
			txtFCierre.Text = objective.fechaFin.ToString();
			txtFCreacion.Text = objective.fechaCreacion.ToString();
			dtCerrarAntesDe.Value = objective.fechaCerrarAntesDe;
			cbNivel.SelectedIndex = cbNivel.FindStringExact(objective.nivelIssue.ToString());

			if (ObjetivoManager.obtenerEmpleado(objective) != null) {
				cbEmpleado.SelectedIndex = cbEmpleado.FindStringExact(ObjetivoManager.obtenerEmpleado(objective).NombreCompleto);
			}

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			if (!PermisosManager.verificarPatente(Sesion.obtenerSesion().usuario, "ModificarObjetivo")) {
				txtDescripcion.Enabled = false;
				txtFAsignacion.Enabled = false;
				txtFCierre.Enabled = false;
				txtFCreacion.Enabled = false;
				dtCerrarAntesDe.Enabled = false;
				cbNivel.Enabled = false;
				cbEmpleado.Enabled = false;
				btnGuardar.Visible = false;
			}
		}

		private void updateTrabajadoresList() {
			List<Usuario> trabajadores = SectorManager.obtenerTrabajadores(TrabajadorManager.obtenerSector(Sesion.obtenerSesion().usuario));

			if(trabajadores == null || trabajadores.Count == 0) {
				return;
			}

			cbEmpleado.DisplayMember = "Text";
			cbEmpleado.ValueMember = "Value";

			var items = new List<Object> { new ComboboxItem { Text = "", Value = 0 } };
			foreach (Usuario trabajador in trabajadores) {
				items.Add(new ComboboxItem { Text = trabajador.NombreCompleto, Value = trabajador.id });
			}

			cbEmpleado.DataSource = items;
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			// TODO
		}
	}
}
