using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PAW.Tarea2.Test
{
	[TestClass]
	public class EcuacionCuadraticaTesting
	{
		[TestMethod]
		public void primeraRaizAZero()
		{
			var testA = 0.0;
			var testB = 5.0;
			var testC = 10.0;
			var testExpected = 0.0;
			var testResult = 0.0;

			var elServicio = new Service.Service1();
			testResult = elServicio.PrimeraRaiz(testA, testB, testC);

			Assert.AreEqual(testResult, testExpected);
			
		}

		[TestMethod]
		public void primeraRaizBaseDiscriminanteNegativo()
		{

			var testA = -5.0;
			var testB = 5.0;
			var testC = 3.0;
			var testExpected = 0.0;
			var testResult = 0.0;

			var elServicio = new Service.Service1();
			testResult = elServicio.PrimeraRaiz(testA, testB, testC);

			Assert.AreEqual(testResult, testExpected);

		}

		[TestMethod]
		public void segundaRaizAZero()
		{

			var testA = 0.0;
			var testB = 5.0;
			var testC = 10.0;
			var testExpected = 0.0;
			var testResult = 0.0;

			var elServicio = new Service.Service1();
			testResult = elServicio.PrimeraRaiz(testA, testB, testC);

			Assert.AreEqual(testResult, testExpected);

		}

		[TestMethod]
		public void segundaRaizBaseDiscriminanteNegativo()
		{

			var testA = -5.0;
			var testB = 5.0;
			var testC = 3.0;
			var testExpected = 0.0;
			var testResult = 0.0;

			var elServicio = new Service.Service1();
			testResult = elServicio.PrimeraRaiz(testA, testB, testC);

			Assert.AreEqual(testResult, testExpected);

		}

	}
}
