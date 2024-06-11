using System;

namespace Practicas
{
	/**
	  * 
	  * 
	 */
	public class AlumnoProxy : IAlumno
	{
		private String nombre;
		private Alumno alumnoReal = null;
		
		/**
 		 (2) Alumno (Defauld),
		 (4) AlumnoMuyEstudioso
		 */
		private int tipoAlumno = 4;
		
		public AlumnoProxy(String nombre)
		{
			this.nombre = nombre;
			Console.WriteLine("Creando 'AlumnoProxy' con nombre " + this.nombre);
			Console.WriteLine("Alumno es null? " + (this.alumnoReal == null));
		}
		
		public void setTipoAlumno(int tipoAlumno){
			this.tipoAlumno = tipoAlumno;
		}
		
		public string getNombre()
		{
			Console.WriteLine("'getNombre()' desde el 'AlumnoProxy'");
			return this.nombre;
		}
		
		public Alumno getAlumno(){
			return this.alumnoReal;
		}

		
		#region IAlumno implementation
		public int responderPregunta(int pregunta)
		{
			if(alumnoReal == null) {
				Console.WriteLine("Alumno NULL");
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(tipoAlumno);
				alumnoReal.setNombre(this.nombre);
				Console.WriteLine("Se crea 'Alumno' desde AlumnoProxy al pedir responder pregunta ya que es Null");
			}
			Console.WriteLine("responder pregunta detro del Proxy, el alumno ya no es NULL");
			return alumnoReal.responderPregunta(pregunta);
		}
		
		public string mostrarCalificacion(){
			if(this.alumnoReal == null ){
				Console.WriteLine("Alumno NULL");
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(tipoAlumno);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.mostrarCalificacion();
		}
		
		public double getPromedio()
		{
			if(this.alumnoReal == null ){
				Console.WriteLine("Alumno NULL");
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(tipoAlumno);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.getPromedio();
		}

		public double getLegajo()
		{
			if(this.alumnoReal == null ){
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(tipoAlumno);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.getLegajo();
		}

		public int getCalificacion()
		{
			if(this.alumnoReal == null ){
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.getCalificacion();
		}
		
		public void setCalificacion(int calificacion){
			if(this.alumnoReal == null){
				this.alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(4);
				alumnoReal.setNombre(this.nombre);
			}
			alumnoReal.setCalificacion(calificacion);
		}
		#endregion

		public bool sosIgual(Comparable comparable)
		{
			if(this.alumnoReal == null ){
				Console.WriteLine("Alumno NULL");
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.sosIgual(comparable);
		}

		public bool sosMenor(Comparable comparable)
		{
			if(this.alumnoReal == null ){
				Console.WriteLine("Alumno NULL");
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.sosMenor(comparable);
		}

		public bool sosMayor(Comparable comparable)
		{
			if(this.alumnoReal == null ){
				Console.WriteLine("Alumno NULL");
				alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
				alumnoReal.setNombre(this.nombre);
			}
			return alumnoReal.sosMayor(comparable);
		}
	}
}
