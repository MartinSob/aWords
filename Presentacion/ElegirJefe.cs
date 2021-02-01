using BusinessEntity;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class ElegirJefe : UpdatableForm {

		public Usuario selectedTrabajador;
		public GestionarSector gestionarSector;

		public ElegirJefe() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void SelectBoss_Load(object sender, EventArgs e) {
			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			addUsersList();
		}

		private void addUsersList() {
			List<Usuario> usuarios = UsuarioManager.obtener();

			cbUsuarios.DisplayMember = "Text";
			cbUsuarios.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Usuario usuario in usuarios) {
				items.Add(new ComboboxItem { Text = usuario.apellido + ", " + usuario.nombre, Value = usuario.id });
			}

			cbUsuarios.DataSource = items;
		}

		private void btnEnviar_Click(object sender, EventArgs e) {
			selectedTrabajador = new Usuario {
				id = int.Parse((cbUsuarios.SelectedItem as ComboboxItem).Value.ToString()),
				nombre = (cbUsuarios.SelectedItem as ComboboxItem).Text.ToString()
			};
			gestionarSector.actualizarJefe(selectedTrabajador);
			this.Close();
		}

		// TODO
		/*
		 * Ofrecer un empleado basandose en: 
		 *		la cantidad de reconocimientos recibidos 
		 *		diversidad de emblemas recibidos
		 *		cumplidor de objetivos (?)
		 *		mismo tipo de sector
		 *		no tenga/ tenga pocos objetivos no cumplidos
		 *		
		*/
	}
}
