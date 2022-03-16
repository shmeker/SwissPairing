using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissPairing.Base
{
	/// <summary>
	/// Abstract class that Swiss algorithm implementations use.
	/// </summary>
	/// <typeparam name="T">Generic type for player data.</typeparam>
	public abstract class BaseSwissAlgorithm<T> where T : class
	{
		/// <summary>
		/// Abstract method which checks if two players can play each other.
		/// </summary>
		/// <param name="firstPlayer">Object holding first player's data.</param>
		/// <param name="secondPlayer">Object holding second player's data.</param>
		/// <returns>True if players can play each other, false otherwise.</returns>
		protected abstract bool IsMatchValid(T firstPlayer, T secondPlayer);

		private IList<T> orderedList;

		/// <summary>
		/// Abstract constructor which initializes properties.
		/// </summary>
		public BaseSwissAlgorithm()
		{
			orderedList = new List<T>();
		}

		/// <summary>
		/// Creates ordered sequence of player data, which can be splitted in pairs.
		/// </summary>
		/// <param name="orderedPlayers">A sequence of player data objects ordered by rank.</param>
		/// <param name="orderedPlayersForPairing">A sequence of player data objects ordered for pairing.</param>
		/// <returns>True if pairing was successful, false otherwise.</returns>
		public bool CreatePairings(IEnumerable<T> orderedPlayers, out IEnumerable<T> orderedPlayersForPairing)
		{
			orderedList = new List<T>(orderedPlayers.Count());

			bool pairingSuccess = MatchPlayers(orderedPlayers);

			orderedPlayersForPairing = pairingSuccess ? orderedList.Reverse() : orderedPlayers;

			return pairingSuccess;
		}

		/// <summary>
		/// Creates ordered sequence of paired player data.
		/// </summary>
		/// <param name="orderedPlayers">A sequence of player data objects ordered by rank.</param>
		/// <param name="pairedPlayers">A sequence of paired player data.</param>
		/// <returns>True if pairing was successful, false otherwise.</returns>
		public bool CreatePairings(IEnumerable<T> orderedPlayers, out IEnumerable<Pair<T>> pairedPlayers)
		{
			bool pairingSuccess = CreatePairings(orderedPlayers, out IEnumerable<T> orderedPlayersForPairing);

			pairedPlayers = pairingSuccess ? SwissHelpers.CreatePairingsFromList(orderedPlayersForPairing) : SwissHelpers.CreatePairingsFromList(orderedPlayers);

			return pairingSuccess;
		}

		private bool MatchPlayers(IEnumerable<T> playerList)
		{
			if (!playerList.Any())
			{
				return true;
			}

			T basePlayer = playerList.First();

			foreach (T potentialMatch in playerList.Skip(1))
			{
				if (IsMatchValid(basePlayer, potentialMatch) && MatchPlayers(playerList.Except(new T[] { basePlayer, potentialMatch })))
				{
					orderedList.Add(potentialMatch);
					orderedList.Add(basePlayer);

					return true;
				}
			}

			return false;
		}
	}
}
