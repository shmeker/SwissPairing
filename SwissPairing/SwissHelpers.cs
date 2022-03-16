using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissPairing
{
	/// <summary>
	/// Class with helpers for Swiss algorithm.
	/// </summary>
	public static class SwissHelpers
	{
		/// <summary>
		/// Creates a sequence of Pair objects from ordered generic objects.
		/// </summary>
		/// <typeparam name="T">Generic object holding player data.</typeparam>
		/// <param name="orderedPlayers">A sequence of ordered generic objects.</param>
		/// <returns>The sequence of Pair objects.</returns>
		/// <exception cref="ArgumentException">When number of objects in input parameter is not even.</exception>
		public static IEnumerable<Pair<T>> CreatePairingsFromList<T>(IEnumerable<T> orderedPlayers) where T : class
		{
			if (orderedPlayers.Count() % 2 != 0)
			{
				throw new ArgumentException("Input parameter does not contain even number of objects.", nameof(orderedPlayers));
			}

			IList<Pair<T>> pairings = new List<Pair<T>>(orderedPlayers.Count() / 2);
			IList<T> orderedPlayersAsList = orderedPlayers.ToList();
			for (int i = 0; i < orderedPlayersAsList.Count; i += 2)
			{
				pairings.Add(new Pair<T>(orderedPlayersAsList[i], orderedPlayersAsList[i + 1]));
			}

			return pairings;
		}
	}
}
