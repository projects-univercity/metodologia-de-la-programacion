﻿using System;

namespace Practica1.Practica2
{
	
	public class StrategyComparacionNombre: StrategyComparacion{
		
		public StrategyComparacionNombre(){
		}
		
		#region StrategyComparacionNombre implementation
		public bool sosMenor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getNombre().CompareTo(((Alumno)comparable).getNombre()) == 0;
		}
		public bool sosIgual(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getNombre() == ((Alumno)comparable).getNombre();
		}
		public bool sosMayor(Comparable thisComparable, Comparable comparable)
		{
			return ((Alumno)thisComparable).getNombre().Length > ((Alumno)comparable).getNombre().Length;
		}
		#endregion
	}
}
