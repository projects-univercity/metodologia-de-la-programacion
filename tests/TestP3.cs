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
			
			Console.WriteLine("******COLA DE NUMEROS CON FACTORY METHOD********");
			Pila cola = new Pila();
			TestP1.llenar(cola, 1);
			TestP1.informar(cola, 1);
			
			
		}
		
		
		
		
	}
}
