using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public class Conjunto : ColeccionOrdenable, Coleccionable
	{
		List<Comparable> comparables;
		const int limite = 16;
		
		public Conjunto()
		{
			this.comparables = new List<Comparable>();
		}
		
		public Conjunto(IOrdenEnAula1 orden1, IOrdenEnAula2 orden2, IOrdenEnAula1 orden3 ) 
			: base (orden1, orden2, orden3) {
			this.comparables = new List<Comparable>();
		}
		
		public List<Comparable> getListClaveValor(){
			return this.comparables;
		}
		
		public bool pertenece(Comparable comparable){
			foreach(Comparable elem in this.comparables){
				if(elem.sosIgual(comparable))
					return true;
			}
			return false;
		}
		
		#region Coleccionable implementation
		
		public int cuantos()
		{
			return this.comparables.Count;
		}
		
		public Comparable minimo()
		{
			Comparable numeroMin = null;
			if(comparables.Count == 0)
				return numeroMin;
			numeroMin = this.comparables[0];
			for (int i = 1; i < this.comparables.Count; i++) {
				if(comparables[i].sosMenor(numeroMin))
					numeroMin = comparables[i];
			}
			return numeroMin;
		}
		
		public Comparable maximo()
		{
			Comparable numeroMax = null;
			if(comparables.Count == 0)
				return numeroMax;
			numeroMax = comparables[0];
			for (int i = 1; i < this.comparables.Count; i++) {
				if(comparables[i].sosMayor(numeroMax))
					numeroMax = comparables[i];
			}
			return numeroMax;
		}
		
		public void agregar(Comparable comparable)
		{
			if(this.cuantos() >= limite) 
				return;
			
			if(!this.pertenece(comparable)){
				//Ejecutar orden 1 (si la lista esta vacia crear un Teacher en el Aula)
				if(this.cuantos() == 0) {
					if(base.ordenInicio != null)
						base.ordenInicio.ejectuar();
				}
				//Ejecutar siempre la orden 2(carga Alumno en Aula)
				if(base.ordenLlega != null) {
					base.ordenLlega.ejecutar((IAlumno)comparable);
					this.comparables.Add(comparable);
				}
				//Ejecutar la orden 3 (cuando la liste se llene comienza la Clase en el Aula)
				if(this.cuantos() == limite) {
					if(base.ordenLlena != null)
						base.ordenLlena.ejectuar();
				}
			}
		}
		
		public bool contiene(Comparable comparable)
		{
			return this.pertenece(comparable);
		}
		#endregion

		#region Iterable implementation
		public Iterador CrearIterador()
		{
			throw new NotImplementedException();
		}
		#endregion
		
	}
}
