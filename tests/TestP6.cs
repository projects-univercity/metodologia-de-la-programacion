using System;

namespace Practicas
{
	public class TestP6
	{
		public TestP6(){}
		
		public static void run(){
			//testCompisite();
			
			//TestP5.testProxyConCompsite();
			testTemplateMethod();
			
		}
		
		public static void testCompisite(){
			Console.WriteLine("*********COMPISITE********");
			
			AlumnoCompuesto compuesto = new AlumnoCompuesto();
			
			Alumno alumnoIgual = (Alumno)FabricaDeComparables.crearAleatorio(2);
			
			Alumno alumnoMayor = (Alumno)FabricaDeComparables.crearAleatorio(2);
			alumnoMayor.setDni(999999999);
			
			Alumno alumnoMenor = (Alumno)FabricaDeComparables.crearAleatorio(2);
			alumnoMenor.setDni(0);
			
			
			
			
			compuesto.agregarAlumno((Alumno)FabricaDeComparables.crearAleatorio(2));
			compuesto.agregarAlumno((Alumno)FabricaDeComparables.crearAleatorio(2));
			compuesto.agregarAlumno((Alumno)FabricaDeComparables.crearAleatorio(2));
			compuesto.agregarAlumno(alumnoIgual);
			compuesto.agregarAlumno((Alumno)FabricaDeComparables.crearAleatorio(2));
			
			String nombres = compuesto.getNombre();
			
			Console.WriteLine("Nombres de alumnos: " + nombres);
			
			int masRespondida = compuesto.responderPregunta(2);
			
			Console.WriteLine("mas respondida: " + masRespondida);
			
			Console.WriteLine( "Mostrar Calificaciones: " + compuesto.mostrarCalificacion());
			
			Console.WriteLine("sosIgual: " + compuesto.sosIgual(alumnoIgual));
			
			Console.WriteLine("sosMayor: " + compuesto.sosMayor(alumnoMenor));
			
			Console.WriteLine("sosMenor: " + compuesto.sosMenor(alumnoMayor));
		}
		
		public static void testTemplateMethod(){
			
			Jugador jugador1 = new Jugador("David", 1);
			Jugador jugador2 = new Jugador("Marcos", 2);
			
			JuegoDeCartas chancho = new Chancho(jugador1, jugador2);
			
			chancho.jugar();
		}
	}
}
