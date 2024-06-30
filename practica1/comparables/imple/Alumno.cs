using System;

namespace Practicas
{

	public class Alumno : Persona , Observador, IAlumno {
		
		private double legajo;
		private double promedio;
		private StrategyComparacion strategyComparacion = new StrategyComparacionNombre();
		private int calificacion;
		
		public Alumno()
		{
			this.strategyComparacion = new StrategyComparacionNombre();
		}
		
		public Alumno(String nombre, double dni, double legajo, double promedio): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			//this.strategyComparacion = new StrategyComparacionNombre();
		}
		
		public Alumno(String nombre, int dni, int legajo, double promedio, int calificacion): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
			this.calificacion = calificacion;
			//this.strategyComparacion = new StrategyComparacionNombre();
		}
		
		public StrategyComparacion getStrategyComparacion(){
			return this.strategyComparacion;
		}
		
		public void setStrategyComparacion(StrategyComparacion strategy){
			this.strategyComparacion = strategy;
		}
		
		// disable once ConvertToAutoProperty
		public double getLegajo() {
			return this.legajo;
		}
		public void setLegajo(double legajo) {
			this.legajo = legajo;
		}

		
		// disable once ConvertToAutoProperty
		public double getPromedio(){
			return this.promedio;
		}
		public void setPromedio(double promedio){
			this.promedio = promedio;
		}
		
		public int getCalificacion(){
			return this.calificacion;
		}
		public void setCalificacion(int calificacion){
			this.calificacion = calificacion;
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
			GeneradorDeDatos generador = new GeneradorDeDatos(null);
			int numero = generador.numeroAleatorio(3)+1;
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
		
		
					//Práctica 4. Ejercicio 1.
		/**
		 * devuelve un número al azar entre 1 y 3 como respuesta (simulando un multiple choice)
		 */
		public virtual int responderPregunta(int pregunta){
			//Console.WriteLine("responder pregunta detro del Alumno");
			
			GeneradorDeDatos generadorDeDatos = new GeneradorDeDatos();
			return generadorDeDatos.numeroAleatorio(1, 3);
		}
		
		/**
		 * Devuelve un string con el nombre y apellido del alumno junto con la última calificación obtenida
		 */
		public string mostrarCalificacion()
		{
			return String.Format("{0} {1}", this.nombre, this.calificacion);
		}

		
	}

}

