using System;

namespace Practicas
{
	public class TestP2
	{
		public TestP2()
		{
		}
		
		public static void run(){
			Pila pilaAlumnos = new Pila();
			Cola colaAlumnos = new Cola();
			Conjunto conjuntoAlumnos = new Conjunto();
			Diccionario diccionarioAlumnos = new Diccionario();
			
			TestP1.llenarAlumnos(pilaAlumnos);
			TestP1.llenarAlumnos(colaAlumnos);
			TestP1.llenarAlumnos(conjuntoAlumnos);
			TestP1.llenarAlumnos(diccionarioAlumnos);
			
			Console.WriteLine("\n*******INFORMANDO PILA*********");
			TestP1.informarPersonas(pilaAlumnos);
			
			
			Console.WriteLine("\n*******IMPRIMIR PILA*********\n");
			imprimirElementos(pilaAlumnos);
			Console.WriteLine("\n*******IMPRIMIR COLA*********");
			imprimirElementos(colaAlumnos);
			Console.WriteLine("\n*******IMPRIMIR CONJUNTO*********");
			imprimirElementos(conjuntoAlumnos);
			Console.WriteLine("\n*******IMPRIMIR DICCIONARIO*********");
			imprimirElementos(diccionarioAlumnos);
			
			Console.WriteLine("\n*******CAMBIANDO STRATEGY*********");
			cambiarEstrategia(pilaAlumnos, new StrategyComparacionLegajo());
			Console.WriteLine("*******IMPRIMIR CAMBIO DE STRATEGY*********");
			imprimirElementos(pilaAlumnos);
			
			Console.WriteLine("\n*******CAMBIANDO STRATEGY*********");
			cambiarEstrategia(pilaAlumnos, new StrategyComparacionDni());
			Console.WriteLine("*******IMPRIMIR CAMBIO DE STRATEGY*********");
			imprimirElementos(pilaAlumnos);
			
			Console.WriteLine("\n*******CAMBIANDO STRATEGY*********");
			cambiarEstrategia(pilaAlumnos, new StrategyComparacionPromedio());
			Console.WriteLine("*******IMPRIMIR CAMBIO DE STRATEGY*********");
			imprimirElementos(pilaAlumnos);
		}
		
		public static void imprimirElementos (Coleccionable coleccionable){
			Iterador iterador = coleccionable.CrearIterador();
			iterador.Actual();
			while(!iterador.Fin()){
				Console.WriteLine(iterador.Actual().ToString());
				iterador.Siguiente();
			}
			
		}

		public static void cambiarEstrategia (Coleccionable coleccionable, StrategyComparacion strategy)
		{
			Iterador iterador = coleccionable.CrearIterador();
			iterador.Primero();
			while(!iterador.Fin()){
				((Alumno)iterador.Actual()).setStrategyComparacion(strategy);
				iterador.Siguiente();
			}
			//para todos los elementos elem del coleccionable
			//elem.setEstrategia(elem)
		}


		
		
	}
}
