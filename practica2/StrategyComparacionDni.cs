using System;

namespace Practicas
{
	
	public class StrategyComparacionDni: StrategyComparacion{
		
		public StrategyComparacionDni(){
		}
		
		#region StrategyComparacionNombre implementation
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getDni() < ((Alumno)comparable).getDni();
		}
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getDni() == ((Alumno)comparable).getDni();
		}
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getDni() > ((Alumno)comparable).getDni();
		}
		#endregion
	}
}
