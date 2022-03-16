using SwissPairing;
using SwissPairing.Generics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissAlg
{
	public class DataProvider
	{
		private readonly SwissGenericAlgorithm<Player> swissAlgorithm;
		private IEnumerable<Player> generatedPlayers;
		private Dictionary<int, IEnumerable<Pairing>> roundsPlayed;

		public DataProvider()
		{
			this.swissAlgorithm = new((f, s) => !f.PlayedAgainst.Contains(s));
		}

		public Dictionary<int, IEnumerable<Pairing>> GenerateTournament(int playerCount, int roundsNumber)
		{
			GeneratePlayers(playerCount);

			roundsPlayed = new();
			for (int i = 0; i < roundsNumber; i++)
			{
				OrderPlayers();
				SetRankingToPlayers();

				IEnumerable<Pair<Player>> swissPairings;
				if (i == 0)
				{
					swissPairings = SwissHelpers.CreatePairingsFromList(generatedPlayers);
				}
				else
				{
					swissPairings = PairBySwiss();
				}

				IEnumerable<Pairing> pairings = swissPairings.Select(s => Pairing.MapFromSwiss(s)).ToList();

				GenerateResults(pairings);
				roundsPlayed.Add(i, pairings);
			}

			return roundsPlayed;
		}

		public IEnumerable<Player> GetPlayers()
		{
			OrderPlayers();
			SetRankingToPlayers();

			return generatedPlayers;
		}

		private void OrderPlayers()
		{
			generatedPlayers = generatedPlayers.OrderByDescending(o => o.Points);
		}

		private void SetRankingToPlayers()
		{
			int rank = 1;
			foreach (Player player in generatedPlayers)
			{
				player.Rank = rank++;
			}
		}

		private IEnumerable<Pair<Player>> PairBySwiss()
		{
			IEnumerable<Player> orderedPlayers = generatedPlayers.OrderByDescending(o => o.Points);

			bool success = swissAlgorithm.CreatePairings(orderedPlayers, out IEnumerable<Pair<Player>> orderedBySwiss);

			if (!success)
			{
				throw new Exception("Swiss pairing not successfull!");
			}

			return orderedBySwiss;
		}

		private void GeneratePlayers(int count)
		{
			if (count % 2 != 0)
			{
				throw new ArgumentException($"Parameter {nameof(count)} is not an even number.");
			}

			IList<Player> players = new List<Player>(count);
			for (int i = 0; i < count; i++)
			{
				players.Add(new Player()
				{
					Id = i,
					Name = "Player " + i.ToString()
				});
			}

			generatedPlayers = players;
		}

		private void GenerateResults(IEnumerable<Pairing> pairings)
		{
			foreach (Pairing pairing in pairings)
			{
				Random random = new();
				int pointDifference = random.Next(-2000, 2000);

				pairing.PointDifference = pointDifference;

				pairing.First.Points += pointDifference;
				pairing.Second.Points += (pointDifference * -1);

				pairing.FirstPlayerRank = pairing.First.Rank;
				pairing.SecondPlayerRank = pairing.Second.Rank;

				pairing.First.PlayedAgainst.Add(pairing.Second);
				pairing.Second.PlayedAgainst.Add(pairing.First);
			}
		}
	}
}
