using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Tarea2.Service.Logic.Validation
{
	public class ValidarEcuacionCuadratica
	{

		public bool OperadorasCorrectos(double a, double b, double c)
		{
			bool resultado = true;
			double discriminante;

			//-que "a" sea diferente de cero(0).
			//-que el discriminante sea mayor o igual que cero(0).

			discriminante = (Math.Pow(b, 2) - 4 * a * c);

			resultado = (a != 0 && discriminante <= 0 );

			return resultado;
		}

		public bool ResultadoNoEsCero(double resultado)
		{
			bool respuesta;
			if (resultado != 0)
			{
				return respuesta = false;
			}
			else
			{
				return respuesta = true;
			}

		}
	}
}