using System;
using MetodologíasDeProgramaciónI;

namespace Practicas
{
	public class AlumnoAdapter : Student
	{
		protected IAlumno alumno;
		
		public AlumnoAdapter(){}
		
		public AlumnoAdapter(IAlumno alumno)
		{
			this.alumno = alumno;
		}
		
		public IAlumno getAlumno(){
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
			return alumno.sosIgual(((AlumnoAdapter)student).getAlumno());
		}
		
		public bool lessThan(Student student)
		{
			return alumno.sosMenor(((AlumnoAdapter)student).getAlumno());
		}
		public bool greaterThan(Student student)
		{
			return alumno.sosMayor(((AlumnoAdapter)student).getAlumno());
		}
		#endregion
	}
}
