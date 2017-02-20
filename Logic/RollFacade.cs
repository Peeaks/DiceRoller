using System;
namespace Logic {
	public class RollFacade {

		private static IRollManager RollManager { get; set; }

		public IRollManager GetRollManager ( ) {
			if ( RollManager == null ) {
				RollManager = new RollManager ( );
			}
			return RollManager;
		}
	}
}
