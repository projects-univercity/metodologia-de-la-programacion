using System;

namespace Practicas
{
    public class FabricaDeNumeros : FabricaDeComparables {
        

        public FabricaDeNumeros(){}
        
		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			int numero = GeneradorDeDatos.numeroAleatorio(100);
        	return new Numero(numero);
		}
		public override Comparable crearPorTeclado()
		{
			int numero = LectorDeDatos.numeroPorTeclado();
			return new Numero(numero);
		}
		#endregion
    }
}
