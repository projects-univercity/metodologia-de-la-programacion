/*
 * Creado por SharpDevelop.
 * Usuario: osiri
 * Fecha: 20/4/2024
 * Hora: 06:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas
{
	
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public FabricaDeProfesores()
		{
		}
		
		#region implemented abstract members of FabricaDeComparables

		public override Comparable crearAleatorio()
		{
			Profesor profesor = new Profesor();
			profesor.setNombre(responsable.stringAleatorio(7));
			profesor.setDni(responsable.numeroAleatorio(99999999));
			profesor.setAntiguedad(responsable.numeroAleatorio(30));
			return profesor;
		}

		public override Comparable crearPorTeclado()
		{
			Profesor profesor = new Profesor();
			profesor.setNombre(responsable.stringPorTeclado());
			profesor.setDni(responsable.numeroPorTeclado());
			profesor.setAntiguedad(responsable.numeroPorTeclado());
			return profesor;
		}
		
		public override Comparable crearConLectorDeArchivo(){
			Profesor profesor = new Profesor();
			profesor.setNombre(responsable.stringDesdeArchivo(5));
			profesor.setDni((int)responsable.numeroDesdeArchivo(99999999));
			profesor.setAntiguedad((int)responsable.numeroDesdeArchivo(20));
			return profesor;
		}

		#endregion
	}
}
