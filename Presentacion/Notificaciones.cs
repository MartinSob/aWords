using BusinessEntity;
using BusinessLogic;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class Notificaciones : UpdatableForm {
		List<Notificacion> notificaciones;
		
		public Notificaciones() {
			InitializeComponent();
		}

		private void Notificaciones_Load(object sender, EventArgs e) {
			notificaciones = NotificacionManager.obtener(Sesion.obtenerSesion().usuario);

			lbNotificaciones.DisplayMember = "Text";
			lbNotificaciones.ValueMember = "Value";

			var items = new List<Object>();
			foreach (Notificacion notificacion in notificaciones) {
				items.Add(new ComboboxItem { Text = Sesion.obtenerSesion().idioma.textos[notificacion.texto], Value = notificacion.id });
			}

			lbNotificaciones.DataSource = items;

			NotificacionManager.leerTodas(Sesion.obtenerSesion().usuario);
		}
	}
}
