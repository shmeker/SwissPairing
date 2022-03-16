using SwissPairing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissAlg
{
	public class Pairing
	{
		public int FirstPlayerRank { get; set; }
		public int SecondPlayerRank { get; set; }
		public Player First { get; set; }
		public Player Second { get; set; }
		public int PointDifference { get; set; }

		public static Pairing MapFromSwiss(Pair<Player> pairedPlayers)
		{
			return new Pairing
			{
				First = pairedPlayers.FirstPlayer,
				Second = pairedPlayers.SecondPlayer
			};
		}
	}
}
