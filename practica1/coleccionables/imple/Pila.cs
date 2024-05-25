using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Pila : ColeccionOrdenable, Coleccionable 
	{
		List<Comparable> comparables = new List<Comparable>();
		
		//IOrdenEnAula1 ordenInicio, ordenLlena;
		//IOrdenEnAula2 ordenLlega;
		
		public Pila(){
		}
		
		public Pila(IOrdenEnAula1 orden1, IOrdenEnAula2 orden2, IOrdenEnAula1 orden3 ) 
			: base (orden1, orden2, orden3) {
		}
		
		public List<Comparable> getComparables(){
			return this.comparables;
		}
		
		public void agregar(Comparable comparable)
		{
			//Ejecutar orden 1 (si la lista esta vacia crear un Teacher en el Aula)
			if(this.cuantos() == 0) {
				if(base.ordenInicio != null)
					base.ordenInicio.ejectuar();
			}
			
			//Ejecutar siempre la orden 2(carga Alumno en Aula)
			if(base.ordenLlega != null && this.cuantos() <= 40) {
				base.ordenLlega.ejecutar((Alumno)comparable);
				this.apilar(comparable);
			}
			
			//Ejecutar la orden 3 (cuando la liste se llene comienza la Clase en el Aula)
			if(this.cuantos() == 40) {
				if(base.ordenLlena != null)
					base.ordenLlena.ejectuar();
			}
		}

		public void apilar(Comparable comparable){
			this.comparables.Add(comparable);
		}

		public Comparable desapilar(){
			if(this.comparables.Count == 0){
				return null;
			}
			Comparable comparable = this.comparables[this.comparables.Count -1];
			this.comparables.RemoveAt(this.comparables.Count -1);
			return comparable;
		}
		
		

		public bool contiene(Comparable comparable){
			// disable once LocalVariableHidesMember
			foreach (var element in this.comparables){
				if(element.sosIgual(comparable)){
					return true;
				}
			}
			return false;
		}

		public int cuantos(){
			return this.comparables.Count;
		}

		public Comparable maximo(){
			if(this.comparables.Count == 0)	return null;

			Comparable maximo = this.comparables[0];
			for (int i = 1; i < this.comparables.Count; i++)
			{
				if (!maximo.sosMayor(this.comparables[i]))
					maximo = this.comparables[i];
			}
			return maximo;
		}

		public Comparable minimo()
		{
			if(this.comparables.Count == 0) return null;

			Comparable minimo = this.comparables[0];
			for (int i = 1; i < this.comparables.Count; i++)
			{
				if (!minimo.sosMenor(this.comparables[i]))
					minimo = this.comparables[i];
			}
			return minimo;
		}
		
		
		public Iterador CrearIterador()
		{
			return new IteradorDePila(this);
		}

		/*public void setOrdenInicio(IOrdenEnAula1 ordenInicio)
		{
			this.ordenInicio = ordenInicio;
		}

		public void setOrdenLlegaAlumno(IOrdenEnAula2 ordenLlega)
		{
			this.ordenLlega = ordenLlega;
		}

		public void setOrdenAulaLlena(IOrdenEnAula1 ordenLlena)
		{
			this.ordenLlena = ordenLlena;
		}*/
	}
}
