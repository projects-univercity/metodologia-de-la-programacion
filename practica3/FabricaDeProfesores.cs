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
			profesor.setNombre(GeneradorDeDatos.stringAleatorio(7));
			profesor.setDni(GeneradorDeDatos.numeroAleatorio(99999999));
			profesor.setAntiguedad(GeneradorDeDatos.numeroAleatorio(30));
			return profesor;
		}

		public override Comparable crearPorTeclado()
		{
			Profesor profesor = new Profesor();
			profesor.setNombre(LectorDeDatos.stringPorTeclado());
			profesor.setDni(LectorDeDatos.numeroPorTeclado());
			profesor.setAntiguedad(LectorDeDatos.numeroPorTeclado());
			return profesor;
		}

		#endregion
	}
}
