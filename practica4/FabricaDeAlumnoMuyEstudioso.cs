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
					responsable.stringAleatorio(6),
					responsable.numeroAleatorio(99999999),
					responsable.numeroAleatorio(99999999),
					responsable.numeroAleatorio(10)
				);
			return alumno;
		}
		
		public override Comparable crearPorTeclado()
		{
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso();
			alumno.setNombre(responsable.stringPorTeclado());
			alumno.setDni(responsable.numeroPorTeclado());
			alumno.setLegajo(responsable.numeroPorTeclado());
			alumno.setPromedio(responsable.numeroPorTeclado());
			return alumno;
		}
		
		public override Comparable crearConLectorDeArchivo(){
			AlumnoMuyEstudioso alumno = new AlumnoMuyEstudioso();
			alumno.setNombre(responsable.stringDesdeArchivo(5));
			alumno.setDni(responsable.numeroDesdeArchivo(5));
			alumno.setLegajo(responsable.numeroDesdeArchivo(5));
			alumno.setPromedio(responsable.numeroDesdeArchivo(5));
			return alumno;
		}
		#endregion		
	}
}
