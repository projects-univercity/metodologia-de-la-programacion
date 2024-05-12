using System;

namespace Practicas
{
	
	public class TestP3
	{
		public TestP3()
		{
		}
		
		public static void run(){
			//Console.WriteLine(GeneradorDeDatos.numeroAleatorio(10));
			//Console.WriteLine(GeneradorDeDatos.numeroAleatorio(10));
			//Console.WriteLine(GeneradorDeDatos.stringAleatorio(10));
			//Console.WriteLine(GeneradorDeDatos.stringAleatorio(10));
			
			//Comparable comparable = FabricaDeComparables.crearAleatorio(1);

			//Console.WriteLine(comparable);
			
			//Console.WriteLine("******COLA DE NUMEROS CON FACTORY METHOD********");
			//Pila pila = new Pila();
			//TestP1.llenar(pila, 1);
			//TestP1.informar(pila, 1);
			
			
			Console.WriteLine("******PILA DE PROFESORES CON FACTORY METHOD********");
			Cola cola = new Cola();
			TestP1.llenar(cola, 2);
			TestP1.informar(cola, 2);
			
		}
		
		
		
		
	}
}
