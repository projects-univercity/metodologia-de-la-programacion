using System;

namespace Practica1.Practica2
{
	
	public class StrategyComparacionLegajo: StrategyComparacion{
		
		public StrategyComparacionLegajo(){
		}
		
		#region StrategyComparacionNombre implementation
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getLegajo() < ((Alumno)comparable).getLegajo();
		}
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getLegajo() == ((Alumno)comparable).getLegajo();
		}
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getLegajo() > ((Alumno)comparable).getLegajo();
		}
		#endregion
	}
}
