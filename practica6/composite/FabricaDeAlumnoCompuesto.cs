using System;

namespace Practicas
{
	public class FabricaDeAlumnoCompuesto : FabricaDeComparables
	{
		public FabricaDeAlumnoCompuesto()
		{
		}
		
		public override Comparable crearAleatorio()
		{
			
			AlumnoCompuesto compuesto = new AlumnoCompuesto();
			for (int i = 0; i < 5; i++) {
				compuesto.agregarAlumno(new AlumnoProxy(responsable.stringAleatorio(10)));
			}
			return compuesto;
		}
		
		public override Comparable crearPorTeclado()
		{
			AlumnoCompuesto compuesto = new AlumnoCompuesto();
			for (int i = 0; i < 5; i++) {
				compuesto.agregarAlumno(new AlumnoProxy(responsable.stringPorTeclado()));
			}
			return compuesto;
		}
		
		public override Comparable crearConLectorDeArchivo(){
			AlumnoCompuesto compuesto = new AlumnoCompuesto();
			for (int i = 0; i < 5; i++) {
				compuesto.agregarAlumno(new AlumnoProxy(responsable.stringDesdeArchivo(10)));
			}
			return compuesto;
		}
	}
}
