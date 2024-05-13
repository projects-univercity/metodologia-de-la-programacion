using System;

namespace Practicas
{
	
	public class TestP3
	{
		public TestP3()
		{
		}
		
		public static void run(){
			Console.WriteLine("*******LLAMANDO la Class 'GeneradorDeDatos*******");
			Console.WriteLine(GeneradorDeDatos.numeroAleatorio(10));
			Console.WriteLine(GeneradorDeDatos.numeroAleatorio(10));
			Console.WriteLine(GeneradorDeDatos.stringAleatorio(10));
			Console.WriteLine(GeneradorDeDatos.stringAleatorio(10));
			
			Console.WriteLine("*******CREANDO UN NUMERO CON LA FABRICA**********");
			Comparable comparable = FabricaDeComparables.crearAleatorio(1);
			Console.WriteLine(comparable);
			
			Console.WriteLine("******COLA DE NUMEROS CON FACTORY METHOD********");
			Pila pilaNumeros = new Pila();
			TestP1.llenar(pilaNumeros, 1);
			TestP1.informar(pilaNumeros, 1);
			
			
			Console.WriteLine("******PILA DE PROFESORES CON FACTORY METHOD********");
			Pila pilaProfes = new Pila();
			TestP1.llenar(pilaProfes, 3);
			TestP1.informar(pilaProfes, 3);
			
			Console.WriteLine("******COLA DE PROFESORES CON FACTORY METHOD********");
			Cola colaProfes = new Cola();
			TestP1.llenar(colaProfes, 3);
			TestP1.informar(colaProfes, 3);
			
			
			Console.WriteLine("******COLECCION MULTIPLE DE PROFESORES CON FACTORY METHOD********");
			ColeccionMultiple multipleProfes =  new ColeccionMultiple(new Pila(), new Cola());
			TestP1.llenar(multipleProfes, 3);
			TestP1.informar(multipleProfes, 3);
			
		}
		
		public static void testObserver(){
			FabricaDeComparables fabricaA = new FabricaDeAlumnos();
			FabricaDeComparables fabricaP = new FabricaDeProfesores();
			
			Alumno alumno1 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno2 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno3 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno4 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno5 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno6 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno7 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno8 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno9 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno10 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno11 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno12 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno13 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno14 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno15 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno16 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno17 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno18 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno19 = (Alumno)fabricaA.crearAleatorio();
			Alumno alumno20 = (Alumno)fabricaA.crearAleatorio();
			
			Profesor profesor = (Profesor)fabricaP.crearAleatorio();
			
			profesor.agregarObservador(alumno1);
			profesor.agregarObservador(alumno2);
			profesor.agregarObservador(alumno3);
			profesor.agregarObservador(alumno4);
			profesor.agregarObservador(alumno5);
			profesor.agregarObservador(alumno6);
			profesor.agregarObservador(alumno7);
			profesor.agregarObservador(alumno8);
			profesor.agregarObservador(alumno9);
			profesor.agregarObservador(alumno10);
			profesor.agregarObservador(alumno11);
			profesor.agregarObservador(alumno12);
			profesor.agregarObservador(alumno13);
			profesor.agregarObservador(alumno14);
			profesor.agregarObservador(alumno15);
			profesor.agregarObservador(alumno16);
			profesor.agregarObservador(alumno17);
			profesor.agregarObservador(alumno18);
			profesor.agregarObservador(alumno19);
			profesor.agregarObservador(alumno20);
			
			dictadoDeClases(profesor);
			
		}
		
		public static void dictadoDeClases(Profesor profesor){
			int count = 0;
			while(count < 5){
				profesor.hablarALaClase();
				profesor.escribirEnElPizarron();
				count++;
			}
		}
		
	}
}
