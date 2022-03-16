using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal class PlayerGeneric
	{
		public PlayerGeneric()
		{
			PlayedAgainst = new List<PlayerGeneric>();
		}

		public int Id { get; set; }
		public decimal Points { get; set; }
		public int Rank { get; set; }

		public IList<PlayerGeneric> PlayedAgainst { get; set; }
	}
}
