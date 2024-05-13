using System;

namespace Practicas
{
	
	public class StrategyComparacionAntiguedad : StrategyComparacion
	{
		public StrategyComparacionAntiguedad()
		{
		}

		#region StrategyComparacion implementation

		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			return ((Profesor)thisComparable).getAntiguedad() == ((Profesor)comparable).getAntiguedad();
		}

		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Profesor)thisComparable).getAntiguedad() < ((Profesor)comparable).getAntiguedad();
		}

		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Profesor)thisComparable).getAntiguedad() > ((Profesor)comparable).getAntiguedad();
		}

		#endregion
		
		public override string ToString()
		{
			return "Comparacion por Antiguedad";
		}
	}
}
