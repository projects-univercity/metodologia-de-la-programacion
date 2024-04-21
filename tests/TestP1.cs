using System;
using System.Collections.Generic;

namespace Practicas
{
	
	public static class TestP1
	{
	    public static void run(){
	        //Ejercicio 7
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
	        Console.WriteLine("Ejercicio 7 'Coleccion Pila y Cola'\n" +
	                          "-----------------------------------");
	        Console.BackgroundColor = ConsoleColor.Black;
	        
			Coleccionable pila = new Pila();
			
	        Coleccionable cola = new Cola();
	        llenarNumero(pila);
	        llenarNumero(cola);
	        
	        informarNumeros(pila);
	        informarNumeros(cola);
	        
	        //Ejercicio 9
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
	        Console.WriteLine("\nEjercicio 9 'Coleccion Multiple'\n" +
	                            "--------------------------------");
	        Console.BackgroundColor = ConsoleColor.Black;
	        
	        Coleccionable multiple = new ColeccionMultiple(pila, cola);
	        informarNumeros(multiple);
	        
	        //Ejercicio 13
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
	        Console.WriteLine("\nEjercicio 13 'Coleccion Personas'\n" +
	                            "---------------------------------");
	        Console.BackgroundColor = ConsoleColor.Black;
	        Coleccionable pilaPersonas = new Pila();
	        llenarPersonas(pilaPersonas);
	        informarPersonas(pilaPersonas);
	        
	        
	        //Ejercicio 17
	        Console.BackgroundColor = ConsoleColor.DarkBlue;
	        Console.WriteLine("\nEjercicio 17 'Coleccion Alumnos'\n" +
	                            "--------------------------------");
	        Console.BackgroundColor = ConsoleColor.Black;
	        Coleccionable pilaAlumnos = new Pila();
	        llenarPersonas(pilaAlumnos);
	        informarPersonas(pilaAlumnos);
	        
	    }
	    
		
	    //Ejercicio 5
		public static void llenarNumero(Coleccionable coleccionable) {
			Comparable comparable;
			for (int i = 0; i < 20; i++) {
				comparable = new Numero((int) (i*2));
				coleccionable.agregar(comparable);
			}
		}
	    
	    
	    
	    //Ejercicio6
		public static void informarNumeros(Coleccionable coleccionable) {
			
			Console.WriteLine("Cuantos: " + coleccionable.cuantos());
			
			Console.WriteLine("Minimo: " + ((Numero) coleccionable.minimo()).getValor());
			Console.WriteLine("Maximo: " + ((Numero) coleccionable.maximo()).getValor());
			
			//Console.WriteLine("Ingrese un Número");
			int valor = new Random().Next(0, 100);
			Comparable comparable = new Numero(valor);
			Boolean contiene = coleccionable.contiene(comparable);
			if (contiene) {
				Console.WriteLine("El elemento " + ((Numero) comparable).getValor() + " esta en la coleccion");
			} else {
				Console.WriteLine("El elemento " + ((Numero) comparable).getValor() + " NO esta en la coleccion");
			}
		}

		
	    
	    public static void informarPersonas(Coleccionable coleccionable) {
			
			Console.WriteLine("Cuantos: " + coleccionable.cuantos());
			
			Console.WriteLine("Minimo: " + ((Persona) coleccionable.minimo()));
			Console.WriteLine("Maximo: " + ((Persona) coleccionable.maximo()));
			
			
			Comparable comparable = new Alumno("Pepe", 0, 0, 1*1.0 );
			((Alumno)comparable).setStrategyComparacion(new StrategyComparacionNombre());
			Boolean contiene = coleccionable.contiene(comparable);
			if (contiene) {
				Console.WriteLine("El elemento " + ((Alumno) comparable) + " esta en la coleccion");
			} else {
				Console.WriteLine("El elemento " + ((Alumno) comparable) + " NO esta en la coleccion");
			}
			
		}
	    
	    //Ejercicio 12
	    public static void llenarPersonas(Coleccionable coleccionable) {

			Comparable comparable;
			for (int i = 0; i < 20; i++) {
				comparable = new Persona(nombre(i), new Random().Next(1, 99999999));
				coleccionable.agregar(comparable);
			}
		}

	    //Ejercicio 16
	    public static void llenarAlumnos(Coleccionable coleccionable) {
			Comparable comparable;
			
			for (int i = 0; i < 20; i++) {
				//comparable = new Alumno(nombre(), new Random().Next(0, 100), new Random().Next(1, 9999), new Random().Next(1, 10));
				comparable = new Alumno(nombre(i), i, i, i*1.0 );
				((Alumno)comparable).setStrategyComparacion(new StrategyComparacionNombre());
				coleccionable.agregar(comparable);
			}
		}
		
	    
	    public static string nombre(int pos){
			List<String> nombres = new List<string>();
			nombres.Add("Juan");
			nombres.Add("Raul");
			nombres.Add("Romina");
			nombres.Add("Luis");
			nombres.Add("Miguel");
			nombres.Add("David");
			nombres.Add("Roberto");
			nombres.Add("Ana");
			nombres.Add("Alejandro");
			nombres.Add("Yesica");
			nombres.Add("Ramon");
			nombres.Add("Osiris");
			nombres.Add("Cesar");
			nombres.Add("Julio");
			nombres.Add("Lucia");
			nombres.Add("Jazmin");
			nombres.Add("Graciela");
			nombres.Add("Gabriela");
			nombres.Add("Micaela Roldan");
			nombres.Add("Juana");
			return nombres[pos];
		}
	}
}
