using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Tests.Helpers
{
	internal static class DataInitializer
	{
		internal static IEnumerable<Player> Initialize(int numberOfPlayers)
		{
			IList<Player> players = new List<Player>();
			for (int i = 1; i <= numberOfPlayers; i++)
			{
				Player player = new()
				{
					Id = i,
					Rank = i,
				};

				players.Add(player);
			}

			return players;
		}

		internal static void CalculateRoundOne(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -1501);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 254);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -286);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -1444);
		}

		internal static void CalculateRoundTwo(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 748);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, -1014);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, 435);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -144);
		}

		internal static void CalculateRoundThree(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -1141);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 954);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -325);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 1200);
		}

		internal static void CalculateRoundFour(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 952);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 94);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -699);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -17);
		}

		internal static void CalculateRoundFive(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -213);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 778);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -1752);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 129);
		}

		internal static void CalculateRoundSix(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, -412);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, 1541);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, -1340);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, 387);
		}

		internal static void CalculateRoundSeven(IEnumerable<Pair<Player>> pairedPlayers)
		{
			Pair<Player> firstPair = pairedPlayers.ElementAt(0);
			Pair<Player> secondPair = pairedPlayers.ElementAt(1);
			Pair<Player> thirdPair = pairedPlayers.ElementAt(2);
			Pair<Player> fourthPair = pairedPlayers.ElementAt(3);

			TournamentManager.UpdatePlayers(firstPair.FirstPlayer, firstPair.SecondPlayer, 125);
			TournamentManager.UpdatePlayers(secondPair.FirstPlayer, secondPair.SecondPlayer, -583);
			TournamentManager.UpdatePlayers(thirdPair.FirstPlayer, thirdPair.SecondPlayer, 990);
			TournamentManager.UpdatePlayers(fourthPair.FirstPlayer, fourthPair.SecondPlayer, -471);
		}
	}
}
