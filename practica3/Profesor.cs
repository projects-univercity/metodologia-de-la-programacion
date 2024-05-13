using System;
using Practicas.practica3;

namespace Practicas
{
	
	public class Profesor : Persona
	{
		private int antiguedad;
		private StrategyComparacion strategy;
		
		public Profesor(){
			this.strategy = new StrategyComparacionAntiguedad();
		}
		
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
		
		public StrategyComparacion getStrategyComparacion(){
			return this.strategy;
		}
		
		public void setStrategyComparacion(StrategyComparacion strategy){
			this.strategy = strategy;
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algún tema");
		}
		
		public void escribirEnElPizarron() {
			Console.WriteLine("Escribiendo en el pizarrón");
		}
		
		public override bool sosIgual(Comparable comparable){
			return strategy.sosIgual(this, comparable);
		}
		
		public override bool sosMenor(Comparable comparable){
			return strategy.sosMenor(this, comparable);
		}
		
		public override bool sosMayor(Comparable comparable){
			return strategy.sosMayor(this, comparable);
		}
		
		public override string ToString()
		{
			return string.Format("[Profesor Antiguedad={0}, Strategy={1}]", antiguedad, strategy);
		}

	}
}
