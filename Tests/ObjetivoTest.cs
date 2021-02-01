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
	public class ObjetivoTest
	{
		[ClassInitialize]
		public static void ReconocimientoTestInitialize(TestContext context) {
			DbDependency.CreateDB();
		}

		[ClassCleanup]
		public static void ReconocimientoTestCleanup() {
			DbDependency.DropDB();
		}

		[TestMethod]
		public void TestObjetivoFlow() {
			Objetivo objetivo = new Objetivo();
			int objId;

			Objetivo newObjetivo = new Objetivo {
				descripcion = "description",
				nivelIssue = 1,
				fechaCerrarAntesDe = DateTime.Now,
				sector = new Sector() { id = 1 }
			};

			objId = TestCreation(newObjetivo);

			TestFinalize(objId, objetivo);

			TestArchive(objId, objetivo);
		}

		public int TestCreation(Objetivo o) {
			int objId = ObjetivoManager.crear(o);

			Assert.AreNotEqual(objId, 0);

			return objId;
		}

		public void TestFinalize(int id, Objetivo objetivo) {
			ObjetivoManager.finalizar(new Objetivo {
				id = id
			});

			objetivo = ObjetivoManager.obtener(id);
			Assert.AreNotEqual(objetivo.fechaFin, null);
		}

		public void TestArchive(int id, Objetivo objetivo) {
			ObjetivoManager.archivar(new Objetivo {
				id = id
			});

			objetivo = ObjetivoManager.obtener(id);
			Assert.IsTrue(objetivo.archivado);
		}
	}
}
