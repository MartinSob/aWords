using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Security;

namespace Tests
{
	[TestClass]
	public class LoginTest
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
		public void TestLoginTrue() {
			var login = SesionManager.iniciarSesion("testCase", "testCase");

			Assert.AreEqual(login, true);
		}
	}
}
