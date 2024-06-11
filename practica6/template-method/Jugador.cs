using System;
using System.Collections.Generic;

namespace Practicas
{
	public class Jugador : Persona
	{
		
		List<Carta> cartas; 
		
		public Jugador(String nombre, int dni) : base (nombre, dni)
		{
			this.cartas = new List<Carta>();
		}
		
		public void agregarCarta(Carta carta){
			this.cartas.Add(carta);
		}
		
		public Carta eliminarCarta(){
			Carta carta = cartas[0];
			this.cartas.RemoveAt(this.cartas.Count -1);
			return carta;
		}
		
		public List<Carta> getCartas(){
			return this.cartas;
		}
		
		public override string ToString()
		{
			String cartasStr = "";
			foreach(Carta carta in this.cartas){
				cartasStr +=  carta.getNumero() + "de " + carta.getFigura() + ". ";
			}
			return string.Format("[Jugador {0} Cartas: {1}]", this.nombre , cartasStr);
		}

	}
}
