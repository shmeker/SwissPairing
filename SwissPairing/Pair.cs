namespace SwissPairing
{
	/// <summary>
	/// Class that defines a single pair of objects.
	/// </summary>
	/// <typeparam name="T">Generic object holding player data.</typeparam>
	public class Pair<T> where T : class
	{
		/// <summary>
		/// Data of first player.
		/// </summary>
		public T FirstPlayer { get; private set; }

		/// <summary>
		/// Data of second player.
		/// </summary>
		public T SecondPlayer { get; private set; }

		/// <summary>
		/// Initializes a new instance of Pair class.
		/// </summary>
		/// <param name="firstPlayer">Generic object holding first player's data.</param>
		/// <param name="secondPlayer">Generic object holding second player's data.</param>
		public Pair(T firstPlayer, T secondPlayer)
		{
			FirstPlayer = firstPlayer;
			SecondPlayer = secondPlayer;
		}
	}
}
