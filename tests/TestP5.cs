using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class TestP5
	{
		public TestP5()
		{
		}
		
		public static void run(){
			testProxy();
			testCommand();
		}
		
		/**
		 * Ejercicio 2
		 */
		public static void testProxy(){
			//IAlumno alumnoProxy = new AlumnoProxy("David");
			//alumnoProxy.responderPregunta(1);
			
			Teacher teacher = new Teacher();
			teacher.goToClass(new AlumnoAdapter(new AlumnoProxy("David")));
			
			teacher.teachingAClass();
			
			Teacher profe = new Teacher();
			
			for (int i = 0; i < 10; i++) {
				//ACA CREAR EL PROXY DE ALUMNO, SE DELEGA LA CREACION DEL ALUMNO AL ALUMNOPROXY
				profe.goToClass(new AlumnoAdapter(new AlumnoProxy("David" + i)));
			}
			
			Console.WriteLine("****PROXYs*****");
			profe.teachingAClass();
		}
		
		public static void testCommand(){
			Aula aula = new Aula();
			
			//Pila coleccion = new Pila();
			//Cola coleccion = new Cola();
			Conjunto coleccion = new Conjunto();
			
			coleccion.setOrdenInicio(new OrdenInicio(aula));
			coleccion.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			coleccion.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			int cuantosAlumnos = 8;
			
			TestP1.llenarPorCantidad(coleccion, 2, cuantosAlumnos);
			
			TestP1.llenarPorCantidad(coleccion, 4, cuantosAlumnos);
			
		}
		
		/**
		 * Modificacion del metodo testProxy() de esta clase para ejecutar en la [Practica:6 Ejercicio:2]
		 */
		public static void testProxyConCompsite(){
			Aula aula = new Aula();
			
			aula.comenzar();
			
			AlumnoCompuesto compuesto = (AlumnoCompuesto)FabricaDeComparables.crearAleatorio(5);
			
			aula.nuevoAlumno(compuesto);
			
			aula.claseLista();
			
		}
		
		/**
		 * Modificacion del metodo TestProxyConComposite() de esta clase para ejecutar en la [Practica:7 Ejercicio:2]
		 */
		public static void testProxyConCompsiteConTemplateMethod(){
			Aula aula = new Aula();
			
			aula.comenzar();
			
			//Responsables de generar Datos en la Cadena
			Manejador generador = new GeneradorDeDatos(null);
			Manejador lector = new LectorDeDatos(generador);
			Manejador lectorArchivo = new LectorDeArchivos(lector);
			
			//Le setteo la cadena de responsables a la Fabrica De Comparables
			FabricaDeComparables.responsable = lectorArchivo;
			
			Console.WriteLine("*******CREACION DE ALUMNO COMPUESTO*****");
			AlumnoCompuesto compuesto = (AlumnoCompuesto)FabricaDeComparables.crearConLectorDeArchivo(5);
			aula.nuevoAlumno(compuesto);
			aula.claseLista();
			
			Console.WriteLine("\n*******CREACION DE ALUMNO******");
			Alumno alu1 = (Alumno)FabricaDeComparables.crearAleatorio(2);
			Alumno alu2 = (Alumno)FabricaDeComparables.crearAleatorio(2);
			Alumno alu3 = (Alumno)FabricaDeComparables.crearAleatorio(2);
			Alumno alu4 = (Alumno)FabricaDeComparables.crearAleatorio(2);
			Alumno alu5 = (Alumno)FabricaDeComparables.crearAleatorio(2);
			Console.WriteLine(alu1 + "\n" + alu2 + "\n" + alu3 + "\n" + alu4 + "\n" + alu5);
			
			
			Console.WriteLine("*****CREACION DE ALUMNO MUY ESTUDIOSO****");
			AlumnoMuyEstudioso aluEst1 = (AlumnoMuyEstudioso)FabricaDeComparables.crearPorTeclado(4);
			AlumnoMuyEstudioso aluEst2 = (AlumnoMuyEstudioso)FabricaDeComparables.crearPorTeclado(4);
			
			Console.WriteLine(aluEst1);
			Console.WriteLine(aluEst2);
			
		}
		
	}
}
