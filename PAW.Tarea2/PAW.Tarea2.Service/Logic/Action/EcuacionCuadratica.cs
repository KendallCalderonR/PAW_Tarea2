using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Tarea2.Service.Logic.Action
{
	public class EcuacionCuadratica
	{
		//+ código de resultado con los siguientes valores
			//	- 0:  resultado exitoso
			//  - 1:  el valor de "a" es igual a cero(0).
			//  - 2:  el valor del discriminante es negativo.

		private IList<string> MiListaDeErrores = new List<string>(new string[] { });

		public IList<string> ListaDeErrores { get
			{
				return MiListaDeErrores;
			}
		}

		double x1 = 0.0, x2 = 0.0;

		internal double SolucionarEcuacionX1 (double a, double b, double c)
		{
			if(a == 0)
			{
				MiListaDeErrores.Add("Código 1: el valor de 'a' es igual a cero(0).");
			}
			var validar = new Logic.Validation.ValidarEcuacionCuadratica();
			if (validar.OperadorasCorrectos(a,b,c))
			{
				double discriminante = (Math.Pow(b, 2) - 4 * a * c);
				if (discriminante < 0)
				{
					MiListaDeErrores.Add("Código 2: el valor del discriminante es negativo.");
				}
				x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);	
			}
			return x1;
		}

		internal double SolucionarEcuacionX2(double a, double b, double c)
		{
			if (a == 0)
			{
				MiListaDeErrores.Add("Código 1: el valor de 'a' es igual a cero(0).");
			}
			var validar = new Logic.Validation.ValidarEcuacionCuadratica();
			if (validar.OperadorasCorrectos(a, b, c))
			{
				double discriminante = (Math.Pow(b, 2) - 4 * a * c);
				if (discriminante < 0)
				{
					MiListaDeErrores.Add("Código 2: el valor del discriminante es negativo.");
				}
				x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
			}
			return x2;
		}







	}
}