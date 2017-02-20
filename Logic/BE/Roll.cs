using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace Logic {
	public class Roll {
		public DateTime Time { get; set; }

		public Dice Dice1 { get; set; }
		public Dice Dice2 { get; set; }
		public Dice Dice3 { get; set; }
		public Dice Dice4 { get; set; }
		public Dice Dice5 { get; set; }
		public Dice Dice6 { get; set; }

		public Roll ( ) {
			Time = DateTime.Now;

			Dice1 = new Dice ( );
			Dice2 = new Dice ( );
			Dice3 = new Dice ( );
			Dice4 = new Dice ( );
			Dice5 = new Dice ( );
			Dice6 = new Dice ( );
		}
	}
}
