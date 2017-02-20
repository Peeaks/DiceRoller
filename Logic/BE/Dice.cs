using System;
using Xamarin.Forms;

namespace Logic {
	public class Dice {
		public int Number { get; set; }

		public ImageSource DiceImg {
			get {
				return ImageSource.FromResource ( "Logic.Images." + Number + ".png" );
			}
		}
	}
}
