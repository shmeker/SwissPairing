using SwissPairing.Base;
using System;

namespace SwissPairing.Generics
{
	/// <summary>
	/// Swiss algorithm that uses generic player object data.
	/// </summary>
	/// <typeparam name="T">Generic player's data object.</typeparam>
	public class SwissGenericAlgorithm<T> : BaseSwissAlgorithm<T> where T : class
	{
		private readonly Func<T, T, bool> evaluationPredicate;

		/// <summary>
		/// Initializes new instance of generic Swiss algorithm.
		/// </summary>
		/// <param name="evaluationPredicate">Function which determines if two given player data object are a valid match.</param>
		public SwissGenericAlgorithm(Func<T, T, bool> evaluationPredicate)
		{
			this.evaluationPredicate = evaluationPredicate;
		}

		/// <summary>
		/// Overriden method which checks if two players can play each other.
		/// </summary>
		/// <param name="firstPlayer">Object holding first player's data.</param>
		/// <param name="secondPlayer">Object holding second player's data.</param>
		/// <returns>True if players can play each other, false otherwise.</returns>
		protected override bool IsMatchValid(T firstPlayer, T secondPlayer)
		{
			return evaluationPredicate(firstPlayer, secondPlayer);
		}
	}
}
