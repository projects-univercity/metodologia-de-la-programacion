/*
 * Creado por SharpDevelop.
 * Usuario: osiri
 * Fecha: 20/4/2024
 * Hora: 05:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practicas
{
	
	public class ClaveValor
	{
		Comparable clave;
		int valor;
		
		public ClaveValor(Comparable clave, int valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
		
		public Comparable getClave(){
			return this.clave;
		}
		public void setClave(Comparable clave){
			this.clave = clave;
		}
		
		public int getValor(){
			return this.valor;
		}
		
		public void setValor(int valor){
			this.valor = valor;
		}
	}
}
