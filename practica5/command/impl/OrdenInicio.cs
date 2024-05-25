using System;

namespace Practicas
{
	public class OrdenInicio : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenInicio(Aula aula)
		{
			this.aula = aula;
		}
		
		#region IOrdenEnAula1 implementation
		public void ejectuar()
		{
			this.aula.comenzar();
		}
		#endregion
	}
}
