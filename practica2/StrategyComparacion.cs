using System;

namespace Practica1.Practica2
{
	
	public interface StrategyComparacion
	{
		bool sosMenor(Comparable thisComparable, Comparable comparable);
		
		bool sosIgual(Comparable thisComparable, Comparable comparable);
		
		bool sosMayor(Comparable thisComparable, Comparable comparable);
	}
}
