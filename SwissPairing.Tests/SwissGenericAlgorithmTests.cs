using SwissPairing.Generics;
using SwissPairing.Tests.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SwissPairing.Tests
{
	public class SwissGenericAlgorithmTests
	{
		[Fact]
		public void SwissGenericAlgorithm_RoundOne_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(1, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(2, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(3, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundTwo_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(2, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(3, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundThree_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(2, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(3, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundFour_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundThree(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(3, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(2, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundFive_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundThree(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFour(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(3, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(2, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundSix_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundThree(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFour(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFive(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(3, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(6, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(2, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundSeven_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundThree(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFour(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFive(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundSix(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.True(pairingSuccessful);
			Assert.Equal(6, pairedPlayers.ElementAt(0).FirstPlayer.Id);
			Assert.Equal(1, pairedPlayers.ElementAt(0).SecondPlayer.Id);
			Assert.Equal(3, pairedPlayers.ElementAt(1).FirstPlayer.Id);
			Assert.Equal(7, pairedPlayers.ElementAt(1).SecondPlayer.Id);
			Assert.Equal(2, pairedPlayers.ElementAt(2).FirstPlayer.Id);
			Assert.Equal(4, pairedPlayers.ElementAt(2).SecondPlayer.Id);
			Assert.Equal(5, pairedPlayers.ElementAt(3).FirstPlayer.Id);
			Assert.Equal(8, pairedPlayers.ElementAt(3).SecondPlayer.Id);
		}

		[Fact]
		public void SwissGenericAlgorithm_RoundEight_Failure()
		{
			int numberOfPlayers = 8;
			IEnumerable<PlayerGeneric> players = DataInitializerGeneric.Initialize(numberOfPlayers);
			SwissGenericAlgorithm<PlayerGeneric> swissAlgorithm = new(PlayedAgainst);

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<PlayerGeneric>> pairedPlayers);
			DataInitializerGeneric.CalculateRoundOne(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundTwo(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundThree(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFour(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundFive(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundSix(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializerGeneric.CalculateRoundSeven(pairedPlayers);
			players = TournamentManagerGeneric.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.False(pairingSuccessful);
		}

		private bool PlayedAgainst(PlayerGeneric first, PlayerGeneric second)
		{
			return !first.PlayedAgainst.Contains(second);
		}
	}
}
