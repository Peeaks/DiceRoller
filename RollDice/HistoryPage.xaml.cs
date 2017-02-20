using System;
using System.Collections.Generic;
using Logic;
using Xamarin.Forms;

namespace RollDice {
	public partial class HistoryPage : ContentPage {
		public HistoryPage ( ) {
			InitializeComponent ( );
			Padding = new Thickness ( 20, 0, 20, 10 );
			Title = "History";

			fillList ( );
		}

		void fillList ( ) {
			list.ItemsSource = new RollFacade ( ).GetRollManager ( ).GetAllRolls ( );
		}

		void clear_clicked ( object o, EventArgs e ) {
			new RollFacade ( ).GetRollManager ( ).ClearRolls ();
			list.ItemsSource = null;
			list.ItemsSource = new RollFacade ( ).GetRollManager ( ).GetAllRolls ( );
		}

	}
}
