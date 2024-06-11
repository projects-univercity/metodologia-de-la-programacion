using System;

namespace Practicas
{
    public abstract class FabricaDeComparables
    {
    	public static Manejador responsable;
    	
		public static Comparable crearAleatorio(int option)
		{
			FabricaDeComparables fabrica = switchFabrica(option);
			return fabrica.crearAleatorio();
        }
		
		public static Comparable crearPorTeclado(int option)
		{
			FabricaDeComparables fabrica = switchFabrica(option);
			return fabrica.crearPorTeclado();
        }
		
		public static Comparable crearConLectorDeArchivo(int option){
			FabricaDeComparables fabrica = switchFabrica(option);
			return fabrica.crearConLectorDeArchivo();
		}
        
        public abstract Comparable crearAleatorio();
        
        public abstract Comparable crearPorTeclado();
        
        public abstract Comparable crearConLectorDeArchivo();
        
        private static FabricaDeComparables switchFabrica(int option){
        	FabricaDeComparables fabrica = null;
            
            switch(option)
            {
                case 1: 
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2:
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    fabrica =new FabricaDeAlumnoMuyEstudioso();
                    break;
                case 5:
                    fabrica =new FabricaDeAlumnoCompuesto();
                    break;
            }
            return fabrica;
        }

    }

}