using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic {
	class RollManager : IRollManager {

		private List<Roll> Rolls { get; set; }

		internal RollManager ( ) {
			Rolls = new List<Roll> ( );
		}

		public List<Roll> GetAllRolls ( ) {
			return Rolls.AsEnumerable ( ).Reverse ( ).ToList ( );
		}

		public Roll Roll ( int diceAmount, Dictionary<int, int> lockedDices ) {

			var newRoll = new Roll();

			var randomGen = new Random ( );
			for ( int i = 0; i < diceAmount; i++ ) {
				var newThrow = randomGen.Next ( 1, 7 );

				if ( newRoll.Dice1.Number == 0 ) {
					newRoll.Dice1.Number = newThrow;
				} else if ( newRoll.Dice2.Number == 0 ) {
					newRoll.Dice2.Number = newThrow;
				} else if ( newRoll.Dice3.Number == 0 ) {
					newRoll.Dice3.Number = newThrow;
				} else if ( newRoll.Dice4.Number == 0 ) {
					newRoll.Dice4.Number = newThrow;
				} else if ( newRoll.Dice5.Number == 0 ) {
					newRoll.Dice5.Number = newThrow;
				} else if ( newRoll.Dice6.Number == 0 ) {
					newRoll.Dice6.Number = newThrow;
				}
			}

			//Add to managers memory
			Rolls.Add ( newRoll );

			return newRoll;
		}

		public void ClearRolls ( ) {
			Rolls.Clear ( );
		}
	}
}
