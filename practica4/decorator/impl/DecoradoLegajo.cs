using System;

namespace Practicas
{
	public class DecoradoLegajo : AlumnoDecorador
	{
		public DecoradoLegajo(IAlumno adicional) : base(adicional)
		{
		}
		
		public override String mostrarCalificacion()
		{
			String result = adicional.getNombre();
			result += " (" + adicional.getLegajo() + ")" + "     "+ adicional.getCalificacion();
			return result;
		}
	}
}
