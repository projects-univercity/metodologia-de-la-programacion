using System;

namespace Practicas
{

	public class Alumno : Persona {
		
		private int legajo;
		private double promedio;
		
		
		public Alumno(String nombre, int dni, int legajo, double promedio): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
		}
		
		// disable once ConvertToAutoProperty
		public int getLegajo() {
			return this.legajo;
		}
		public void setLegajo(int legajo) {
			this.legajo = legajo;
		}

		
		// disable once ConvertToAutoProperty
		public double getPromedio(){
			return this.promedio;
		}
		public void setPromedio(double promedio){
			this.promedio = promedio;
		}
		
		public override bool sosIgual(Comparable comparable)
		{
			return ((Alumno)comparable).getDni() == this.dni;
		}
		
		public override bool sosMenor(Comparable comparable)
		{
			return this.dni < ((Alumno)comparable).getDni();
		}

		
		public override bool sosMayor(Comparable comparable)
		{
			return this.dni > ((Alumno)comparable).getDni();
		}
		
		public override string ToString()
		{
			return base.ToString()  + string.Format(" Legajo={0}, Promedio={1}", legajo, promedio);
		}
		
		
	}

	

	

	
	
}

