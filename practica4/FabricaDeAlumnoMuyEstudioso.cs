using System;

namespace Practicas
{
	public class FabricaDeAlumnoMuyEstudioso : FabricaDeComparables
	{
		public FabricaDeAlumnoMuyEstudioso()
		{
		}
		
		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			Alumno alumno = new AlumnoMuyEstudioso(
					GeneradorDeDatos.stringAleatorio(6),
					GeneradorDeDatos.numeroAleatorio(99999999),
					GeneradorDeDatos.numeroAleatorio(99999999),
					GeneradorDeDatos.numeroAleatorio(10)
				);
			return alumno;
		}
		
		public override Comparable crearPorTeclado()
		{
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso(
					LectorDeDatos.stringPorTeclado(),
					LectorDeDatos.numeroPorTeclado(),
					LectorDeDatos.numeroPorTeclado(),
					LectorDeDatos.numeroPorTeclado()
				);
			return alumno;
		}
		#endregion		
	}
}
