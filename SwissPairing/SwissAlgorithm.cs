using SwissPairing.Base;

namespace SwissPairing
{
	/// <summary>
	/// Swiss algorithm that uses player object data, which inherits ISwissPlayer interface.
	/// </summary>
	/// <typeparam name="T">Player's data object, which inherits ISwissPlayer interface.</typeparam>
	public class SwissAlgorithm<T> : BaseSwissAlgorithm<T> where T : class, ISwissPlayer
	{
		/// <summary>
		/// Overriden method which checks if two players can play each other.
		/// </summary>
		/// <param name="firstPlayer">Object holding first player's data.</param>
		/// <param name="secondPlayer">Object holding second player's data.</param>
		/// <returns>True if players can play each other, false otherwise.</returns>
		protected override bool IsMatchValid(T firstPlayer, T secondPlayer)
		{
			return firstPlayer.IsValidMatch(secondPlayer) && secondPlayer.IsValidMatch(firstPlayer);
		}
	}
}
