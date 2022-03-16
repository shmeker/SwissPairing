using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissAlg
{
	public class Player
	{
		public Player()
		{
			PlayedAgainst = new List<Player>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public int Points { get; set; }
		public int Rank { get; set; }

		public IList<Player> PlayedAgainst;
	}
}
