using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PAW.Tarea2.Service.Logic.Specification
{
	public class EcuacionCuadratica
	{
		/// <summary>
		/// La función regresa el valor de la primera raíz en la ecuacion cuadratica
		/// </summary>
		/// <param name="a">El valor para a</param>
		/// <param name="b">El valor para b</param>
		/// <param name="c">El valor para c</param>
		/// <returns>Resultado de la primera raíz X1</returns>
		public double SolucionX1(double a, double b, double c)
		{
			var Accion = new Logic.Action.EcuacionCuadratica();
			double resultado = Accion.SolucionarEcuacionX1(a,b,c);
			return resultado;
		}

		/// <summary>
		/// La función regresa el valor de la segunda raíz en la ecuacion cuadratica
		/// </summary>
		/// <param name="a">El valor para a</param>
		/// <param name="b">El valor para b</param>
		/// <param name="c">El valor para c</param>
		/// <returns>Resultado de la segunda raíz X2</returns>
		public double SolucionX2(double a, double b, double c)
		{
			var Accion = new Logic.Action.EcuacionCuadratica();
			double resultado = Accion.SolucionarEcuacionX2(a, b, c);
			return resultado;
		}
	}
}