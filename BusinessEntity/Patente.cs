namespace BusinessEntity {
	public class Patente : Permiso{
		
		public override bool tienePermiso(string permiso) {
			return this.nombre.Equals(permiso);
		}
	}
}
