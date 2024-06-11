using System;

namespace Practicas
{
	
	public class OrdenLlegaAlumno : IOrdenEnAula2
	{
		
		private Aula aula;
		
		public OrdenLlegaAlumno(Aula aula)
		{
			this.aula = aula;
		}

		#region IOrdenEnAula2 implementation

		public void ejecutar(IAlumno alumno)
		{
			Console.WriteLine("Ejecutando command -> OrdenLlegaAlumno");
			aula.nuevoAlumno(alumno);
		}

		#endregion
	}
}
