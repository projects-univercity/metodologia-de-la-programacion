using System;

namespace Practicas
{
	public class OrdenAulaLlena : IOrdenEnAula1
	{
		private Aula aula;
		
		public OrdenAulaLlena(Aula aula)
		{
			this.aula = aula;
		}
		
		#region IOrdenEnAula1 implementation
		public void ejectuar()
		{
			this.aula.claseLista();
		}
		#endregion
	}
}
