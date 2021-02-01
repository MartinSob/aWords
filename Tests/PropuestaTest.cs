using System;
using System.Collections.Generic;
using BusinessEntity;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
	[TestClass]
	public class PropuestaTest
	{
		List<UsuarioPropuesto> usp;
		UsuarioPropuesto up;

		[TestInitialize]
		public void TestInitialize() {
			this.usp = new List<UsuarioPropuesto> {
				new UsuarioPropuesto { valorEstadistico = 1 },
				new UsuarioPropuesto { valorEstadistico = 2 },
				new UsuarioPropuesto { valorEstadistico = 5 },
				new UsuarioPropuesto { valorEstadistico = 3 },
				new UsuarioPropuesto { valorEstadistico = 4 },
			};

			this.up = new UsuarioPropuesto {
				cantidadObjetivosNoCumplidos = 1,
				cantidadReconocimientos = 2,
				promedioReconocimientosDeSuperiores = 2,
				porcentajeObjetivosCumplidos = 0.6,
				promedioDeNivelObjetivosCumplidos = 3,
				promedioNivelReconocimiento = 3,
				emblemasRecibidos = 1
			};
		}

		[TestCleanup()]
		public void Cleanup() {
			this.usp.Clear();
		}

		[TestMethod]
		public void TestOrdenarRankCount() {
			PropuestaManager.ordenarRank(usp, 2, 1);

			Assert.AreEqual(usp.Count, 2);
		}

		[TestMethod]
		public void TestOrdenarRankValor() {
			PropuestaManager.ordenarRank(usp, 2, 1);

			Assert.AreEqual(usp[0].valorEstadistico, 5);
			Assert.AreEqual(usp[1].valorEstadistico, 4);
		}

		[TestMethod]
		public void TestOrdenarRankOrden() {
			PropuestaManager.ordenarRank(usp, 2, 2);

			Assert.AreEqual(usp[0].valorEstadistico, 3);
			Assert.AreEqual(usp[1].valorEstadistico, 2);
		}

		[TestMethod]
		public void TestCalcularValorEstadisticoValorNoJefe() {
			PropuestaManager.calcularValorEstadistico(up, false, null);

			Assert.AreEqual(up.valorEstadistico, 2.1);
		}

		[TestMethod]
		public void TestCalcularValorEstadisticoValorJefe() {
			PropuestaManager.calcularValorEstadistico(up, true, null);

			Assert.AreEqual(up.valorEstadistico, 2.27);
		}
	}
}
