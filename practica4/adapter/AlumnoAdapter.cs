using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class AlumnoAdapter : Student
	{
		protected Alumno alumno;
		
		public AlumnoAdapter(){}
		
		public AlumnoAdapter(Alumno alumno)
		{
			this.alumno = alumno;
		}
		
		public Alumno getAlumno(){
			return this.alumno;
		}
		public void setAlumno(Alumno alumno){
			this.alumno = alumno;
		}
		
		#region Student implementation
		public string getName()
		{
			return alumno.getNombre();
		}
		
		public int yourAnswerIs(int question)
		{
			return alumno.responderPregunta(question);
		}
		
		public void setScore(int score)
		{
			this.alumno.setCalificacion(score);
		}
		
		public string showResult()
		{
			return alumno.mostrarCalificacion();
		}
		public bool equals(Student student)
		{
			return alumno.sosIgual(((AlumnoAdapter)student).alumno);
		}
		
		public bool lessThan(Student student)
		{
			return alumno.sosMenor(((AlumnoAdapter)student).alumno);
		}
		public bool greaterThan(Student student)
		{
			return alumno.sosMayor(((AlumnoAdapter)student).alumno);
		}
		#endregion
	}
}
