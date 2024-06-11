using System;

namespace Practicas
{
    public class FabricaDeNumeros : FabricaDeComparables {
        

        public FabricaDeNumeros(){}
        
        public FabricaDeNumeros(Manejador responsable) /*: base (responsable)*/{
        }
        
		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			int numero = responsable.numeroAleatorio(100);
        	return new Numero(numero);
		}
		public override Comparable crearPorTeclado()
		{
			int numero = responsable.numeroPorTeclado();
			return new Numero(numero);
		}
		
		public override Comparable crearConLectorDeArchivo(){
			int numero = (int)(responsable.numeroDesdeArchivo(5));
			return new Numero(numero);
		}
		#endregion
    }
}
