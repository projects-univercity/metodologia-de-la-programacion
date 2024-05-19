using System;

namespace Practicas
{
	public class DecoradoNotaEnLetra : AlumnoDecorador
	{
		
		public DecoradoNotaEnLetra(IAlumno adicional) : base(adicional)
		{
		}
		
		public override String mostrarCalificacion(){
			
			String result = base.mostrarCalificacion();
			result +=  " (" + notaALetras(this.getCalificacion()) + ")";
			return result;
		}
		
		private String notaALetras(int nota){
			String[] notas = {"Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez"};
			if(0 <= nota && nota <= 10)
				return notas[nota];
			return null;
		}
	}
}
