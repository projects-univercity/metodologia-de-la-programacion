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
					responsable.stringAleatorio(6),
					responsable.numeroAleatorio(99999999),
					responsable.numeroAleatorio(99999999),
					responsable.numeroAleatorio(10)
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
			alumno.setNombre(responsable.stringPorTeclado());
			alumno.setDni(responsable.numeroPorTeclado());
			alumno.setPromedio(responsable.numeroPorTeclado());
			alumno.setLegajo(responsable.numeroPorTeclado());
			return alumno;
		}
		
		public override Comparable crearConLectorDeArchivo(){
			Alumno alumno = new Alumno();
			alumno.setNombre(responsable.stringDesdeArchivo(10));
			alumno.setDni((int)responsable.numeroDesdeArchivo(99999999));
			alumno.setPromedio(responsable.numeroDesdeArchivo(10));
			alumno.setLegajo((int)responsable.numeroDesdeArchivo(99999));
			return alumno;
		}
		#endregion		
		
	}
}
