using System;

namespace Practicas
{

	public class FabricaDeAlumnos : FabricaDeComparables
	{
		public FabricaDeAlumnos()
		{
		}

		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			Alumno alumno = new Alumno(
					GeneradorDeDatos.stringAleatorio(6),
					GeneradorDeDatos.numeroAleatorio(99999999),
					GeneradorDeDatos.numeroAleatorio(99999999),
					GeneradorDeDatos.numeroAleatorio(10)
			);
			/*alumno.setNombre(GeneradorDeDatos.stringAleatorio(6));
			alumno.setDni(GeneradorDeDatos.numeroAleatorio(99999999));
			alumno.setPromedio(GeneradorDeDatos.numeroAleatorio(10));
			alumno.setLegajo(GeneradorDeDatos.numeroAleatorio(99999999));*/
			return alumno;
		}
		
		public override Comparable crearPorTeclado()
		{
			Alumno alumno = new Alumno();
			alumno.setNombre(LectorDeDatos.stringPorTeclado());
			alumno.setDni(LectorDeDatos.numeroPorTeclado());
			alumno.setPromedio(LectorDeDatos.numeroPorTeclado());
			alumno.setLegajo(LectorDeDatos.numeroPorTeclado());
			return alumno;
		}
		#endregion		
		
	}
}
