using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Negocio
{
    public class UsuarioPropuestoDao : ConnectionDao
    {
		public UsuarioPropuesto castDto(SqlDataReader data)
		{
			UsuarioPropuesto result = new UsuarioPropuesto();
			result.id = Convert.ToInt32(data["id"]);
			result.nombreUsuario = data["nombre_usuario"].ToString();
			result.nombre = data["nombre"].ToString();
			result.apellido = data["apellido"].ToString();
			result.mail = data["mail"].ToString();

			return result;
		}
	}
}
