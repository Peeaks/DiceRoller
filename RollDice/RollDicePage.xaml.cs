using System;
using Xamarin.Forms;
using Logic;
using System.Collections.Generic;

namespace RollDice {
	public partial class RollDicePage : ContentPage {

		Roll Current_Roll { get; set; }

		public RollDicePage ( ) {
			InitializeComponent ( );
			Padding = new Thickness ( 20, 10, 20, 10 );
			Title = "Dice Roller";
		}

		void roll_clicked ( object o, EventArgs e ) {
			var lockedDices = new Dictionary<int, int> ( );

			Current_Roll = new RollFacade ( ).GetRollManager ( ).Roll ( dice_amount.SelectedIndex + 1, lockedDices );

			dice_1_img.Source = Current_Roll.Dice1.DiceImg;
			dice_2_img.Source = Current_Roll.Dice2.DiceImg;
			dice_3_img.Source = Current_Roll.Dice3.DiceImg;
			dice_4_img.Source = Current_Roll.Dice4.DiceImg;
			dice_5_img.Source = Current_Roll.Dice5.DiceImg;
			dice_6_img.Source = Current_Roll.Dice6.DiceImg;
		}

		async void history_clicked ( object o, EventArgs e ) {
			await Navigation.PushAsync ( new HistoryPage ( ) );
		}
	}
}
