using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class Aula : IOrdenableNoDocente
	{
		Teacher teacher;
		
		/*ORDENES INICIO, ASISTENCIA Y FINALIZACION*/
		IOrdenEnAula1 orden1, orden2, orden3;
		
		public Aula(){}
		
		public void comenzar(){
			orden1.ejectuar();
			this.teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno){
			if(teacher != null) {
				teacher.goToClass(new AlumnoAdapter(alumno));
				if(teacher.countStudents() == 2){
					orden2.ejectuar();
				}
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
		
		/**  */
		public void claseFinalizada(){
			orden3.ejectuar();
		}
		
		
		
		#region IOrdenableNoDocente implementation
		public void setOrdenInicio(IOrdenEnAula1 orden)
		{
			this.orden1 = orden;
		}
		public void setOrdenAsistir(IOrdenEnAula1 orden)
		{
			this.orden2 = orden;
		}
		public void setOrdenFinalizar(IOrdenEnAula1 orden)
		{
			this.orden3 = orden;
		}
		#endregion
	}
}
