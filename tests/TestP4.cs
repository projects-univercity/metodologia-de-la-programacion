using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class TestP4
	{
		public TestP4()
		{
		}
		
		public static void run(){
			/*Teacher teacher = new Teacher();
			
			int contador1 = 0;
			while (contador1 < 10) {
				teacher.goToClass(new AlumnoAdapter(
					new Alumno(
						GeneradorDeDatos.stringAleatorio(10), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(10)
						)
					)
				);
				contador1++;
			}
			
			int contador2 = 0;
			while (contador2 < 10) {
				teacher.goToClass(new AlumnoAdapter(
					new AlumnoMuyEstudioso(
						GeneradorDeDatos.stringAleatorio(10), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(10)
						)
					)
				);
				contador2++;
			}
			
			teacher.teachingAClass();*/
			
			
			Console.WriteLine("***************PATRON DECORATOR**********************");
			Alumno alumno = new Alumno(
						GeneradorDeDatos.stringAleatorio(10), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(99999999), 
						GeneradorDeDatos.numeroAleatorio(10)
					);
			alumno.setCalificacion(8);
			
			DecoradoLegajo decorado = new DecoradoLegajo(alumno);
			
			Console.WriteLine(decorado.mostrarCalificacion());
			
		}
		
		
	
		
	}
}
