using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal static class TournamentManager
	{
		public static IEnumerable<Player> OrderPlayers(IEnumerable<Player> players)
		{
			return players.OrderByDescending(p => p.Points);
		}

		public static IEnumerable<Player> UpdateRanks(IEnumerable<Player> players)
		{
			players = OrderPlayers(players);

			int rank = 1;
			foreach (Player player in players)
			{
				player.Rank = rank++;
			}

			return players;
		}

		public static void UpdatePlayers(Player first, Player second, decimal points)
		{
			first.Points += points;
			first.PlayedAgainst.Add(second);

			second.Points -= points;
			second.PlayedAgainst.Add(first);
		}
	}
}
