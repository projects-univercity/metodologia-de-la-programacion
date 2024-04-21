using System;

namespace Practicas
{
	
	public class StrategyComparacionNombre: StrategyComparacion{
		
		public StrategyComparacionNombre(){
		}
		
		#region StrategyComparacionNombre implementation
		
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			String thisName = ((Alumno)thisComparable).getNombre();
			//String name = ((Alumno)comparable).getNombre();
			return thisName.Equals("");
		}
		
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getNombre().Length < ((Alumno)comparable).getNombre().Length;
		}
		
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getNombre().Length > ((Alumno)comparable).getNombre().Length;
		}
		#endregion
	}
}
