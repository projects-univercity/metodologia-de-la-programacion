using System;

namespace Practicas
{
	/**
	 * Interface que la implementan:
	 * Patron Decorator: 
	 * 		1. Alumno 
	 *  	2. AlumnoDecorador
	 * Patron Proxy
	 *      1. Alumno
	 *      2. AlumnoProxy
	 */
	public interface IAlumno : Comparable
	{
		string getNombre();
		
		double getPromedio();
		
		double getLegajo();
		
		int getCalificacion();
		
		string mostrarCalificacion();
		
		int responderPregunta(int pregunta);
		
		void setCalificacion(int calificacion);
		
	}
}
