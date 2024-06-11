using System;
using System.Collections.Generic;

namespace Practicas
{
	public abstract class JuegoDeCartas
	{
		protected Persona jugador1;
		protected Persona jugador2;
		protected List<Carta> mazo;
		
		public JuegoDeCartas(Jugador jugador1, Jugador jugador2 ){
			this.jugador1 = jugador1;
			this.jugador2 = jugador2;
		}
		
		public void jugar(){
		 	mezclarElMazo();
			
			repartirLasCartasIniciales();
			
			int contadorDeMano = 1;
			while(!chequearSiExisteUnGanador() && contadorDeMano < 5){
				Console.WriteLine("Mano numero "+ contadorDeMano);
				jugarUnaMano();
				contadorDeMano ++;
				mezclarElMazo();
			}
		}
		
		public void jugarUnaMano(){
			tomarCartas();
			descartarCartas();
		}
		
		public abstract void mezclarElMazo();
		
		public abstract void repartirLasCartasIniciales();
		
		public abstract void tomarCartas();
		
		public abstract void descartarCartas();
		
		public abstract bool chequearSiExisteUnGanador();
		
	}
}
