using System;
using System.IO;

namespace Practicas
{
	
	public class LectorDeArchivos : Manejador
	{
		
		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\osiri\OneDrive\Documentos\datos.txt";
		// -------------------------------------------------------------------------------------------------------
		
		/**Start SINGLETON*/
		private static StreamReader lector_de_archivos;
		
		/**Metodo para devolver una unica instancia */
		private StreamReader getInstacia()
    	{
        	if (lector_de_archivos == null)
        	{
            	lector_de_archivos = new StreamReader(ruta_archivo);
        	}
        	return lector_de_archivos;
    	}
		
		//Constructor privado para no permitir instancia
		public LectorDeArchivos(Manejador sucesor):base() {
			lector_de_archivos = getInstacia();
		}
		/**End Singleton*/
		
		public override double numeroDesdeArchivo(double max){
			string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}
		
		public override string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}
	}


}
