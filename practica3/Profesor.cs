using System;

namespace Practicas
{
	
	public class Profesor : Persona
	{
		private int antiguedad;
		
		public Profesor(){}
		
		public Profesor(String nombre, int dni, int antiguedad) : base (nombre, dni)
		{
			this.antiguedad = antiguedad;
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		public void setAntiguedad(int antiguedad){
			this.antiguedad = antiguedad;
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algún tema");
		}
		
		public void escribirEnElPizarron() {
			Console.WriteLine("Escribiendo en el pizarrón");
		}
	}
}
