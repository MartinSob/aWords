using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence
{
    public class BitacoraDao : ConnectionDao
    {
        public int agregarMensaje(BitacoraMensaje mensaje)
        {
            string[] columns = { "fecha", "titulo", "descripcion", "tipo", "usuario_id" };
            var userId = mensaje.usuario != null ? mensaje.usuario.id : 0;
            string[] values = { DateTime.Now.ToString(), mensaje.titulo, mensaje.descripcion, mensaje.tipo.ToString(), userId.ToString() };
            return insert("bitacora", columns, values);
        }

        public List<BitacoraMensaje> obtener(DateTime desde, DateTime hasta, string tipo = null)
        {
            try
            {
                string consultaSQL = $"SELECT id, fecha, titulo, descripcion, tipo, usuario_id FROM bitacora WHERE fecha BETWEEN '{desde.ToString("yyyy-MM-dd")}' AND '{hasta.ToString("yyyy-MM-dd")}  23:59:59'";

                if (tipo != null)
                {
                    consultaSQL += $" AND tipo LIKE '%{tipo}%'";
                }

                SqlCommand query = new SqlCommand(consultaSQL, conn);
                conn.Open();
                SqlDataReader data = query.ExecuteReader();

                List<BitacoraMensaje> mensajes = new List<BitacoraMensaje>();
                while (data.Read())
                {
                    mensajes.Add(castDTO(data));
                }
                conn.Close();

                return mensajes;
            }
            catch (Exception e)
            {
                ErrorManager.agregarMensaje(e.ToString());
                return null;
            }
        }

        public BitacoraMensaje castDTO(SqlDataReader data)
        {
            BitacoraMensaje result = new BitacoraMensaje();
            result.id = Convert.ToInt32(data["id"]);
            result.fecha = Convert.ToDateTime(data["fecha"].ToString());
            result.titulo = data["titulo"].ToString();
            result.descripcion = data["descripcion"].ToString();
            switch (data["tipo"].ToString())
            {
                case "Error":
                    result.tipo = Tipo.Error;
                    break;
                case "Info":
                    result.tipo = Tipo.Info;
                    break;
                case "Warning":
                    result.tipo = Tipo.Warning;
                    break;
                case "Control":
                    result.tipo = Tipo.Control;
                    break;
                default:
                    result.tipo = Tipo.Info;
                    break;
            }
            result.usuario = new Usuario()
            {
                id = Convert.ToInt32(data["usuario_id"])
            };

            return result;
        }
    }
}
