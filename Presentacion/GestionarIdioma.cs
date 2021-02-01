using BusinessEntity;
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

namespace Presentacion
{
    public partial class GestionarIdioma : UpdatableForm
    {
        public GestionarIdioma()
        {
            InitializeComponent();
            Sesion.obtenerSesion().idioma.forms.Add(this);
        }

        private void GestionarIdioma_Load(object sender, EventArgs e)
        {
            IdiomaManager.cambiar(Sesion.obtenerSesion().idioma, Sesion.obtenerSesion().idioma.id, this);

            cmbLanguages.DisplayMember = "Text";
            cmbLanguages.ValueMember = "Value";

            var items = new List<Object>();
            foreach (Idioma idioma in IdiomaManager.obtener())
            {
                items.Add(new ComboboxItem { Text = idioma.nombre, Value = idioma.id });
            }

            cmbLanguages.DataSource = items;
        }
    }
}
