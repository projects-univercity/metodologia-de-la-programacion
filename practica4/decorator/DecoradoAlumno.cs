using System;

namespace Practicas
{

	public abstract class DecoradoAlumno : IAlumno
	{
		protected IAlumno adicional;
		
		public DecoradoAlumno(IAlumno adicional){
			this.adicional = adicional;
		}
		
		#region IAlumno implementation
		public string getNombre()
		{
			return adicional.getNombre();
		}
		public double getPromedio()
		{
			return adicional.getPromedio();
		}
		public int getLegajo()
		{
			return adicional.getLegajo();
		}
		public int getCalificacion()
		{
			return adicional.getCalificacion();
		}
		public string mostrarCalificacion()
		{
			return adicional.mostrarCalificacion();
		}
		public int responderPregunta(int pregunta)
		{
			return adicional.responderPregunta(pregunta);
		}
		#endregion
		
	}
}
