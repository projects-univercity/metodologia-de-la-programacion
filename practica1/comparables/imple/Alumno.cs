using System;

namespace Practicas
{

	public class Alumno : Persona , Observador {
		
		private int legajo;
		private double promedio;
		private StrategyComparacion strategyComparacion;
		
		public Alumno()
		{
			this.strategyComparacion = new StrategyComparacionDni();
		}
		
		public Alumno(String nombre, int dni, int legajo, double promedio): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.strategyComparacion = new StrategyComparacionDni();
		}
		
		public StrategyComparacion getStrategyComparacion(){
			return this.strategyComparacion;
		}
		
		public void setStrategyComparacion(StrategyComparacion strategy){
			this.strategyComparacion = strategy;
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
			return this.strategyComparacion.sosIgual(this, comparable);
		}
		
		public override bool sosMenor(Comparable comparable)
		{
			return this.strategyComparacion.sosMenor(this, comparable);
		}

		
		public override bool sosMayor(Comparable comparable)
		{
			return this.strategyComparacion.sosMayor(this, comparable);
		}
		
		public override string ToString()
		{
			return string.Format("[Alumno Nombre={0}, Dni={1}, Legajo={2}, Promedio={3}, Strategy={4}]", 
			                     base.getNombre(), base.getDni(), this.legajo, this.promedio, this.strategyComparacion);
		}
		
		public void prestarAtencion(){
			Console.WriteLine("“Prestando atención”");
		}

		public void distraerse(){
			int numero = GeneradorDeDatos.numeroAleatorio(3)+1;
			switch(numero){
				case 1:
					Console.WriteLine("“Mirando el celular”");
					break;
				case 2:
					Console.WriteLine("“Dibujando en el margen de la carpeta”");
					break;
				case 3:
					Console.WriteLine("“Tirando aviones de papel”");
					break;
			}
			
		}
		
		#region Observador implementation
		public void actualizar(String accion)
		{
			if(accion.Equals("hablar"))
				prestarAtencion();
			else if(accion.Equals("escribir"))
				distraerse();
		}
		#endregion
	}

	

	

	
	
}

