using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SwissAlg
{
	public partial class FrmSwissDemo : Form
	{
		public FrmSwissDemo()
		{
			InitializeComponent();
		}

		private void BtnGenerate_Click(object sender, EventArgs e)
		{
			int playerCount = (int)NudPlayerCount.Value;
			int roundNumber = (int)NudRoundNumber.Value;

			DataProvider dataProvider = new();
			ClearTabs();

			try
			{
				Dictionary<int, IEnumerable<Pairing>> results = dataProvider.GenerateTournament(playerCount, roundNumber);
				IEnumerable<Player> players = dataProvider.GetPlayers();

				ShowPlayersOnGrid(players);

				ShowRoundsInTabs(results);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ShowPlayersOnGrid(IEnumerable<Player> players)
		{
			DgvPlayers.DataSource = players.ToList();

			foreach(DataGridViewColumn column in DgvPlayers.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}

		private void ShowRoundsInTabs(Dictionary<int, IEnumerable<Pairing>> results)
		{
			foreach(KeyValuePair<int, IEnumerable<Pairing>> round in results)
			{
				TabPage tabPage;
				if (round.Key == 0)
				{
					tabPage = TcRounds.TabPages[0];
				}
				else
				{
					tabPage = new TabPage("Round " + (round.Key + 1).ToString());
					TcRounds.TabPages.Add(tabPage);
				}

				DataGridView dataGridView = new()
				{
					DataSource = MapPairings(round.Value).ToList()
				};

				tabPage.Controls.Add(dataGridView);
				dataGridView.Width = tabPage.ClientRectangle.Width;
				dataGridView.Height = tabPage.ClientRectangle.Height;
				dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
			}
		}

		private void ClearTabs()
		{
			int tabCount = TcRounds.TabCount;
			for (int i = tabCount - 1; i > 0; i--)
			{
				TcRounds.TabPages.RemoveAt(i);
			}

			TcRounds.TabPages[0].Controls.Clear();
		}

		private IEnumerable<PairingView> MapPairings(IEnumerable<Pairing> pairings)
		{
			return pairings.Select(s => new PairingView()
			{
				FirstPlayer = $"{s.FirstPlayerRank}. {s.First.Name}",
				SecondPlayer = $"{s.SecondPlayerRank}. {s.Second.Name}",
				PointDifference = s.PointDifference
			});
		}
	}
}
