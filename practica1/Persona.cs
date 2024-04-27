
using System;

namespace Practicas
{
    
    public class Persona: Comparable
    {
        protected String nombre;
        protected int dni;
        
        public Persona(){
        }
        
        public Persona(String nombre, int dni) {
            this.nombre = nombre;
            this.dni = dni;
        }
        
        // disable once ConvertToAutoProperty
        public String getNombre(){
            return this.nombre;
        }
        public void setNombre(String nombre){
            this.nombre = nombre;
        }
        
        // disable once ConvertToAutoProperty
        public int getDni(){
            return this.dni;
        }
        public void setDni(int dni){
            this.dni = dni;
        }
        
        
        public virtual bool sosIgual(Comparable comparable) {
            return this.dni == ((Persona) comparable).getDni();
        }

        
        public virtual bool sosMenor(Comparable comparable) {
            return this.dni <  ((Persona) comparable).getDni();
        }

        
        public virtual bool sosMayor(Comparable comparable) {
            return this.dni > ((Persona) comparable).getDni();
        }
        
		public override string ToString()
		{
			return string.Format("[Nombre={0}, Dni={1}]", nombre, dni);
		}

        
    }
}
