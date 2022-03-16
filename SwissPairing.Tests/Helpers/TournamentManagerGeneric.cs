using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal static class TournamentManagerGeneric
	{
		public static IEnumerable<PlayerGeneric> OrderPlayers(IEnumerable<PlayerGeneric> players)
		{
			return players.OrderByDescending(p => p.Points);
		}

		public static IEnumerable<PlayerGeneric> UpdateRanks(IEnumerable<PlayerGeneric> players)
		{
			players = OrderPlayers(players);

			int rank = 1;
			foreach (PlayerGeneric player in players)
			{
				player.Rank = rank++;
			}

			return players;
		}

		public static void UpdatePlayers(PlayerGeneric first, PlayerGeneric second, decimal points)
		{
			first.Points += points;
			first.PlayedAgainst.Add(second);

			second.Points -= points;
			second.PlayedAgainst.Add(first);
		}
	}
}
