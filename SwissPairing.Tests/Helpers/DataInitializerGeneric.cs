using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal static class DataInitializerGeneric
	{
		internal static IEnumerable<PlayerGeneric> Initialize(int numberOfPlayers)
		{
			IList<PlayerGeneric> players = new List<PlayerGeneric>();
			for (int i = 1; i <= numberOfPlayers; i++)
			{
				PlayerGeneric player = new()
				{
					Id = i,
					Rank = i,
				};

				players.Add(player);
			}

			return players;
		}

		internal static void CalculateRoundOne(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -1501);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 254);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -286);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -1444);
		}

		internal static void CalculateRoundTwo(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 748);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, -1014);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, 435);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -144);
		}

		internal static void CalculateRoundThree(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -1141);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 954);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -325);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 1200);
		}

		internal static void CalculateRoundFour(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 952);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 94);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -699);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -17);
		}

		internal static void CalculateRoundFive(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -213);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 778);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -1752);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 129);
		}

		internal static void CalculateRoundSix(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -412);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 1541);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -1340);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 387);
		}

		internal static void CalculateRoundSeven(IEnumerable<Pair<PlayerGeneric>> pairedPlayers)
		{
			Pair<PlayerGeneric> firstPair = pairedPlayers.ElementAt(0);
			Pair<PlayerGeneric> secondPair = pairedPlayers.ElementAt(1);
			Pair<PlayerGeneric> thirdPair = pairedPlayers.ElementAt(2);
			Pair<PlayerGeneric> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManagerGeneric.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 125);
			TournamentManagerGeneric.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, -583);
			TournamentManagerGeneric.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, 990);
			TournamentManagerGeneric.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -471);
		}
	}
}
