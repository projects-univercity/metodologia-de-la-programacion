using System;

namespace Practicas
{

	public abstract class AlumnoDecorador : IAlumno
	{
		protected IAlumno adicional;
		
		public AlumnoDecorador(IAlumno adicional)
		{
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
		public double getLegajo()
		{
			return adicional.getLegajo();
		}
		public int getCalificacion()
		{
			return adicional.getCalificacion();
		}
		public virtual string mostrarCalificacion()
		{
			return adicional.mostrarCalificacion();
		}
		public int responderPregunta(int pregunta)
		{
			return adicional.responderPregunta(pregunta);
		}
		
		/**
		*  Esto es necesario para implementar ya que IAlumno debe heredar de Comparable, 
		*  para que AlumnoProxy que implementa IAlumno pueda ser comparable 
		*/
		public bool sosIgual(Comparable comparable){
			return this.adicional.sosIgual(comparable);
		}
		
		public bool sosMayor(Comparable comparable){
			return this.adicional.sosMenor(comparable);
		}
		
		public bool sosMenor(Comparable comparable){
			return this.adicional.sosMenor(comparable);
		}
		
		public void setCalificacion(int calificacion){
			this.adicional.setCalificacion(calificacion);
		}
		#endregion
		
	}
}
