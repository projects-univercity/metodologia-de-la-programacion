using System;

namespace Practicas
{
	public class ColeccionOrdenable : IOrdenable
	{
		protected IOrdenEnAula1 ordenInicio, ordenLlena;
		protected IOrdenEnAula2 ordenLlega;
		
		public ColeccionOrdenable(){}
		
		public ColeccionOrdenable(IOrdenEnAula1 orden1, IOrdenEnAula2 orden2, IOrdenEnAula1 orden3){
			this.ordenInicio = orden1;
			this.ordenLlega = orden2;
			this.ordenLlena = orden3;
		}
		
		#region IOrdenable implementation

		public void setOrdenInicio(IOrdenEnAula1 orden)
		{
			this.ordenInicio = orden;
		}

		public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
		{
			this.ordenLlega = orden;
		}

		public void setOrdenAulaLlena(IOrdenEnAula1 orden)
		{
			this.ordenLlena = orden;
		}

		#endregion
	}
}
