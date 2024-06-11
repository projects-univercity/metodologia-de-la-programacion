using System;
using System.Collections.Generic;
using System.Linq;

namespace Practicas
{

	public class Chancho : JuegoDeCartas
	{
		
		public Chancho(Jugador jugar1, Jugador jugar2) : base (jugar1, jugar2)
		{
			this.mazo = generarMazo();
		}
		
		public override void mezclarElMazo(){
			
        	var rng = new Random();
        	mazo = mazo.OrderBy(c => rng.Next()).ToList();
	        Console.WriteLine("Mazo mezclado");
		}
		
		public override void repartirLasCartasIniciales(){
			Console.WriteLine("Repartiendo Cartas");
			
			for(int i = 0; i< 4; i++){
				Carta carta = this.mazo[this.mazo.Count -1];
				if(i%2==0){
					((Jugador)this.jugador1).agregarCarta(carta);
				} else{
					((Jugador)this.jugador2).agregarCarta(carta);
				}
				this.mazo.Remove(carta);
			}
		
			
			Console.WriteLine(((Jugador)this.jugador1).ToString());
			Console.WriteLine(((Jugador)this.jugador2).ToString());
		}
		
		public override void tomarCartas(){
			Console.WriteLine("Tomando Cartas");
			Carta carta1 = this.mazo[this.mazo.Count -1];
			((Jugador)this.jugador1).agregarCarta(carta1);
			this.mazo.Remove(carta1);
			
			
			
			Carta carta2 = this.mazo[this.mazo.Count -1];
			((Jugador)this.jugador2).agregarCarta(carta2);
			this.mazo.Remove(carta2);
			
			Console.WriteLine(((Jugador)this.jugador1).ToString());
			Console.WriteLine(((Jugador)this.jugador2).ToString());
		}
		
		public override void descartarCartas(){
			Console.WriteLine("Decartando Carta");
			Carta cartaDescartada1 = ((Jugador)this.jugador1).eliminarCarta();
			
			this.mazo.Add(cartaDescartada1);
			
			Carta cartaDescartada2 = ((Jugador)this.jugador2).eliminarCarta();
			
			this.mazo.Add(cartaDescartada2);
		}
		
		public override bool chequearSiExisteUnGanador(){
			
			if( cartasIguales(((Jugador)this.jugador1).getCartas()))
			{
				Console.WriteLine("Ganador jugar " + jugador1.ToString());
				return true;
			}
			if( cartasIguales(((Jugador)this.jugador2).getCartas()))
			{
				Console.WriteLine("Ganador jugar " + jugador2.ToString());
				return true;
			}
			
			return false;
		}
		
		private bool cartasIguales(List<Carta> cartas){
			int valorCarta = cartas[0].getNumero();
			bool sonTodasIguales = true;
			foreach(Carta carta in cartas){
				if(carta.getNumero() != valorCarta){
					sonTodasIguales = false;
					break;
				}
			}
			return sonTodasIguales;
		}
		
		private List<Carta> generarMazo(){
			List<Carta> cartas = new List<Carta>();
			agregarCartaPorFigura(cartas, "Espada");
			agregarCartaPorFigura(cartas, "Palo");
			agregarCartaPorFigura(cartas, "Copa");
			agregarCartaPorFigura(cartas, "Oro");
			return cartas;
		} 
		
		public void agregarCartaPorFigura(List<Carta> cartas, String figura){
			for(int i=1; i< 4; i++){
				Carta carta = new Carta(figura, i);
				cartas.Add(carta);
			}
		}
	}
}