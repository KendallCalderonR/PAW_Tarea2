using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Tarea2.Service.Logic.Action
{
	public class EcuacionCuadratica
	{

		double x1 = 0.0, x2 = 0.0;

		internal double SolucionarEcuacionX1 (double a, double b, double c)
		{
			var validar = new Logic.Validation.ValidarEcuacionCuadratica();
			if (validar.OperadorasCorrectos(a,b,c))
			{
				x1 = (-b + Math.Sqrt(Math.Pow(b,2) - 4 * a * c)) / (2 * a);	
			}

			return x1;
		}

		internal double SolucionarEcuacionX2(double a, double b, double c)
		{
			var validar = new Logic.Validation.ValidarEcuacionCuadratica();
			if (validar.OperadorasCorrectos(a, b, c))
			{
				x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
			}
			return x2;
		}







	}
}