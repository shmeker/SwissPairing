using SwissPairing.Tests.Helpers;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SwissPairing.Tests
{
	public class SwissAlgorithmTests
	{
		[Fact]
		public void SwissAlgorithm_RoundOne_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);

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
		public void SwissAlgorithm_RoundTwo_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundThree_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundFour_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundThree(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundFive_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundThree(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFour(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundSix_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundThree(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFour(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFive(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundSeven_Success()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundThree(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFour(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFive(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundSix(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

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
		public void SwissAlgorithm_RoundEight_Failure()
		{
			int numberOfPlayers = 8;
			IEnumerable<Player> players = DataInitializer.Initialize(numberOfPlayers);
			SwissAlgorithm<Player> swissAlgorithm = new();

			bool pairingSuccessful = swissAlgorithm.CreatePairings(players, out IEnumerable<Pair<Player>> pairedPlayers);
			DataInitializer.CalculateRoundOne(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundTwo(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundThree(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFour(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundFive(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundSix(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);
			DataInitializer.CalculateRoundSeven(pairedPlayers);
			players = TournamentManager.UpdateRanks(players);

			pairingSuccessful &= swissAlgorithm.CreatePairings(players, out pairedPlayers);

			Assert.False(pairingSuccessful);
		}
	}
}