using System;

namespace Practicas
{
	
	public interface StrategyComparacion
	{
		bool sosMenor(Comparable thisComparable, Comparable comparable);
		
		bool sosIgual(Comparable thisComparable, Comparable comparable);
		
		bool sosMayor(Comparable thisComparable, Comparable comparable);
	}
}
