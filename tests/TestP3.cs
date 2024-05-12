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
			TestP1.llenar(pilaProfes, 2);
			TestP1.informar(pilaProfes, 2);
			
			Console.WriteLine("******COLA DE PROFESORES CON FACTORY METHOD********");
			Cola colaProfes = new Cola();
			TestP1.llenar(colaProfes, 2);
			TestP1.informar(colaProfes, 2);
			
			
			Console.WriteLine("******COLECCION MULTIPLE DE PROFESORES CON FACTORY METHOD********");
			ColeccionMultiple multipleProfes =  new ColeccionMultiple(new Pila(), new Cola());
			TestP1.llenar(multipleProfes, 2);
			TestP1.informar(multipleProfes, 2);
		}
		
		
		
		
	}
}
