﻿using System;

namespace Practicas
{

	public interface IOrdenable
	{
		void setOrdenInicio(IOrdenEnAula1 orden);
		
		void setOrdenLlegaAlumno(IOrdenEnAula2 orden);
		
		void setOrdenAulaLlena(IOrdenEnAula1 orden);
	}
}