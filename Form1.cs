using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.ListViewItem;

namespace Project_Tennis_2._0
{
    public partial class Form1 : Form
    {
        private static Dictionary<string, int> playersWithPoints = new()
{
    { "R. Federer", 4 },
    { "G. Dimitrov", 5 },
    { "R. Nadal", 5 }
};

        private static Dictionary<(string, int), List<(string, int)>> games = new()
    {
        {("G. Dimitrov",3), new List<(string, int)>{("R. Nadal", 2)} },
        {("R. Nadal",3), new List<(string, int)>{("R. Federer", 1)} },
        {("G. Dimitrov",2), new List<(string, int)>{("R. Federer", 3)} }
    };

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new ListViewItem();
                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }

        }
        private void FillLatestGamesListView()
        {
            this.listViewLatestGame.Items.Clear();

            foreach (var game in games.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);
            ListViewItem rollInLastestGamesListView = new ListViewItem();

            rollInLastestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLastestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLastestGamesListView.SubItems.Add(winner);
            rollInLastestGamesListView.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item1}");

            this.listViewLatestGame.Items.Add(rollInLastestGamesListView);
        }
        private string GetWinner((string, int) firstPlayer, (string, int) SecondPlayer)
        {
            if (firstPlayer.Item2 > SecondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < SecondPlayer.Item2)
            {
                return SecondPlayer.Item1;
            }

            return "Draw";
        }

      
        private void AddNewGame((string, int) FirstPlayer, (string, int) SecondPlayer)
        {
            FillGameData(FirstPlayer, SecondPlayer);
            FillPlayersWithPoints(FirstPlayer);
            FillPlayersWithPoints(SecondPlayer);
            FillRankingListView();
            FillLatestGamesListView();

        }
        private void FillGameData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)> { secondPlayer });
            }
        }
        private void FillPlayersWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }
        private void ViewProfileButtonClick()
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;
            using (Form3 playerInfoForm = new Form3(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }
        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames
     (string playerName)
    => games.Where(x => x.Key.Item1 == playerName
    || x.Value.Any(y => y.Item1 == playerName))
    .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
     || x.Key.Item1 == playerName).ToList());


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddNewGame_Click(object sender, EventArgs e)
        {
            using (Form2 NewGameForm = new Form2())
            {
                if (NewGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(NewGameForm.FirstPlayer, NewGameForm.SecondPlayer);
                }
            }
        }
    }
}
