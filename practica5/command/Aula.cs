using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class Aula 
	{
		Teacher teacher;
		
		public Aula(){}
		
		public void comenzar(){
			this.teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno){
			if(teacher != null) {
				teacher.goToClass(new AlumnoAdapter(alumno));
				
			}
			else
				Console.WriteLine("El Teacher es null, no se invocar a 'goToClass()'");
		}
		
		public void claseLista(){
			if(teacher != null)
				teacher.teachingAClass();
			else
				Console.WriteLine("El Teacher es null, no se invocar al 'claseLista()'");
		}
		
	}
}
