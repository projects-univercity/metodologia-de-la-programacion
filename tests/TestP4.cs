using System;
using System.Collections.Generic;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class TestP4
	{
		public TestP4()
		{
		}
		
		public static void run(){
			Console.WriteLine("		PATRON ADAPTER\n");
			Teacher teacher = new Teacher();
			
			List<Alumno> alumnos = new List<Alumno>();
			
			llenarClaseConAlumnos(teacher, alumnos, 4);
			llenarClaseConAlumnos(teacher, alumnos, 2);
			
			
			
			//Dictado una clase
			teacher.teachingAClass();
			
			//Console.WriteLine("		PATRON DECORATOR\n");
			
			aplicarDecoradorCalificacionALaDeClase(alumnos);
			
			
		}
		
		/**
		* Metodo para llenar la lista de estudiantes que tiene como atributo el Teacher.
		* Se puede llenar con Alumno, alumno muy estudioso,
		 * Utilizando las FabricaDeAlumno(2) y FabricaDeAlumnoMuyEstudioso(4)
		* 
		*/ 
		public static void llenarClaseConAlumnos(Teacher teacher, List<Alumno> alumnos, int optionFabrica){
			if(optionFabrica != 2 && optionFabrica != 4)
				return;
			int contador = 0;
			
			while (contador < 8) {
				Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio(optionFabrica);
				teacher.goToClass(new AlumnoAdapter(alumno));
				alumnos.Add(alumno);
				contador++;
			}
		}
		
		/** Ejercicio 7
 		* Arme los Students con todos los decorados implementado en el ejercicio
		* anterior para que se impriman de la siguiente manera:
		****************************************************
		* 5) Ratón Pérez (12345/6) 6 (SEIS) (APROBADO) *
		****************************************************
		*/
		
		public static void decorandoCalificacion(IAlumno alumno){
			IAlumno decoradoLegajo = new DecoradoLegajo(alumno);
			IAlumno decoradoNota = new DecoradoNotaEnLetra(decoradoLegajo);
			IAlumno decoradoPromocion = new DecoradoPromocion(decoradoNota);
			IAlumno decoradoAsteriscos = new DecoradoConAsteriscos(decoradoPromocion);
			Console.WriteLine(decoradoAsteriscos.mostrarCalificacion());
		}
		
		public static void aplicarDecoradorCalificacionALaDeClase(List<Alumno> alumnos){
			foreach (Alumno alumno in alumnos) {
				decorandoCalificacion(alumno);
			}
		}
		
	}
}
