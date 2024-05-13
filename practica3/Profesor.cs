using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Profesor : Persona, Observado
	{
		private int antiguedad;
		private StrategyComparacion strategy;
		private List<Observador>alumnos;
		
		public Profesor(){
			this.strategy = new StrategyComparacionAntiguedad();
			this.alumnos = new List<Observador>();
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
		
		public List<Observador> getAlumnos(){
			return this.alumnos;
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

		public void hablarALaClase(){
			Console.WriteLine("Profe: " + this.nombre + " Hablando de algún tema");
			this.notificar("hablar");
		}
		
		public void escribirEnElPizarron() {
			Console.WriteLine("Profe: " + this.nombre + " Escribiendo en el pizarrón");
			this.notificar("escribir");
		}
		
		#region Observado implementation
		public void agregarObservador(Observador observador)
		{
			this.alumnos.Add(observador);
		}
		
		public void quitarObservador(Observador observador)
		{
			this.alumnos.Remove(observador);
		}
		
		public void notificar(String accion)
		{
			foreach (Observador alumno in this.alumnos) {
				alumno.actualizar(accion);
			}
		}
		#endregion
	}
}
