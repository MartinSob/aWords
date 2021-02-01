using BusinessEntity;
using Security;
using System;
using System.Collections.Generic;

namespace Presentacion {
	public partial class BitacoreTable : UpdatableForm {
		
		public BitacoreTable() {
			InitializeComponent();
			Sesion.obtenerSesion().idioma.forms.Add(this);
		}

		private void BitacoreTable_Load(object sender, EventArgs e) {
			this.allControls = Program.GetAllControls(this);
			allControls.Add(lblTipo);

			IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

			updateGrid();

			messageDetail.DocumentText = "";
		}

		public override void actulizarTextos() {
			base.actulizarTextos();
			updateGrid();
		}

		private void updateGrid() {
			gridBitacora.Columns.Clear();

			gridBitacora.Columns.Add("Fecha", Sesion.obtenerSesion().idioma.textos["date"]);
			gridBitacora.Columns.Add("Titulo", Sesion.obtenerSesion().idioma.textos["title"]);
			gridBitacora.Columns.Add("Descripcion", Sesion.obtenerSesion().idioma.textos["description"]);
			gridBitacora.Columns.Add("Tipo", Sesion.obtenerSesion().idioma.textos["type"]);
			gridBitacora.Columns.Add("Nombre de usuario", Sesion.obtenerSesion().idioma.textos["username"]);

            var filter = string.IsNullOrEmpty(txtTipo.Text) ? null : txtTipo.Text;

            List<BitacoraMensaje> mensajes = BitacoraManager.obtener(dateFrom.Value, dateTo.Value, filter);

            if (mensajes == null) {
                return;
            }

			foreach (BitacoraMensaje msg in mensajes) {
				var userName = msg.usuario.id != 0 ? UsuarioManager.obtener(msg.usuario.id).NombreCompleto : "";

				gridBitacora.Rows.Add(msg.fecha, msg.titulo, msg.descripcion, msg.tipo, userName);
			}
		}

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

		private void gridBitacora_SelectionChanged(object sender, EventArgs e) {
			if (messageDetail.Document != null && ((MetroFramework.Controls.MetroGrid)sender).SelectedRows.Count > 0) {
				var code = BitacoraManager.FormatJson(((MetroFramework.Controls.MetroGrid)sender).SelectedRows[0].Cells[2].Value.ToString());
				messageDetail.Document.Body.InnerHtml = "<pre><code>" + code + "</code></pre>";
			}
		}
	}
}
