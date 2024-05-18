using System;

namespace Practicas
{
	
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(
			String nombre,
			int dni,
			int legajo,
			double promedio) : base(nombre, dni, legajo, promedio)
		{
		}
		
		
		public override int responderPregunta(int pregunta)
		{
			return 3;
		}

	}
}
