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
			//testProxy();
			testCommand();
			
		}
		
		public static void testProxy(){
			IAlumnoProxy alumnoProxy = new AlumnoProxy("David");
			alumnoProxy.responderPregunta(1);
			
			Teacher teacher = new Teacher();
			teacher.goToClass((Student)alumnoProxy);
			
			teacher.teachingAClass();
			
			Teacher profe = new Teacher();
			
			//for (int i = 0; i < 10; i++) {
				//AlumnoProxy proxy = new AlumnoProxy("David");
				//ACA CREAR EL PROXY DE ALUMNO, SE DELEGA LA CREACION DEL ALUMNO AL ALUMNOPROXY
				//profe.goToClass();
			//}
		}
		
		public static void testCommand(){
			Aula aula = new Aula();
			
			//Pila coleccion = new Pila();
			//Cola coleccion = new Cola();
			Conjunto coleccion = new Conjunto();
			
			coleccion.setOrdenInicio(new OrdenInicio(aula));
			coleccion.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			coleccion.setOrdenAulaLlena(new OrdenAulaLlena(aula));
			
			TestP1.llenar(coleccion, 2);
			
			TestP1.llenar(coleccion, 4);
			
		}
	}
}
