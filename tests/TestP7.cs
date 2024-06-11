using System;

namespace Practicas
{
	public class TestP7
	{
		public TestP7()
		{
		}
		
		public static void run(){
			//testChainOfResponsability();
			TestP5.testProxyConCompsiteConTemplateMethod();
		}
		
		public static void testChainOfResponsability(){
			Manejador generador = GeneradorDeDatos.getInstancia();
			Manejador lector = new LectorDeDatos(generador);
			Manejador lectorArchivo = LectorDeArchivos.getInstacia(lector);
			
			FabricaDeComparables.responsable = lectorArchivo;
			
			
			Comparable num1 = FabricaDeComparables.crearConLectorDeArchivo(1);
			Console.WriteLine(num1);
			
			Comparable num2 = FabricaDeComparables.crearAleatorio(1);
			Console.WriteLine(num2);
			
			Comparable num3 = FabricaDeComparables.crearPorTeclado(1);
			Console.WriteLine(num3);
		}
	}
}
