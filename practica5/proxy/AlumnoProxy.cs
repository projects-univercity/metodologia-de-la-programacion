using System;

namespace Practicas
{
	public class AlumnoProxy : AlumnoAdapter, IAlumnoProxy
	{
		private String nombre;
		
		
		public AlumnoProxy(String nombre)
		{
			this.nombre = nombre;
			Console.WriteLine("Creando 'AlumnoProxy' con nombre " + this.nombre);
			Console.WriteLine("Alumno es null? " + (base.alumno == null));
		}
		
		public string getNombre()
		{
			Console.WriteLine("'getNombre()' desde el 'AlumnoProxy'");
			return this.nombre;
		}
		
		#region IAlumnoProxy implementation
		public int responderPregunta(int pregunta)
		{
			if(alumno == null) {
				base.alumno = (Alumno)FabricaDeComparables.crearAleatorio(2);
				Console.WriteLine("Se crea 'Alumno' desde AlumnoProxy al pedir responder pregunta ya que es Null");
			}
			Console.WriteLine("responder pregunta detro del Proxy");
			return alumno.responderPregunta(pregunta);
		}
		#endregion
	}
}
