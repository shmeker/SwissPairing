namespace SwissPairing
{
	/// <summary>
	/// Interface with definitions for player data objects.
	/// </summary>
	public interface ISwissPlayer
	{
		/// <summary>
		/// Method which validates if two players can play each other.
		/// </summary>
		/// <param name="player">Other player data object.</param>
		/// <returns>True if player can play each other, false otherwise.</returns>
		bool IsValidMatch(ISwissPlayer player);
	}
}
