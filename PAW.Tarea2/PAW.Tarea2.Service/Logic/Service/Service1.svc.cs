using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PAW.Tarea2.Service
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
	// NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class Service1 : IService1
	{
        public double X1(double a, double b, double c)
        {
			Logic.Specification.EcuacionCuadratica laEspecificacion;
			laEspecificacion = new Logic.Specification.EcuacionCuadratica();
			var resultX1 = laEspecificacion.SolucionX1(a, b, c);
			return resultX1;
        }
		public double X2(double a, double b, double c)
		{
			Logic.Specification.EcuacionCuadratica laEspecificacion;
			laEspecificacion = new Logic.Specification.EcuacionCuadratica();
			var resultX2 = laEspecificacion.SolucionX2(a, b, c);
			return resultX2;
		}

		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}

		public double datos(double a, double b, double c)
		{
			throw new NotImplementedException();
		}
	}
}
