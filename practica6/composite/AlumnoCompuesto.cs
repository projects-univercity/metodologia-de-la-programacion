using System;
using System.Collections.Generic;

namespace Practicas
{
	public class AlumnoCompuesto : IAlumno
	{
		
		List<IAlumno> alumnosCompuestos;
		
		public AlumnoCompuesto(){
			this.alumnosCompuestos = new List<IAlumno>();
		}
		
		public void agregarAlumno(IAlumno alumno){
			this.alumnosCompuestos.Add(alumno);
		}
		
		#region AlumnoComposite implementation
		public String getNombre()
		{
			String nombres = "[";
			for (int i = 0; i < alumnosCompuestos.Count; i++){
				
				nombres += alumnosCompuestos[i].getNombre();
				if(i == alumnosCompuestos.Count -1)
					nombres += "]";
				else 
					nombres += ", ";
			}
			return nombres;
		}
		
		public int responderPregunta(int pregunta)
		{
			int[]respuestas = new int[4];
			for (int i = 0; i < this.alumnosCompuestos.Count; i++) {
				int respuesta = alumnosCompuestos[i].responderPregunta(pregunta);
				//Console.WriteLine("respuesta: " + respuesta);
				respuestas[respuesta] = respuestas[respuesta] + 1;
			}
			
			
			int masRespondida = respuestas[0];
			for (int i = 1; i < respuestas.Length; i++) {
				//Console.WriteLine("respuestas_ " + respuestas[i]);
				if(masRespondida < respuestas[i]){
					masRespondida = i;
				}
			}
			return masRespondida;
		}
		
		public void setCalificacion(int calificacion)
		{
			foreach (IAlumno compuesto in alumnosCompuestos) {
				compuesto.setCalificacion(calificacion);
			}
		}
		
		public String mostrarCalificacion(){
			String notas = "";
			foreach (IAlumno compuesto in this.alumnosCompuestos) {
				notas += " " + compuesto.mostrarCalificacion();
			}
			return notas;
		}
		
		public bool sosIgual(Comparable comparable)
		{
			foreach (IAlumno compuesto in alumnosCompuestos) {
				if(compuesto.sosIgual(comparable)){
					return true;
				}
			}
			return false;
		}
		
		public bool sosMayor(Comparable comparable)
		{
			foreach (IAlumno compuesto in alumnosCompuestos) {
				if(!compuesto.sosMayor(comparable)){
					//Console.WriteLine( compuesto + " < " + comparable);
					return false;
				}
			}
			return true;
		}
		
		public bool sosMenor(Comparable comparable)
		{
			foreach (IAlumno compuesto in alumnosCompuestos) {
				if(!compuesto.sosMenor(comparable)){
					//Console.WriteLine( compuesto + " > " + comparable);
					return false;
				}
			}
			return true;
		}
		#endregion
		
		public double getPromedio()
		{
			throw new NotImplementedException();
		}
		public double getLegajo()
		{
			throw new NotImplementedException();
		}
		public int getCalificacion()
		{
			throw new NotImplementedException();
		}
	}
}
