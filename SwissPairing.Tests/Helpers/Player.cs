using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal class Player : ISwissPlayer
	{
		public Player()
		{
			PlayedAgainst = new List<Player>();
		}

		public int Id { get; set; }
		public decimal Points { get; set; }
		public int Rank { get; set; }

		public IList<Player> PlayedAgainst { get; set; }

		public bool IsValidMatch(ISwissPlayer player)
		{
			return !PlayedAgainst.Contains(player);
		}
	}
}
