using System;

namespace Practicas
{
	public class DecoradoPromocion : AlumnoDecorador
	{
		public DecoradoPromocion(IAlumno adicional) : base(adicional)
		{
		}
		
		public override String mostrarCalificacion(){
			
			String result = base.mostrarCalificacion();
			result += " (" + this.establecerCondicion(getCalificacion()) + ")";
			return result;
		}
		
		
		/**
		 * Establecer condicion segundo calificion
		*/
		private String establecerCondicion(int calificacion){
			string condicion = "";
			if(7 <= calificacion && calificacion <= 10)
				condicion = "PROMOCIÓN";
			else if(4 <= calificacion && calificacion <=6)
				condicion = "APROBADO";
			else if(0 <= calificacion && calificacion < 4)
				condicion = "DESAPROBADO";
			return condicion;
		}
	}
}
