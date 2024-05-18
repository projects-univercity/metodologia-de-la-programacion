using System;

namespace Practicas
{
	public class DecoradoLegajo : DecoradoAlumno
	{
		public DecoradoLegajo(IAlumno adicional) : base (adicional)
		{
		}
		
		public String mostrarCalificacion(){
			String result = base.getNombre();
			result += " (" + adicional.getLegajo() + ")" + "     "+ adicional.getCalificacion();
			return result;
		}
	}
}
