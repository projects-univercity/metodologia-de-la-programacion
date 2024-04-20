
using System;

namespace Practica1.Practica2
{
	
	public class StrategyComparacionPromedio: StrategyComparacion{
		
		public StrategyComparacionPromedio(){
		}
		
		#region StrategyComparacionNombre implementation
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getPromedio() < ((Alumno)comparable).getPromedio();
		}
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getPromedio() == ((Alumno)comparable).getPromedio();
		}
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getPromedio() > ((Alumno)comparable).getPromedio();
		}
		#endregion
	}
}
