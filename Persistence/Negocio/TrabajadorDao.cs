using BusinessEntity;
using Persistence.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence {
	public partial class UsuarioDao : ConnectionDao {

		//public Dictionary<Emblema, int> obtenerEmblemasSinPremio(int userId) {
		//	try {
		//		string strQuery = "SELECT e.id as id, e.nombre as nombre, r.id as reconocimiento_id FROM reconocimientos r " +
		//			"JOIN emblemas e ON e.id = r.emblema_id " +
		//			$"WHERE r.premio_id IS null AND r.reconocido_id = {userId}";

		//		SqlCommand query = new SqlCommand(strQuery, conn);

		//		conn.Open();
		//		SqlDataReader data = query.ExecuteReader();
		//		Dictionary<Emblema, int> emblemas = new Dictionary<Emblema, int>();

		//		if (data.HasRows) {
		//			EmblemaDao emblemaDao = new EmblemaDao();
		//			while (data.Read()) {
		//				emblemas.Add(emblemaDao.castDto(data), int.Parse(data["reconocimiento_id"].ToString()));
		//			}
		//		}

		//		conn.Close();

		//		return emblemas;
		//	} catch (Exception e) {
		//		ErrorManager.agregarMensaje(e.ToString());
		//		return null;
		//	}
		//}

		//public bool agregarSector(int userId, int sectorId) {
		//	// TODO: no longer sector_id in usuarios
		//	SqlCommand query = new SqlCommand($"UPDATE usuarios SET sector_id = {sectorId} WHERE id = @id", conn);
		//	query.Parameters.AddWithValue("@id", userId);

		//	return executeQuery(query);
		//}

		public bool agregarPuesto(Usuario us) {
			SqlCommand query = new SqlCommand("UPDATE usuarios SET puesto_id = @puestoId WHERE id = @id", conn);
			query.Parameters.AddWithValue("@puestoId", us.puesto.id);
			query.Parameters.AddWithValue("@id", us.id);

			return executeQuery(query);
		}
	}
}
