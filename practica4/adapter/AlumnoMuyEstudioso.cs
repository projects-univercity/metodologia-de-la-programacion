using System;

namespace Practicas
{
	
	public class AlumnoMuyEstudioso : Alumno
	{
		
		public AlumnoMuyEstudioso(){}
		
		public AlumnoMuyEstudioso(
			String nombre,
			double dni,
			double legajo,
			double promedio) : base(nombre, dni, legajo, promedio)
		{
		}
		
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta % 3;
		}

	}
}
