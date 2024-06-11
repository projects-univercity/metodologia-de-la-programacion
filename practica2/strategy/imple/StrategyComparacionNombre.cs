using System;

namespace Practicas
{
	
	public class StrategyComparacionNombre: StrategyComparacion{
		
		public StrategyComparacionNombre(){
		}
		
		#region StrategyComparacionNombre implementation
		
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			String thisName = ((IAlumno)thisComparable).getNombre();
			String name = ((IAlumno)comparable).getNombre();
			return thisName.Equals(name);
		}
		
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((IAlumno)thisComparable).getNombre().Length < ((IAlumno)comparable).getNombre().Length;
		}
		
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((IAlumno)thisComparable).getNombre().Length > ((IAlumno)comparable).getNombre().Length;
		}
		#endregion
	}
}
