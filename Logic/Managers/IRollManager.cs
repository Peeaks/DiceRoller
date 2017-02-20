using System;
using System.Collections.Generic;
namespace Logic {
	public interface IRollManager {
		List<Roll> GetAllRolls ( );
		void ClearRolls ( );
		Roll Roll ( int diceAmount, Dictionary<int, int> lockedDices );
	}
}
