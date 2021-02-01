using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Security;

namespace Tests
{
	[TestClass]
	public class ReconocimientoTest
	{
		Usuario reconocedor;
		Usuario reconocido;
		Emblema emblem;

		[ClassInitialize]
		public static void ReconocimientoTestInitialize(TestContext context) {
			DbDependency.CreateDB();
		}

		[ClassCleanup]
		public static void ReconocimientoTestCleanup() {
			DbDependency.DropDB();
		}

		[TestMethod]
		public void TestCrearReconocimiento() {
			reconocedor = UsuarioManager.obtener(1);
			reconocido = UsuarioManager.obtener(2);
			emblem = EmblemaManager.obtener(1)[0];

			int recoId = ReconocimientoManager.crear(new Reconocimiento {
				reconocedor = this.reconocedor,
				reconocido = this.reconocido,
				descripcion = "DescriptionTest",
				emblema = emblem
			});

			var r1 = ReconocimientoManager.obtener(recoId);
			Assert.IsNotNull(r1);
		}
	}
}
