using System;

namespace Practicas
{
	
	public class ClaveValor
	{
		Numero clave;
		Comparable valor;
		
		public ClaveValor(Numero clave, Comparable valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
		
		public Numero getClave(){
			return this.clave;
		}
		public void setClave(Numero clave){
			this.clave = clave;
		}
		
		public Comparable getValor(){
			return this.valor;
		}
		
		public void setValor(Comparable valor){
			this.valor = valor;
		}
		
		public override string ToString()
		{
			return string.Format("[ClaveValor Clave={0}, Valor={1}]", clave, valor);
		}

	}
}
