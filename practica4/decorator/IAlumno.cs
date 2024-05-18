using System;

namespace Practicas
{
	public interface IAlumno
	{
		string getNombre();
		
		double getPromedio();
		
		int getLegajo();
		
		int getCalificacion();
		
		string mostrarCalificacion();
		
		int responderPregunta(int pregunta);
	}
}
