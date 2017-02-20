using System;
using System.Collections.Generic;
namespace RollDice {
	public class Roll {
		public int Id { get; set; }
		public DateTime Time { get; set; }
		public List<int> Rolls { get; set; }
		public string Rolls_String {
			get {
				var output = "";
				foreach ( var roll in Rolls ) {
					output += roll.ToString ( ) + " ";
				}

				return output;
			}
		}
	}
}
