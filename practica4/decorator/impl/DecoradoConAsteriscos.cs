using System;

namespace Practicas
{
	public class DecoradoConAsteriscos : AlumnoDecorador
	{
		public DecoradoConAsteriscos(IAlumno adicional) : base(adicional)
		{
		}
		
		public override String mostrarCalificacion(){
			
			String decorado = base.mostrarCalificacion();
			string preDec = "*  ";
			string postDec = "    *";
			string asteriscos = generarStrAsteriscos(decorado.Length + preDec.Length + postDec.Length);

			String result = asteriscos + "\n";
			result += preDec;
			result += decorado;
			result += postDec + "\n";
			result += asteriscos;
			return result;
		}
		
		private String generarStrAsteriscos(int length){
			int iteraciones = 0;
			String result = "";
			while(iteraciones < length){
				result += "*";
				iteraciones++;
			}
			return result;
		}
	}
}
