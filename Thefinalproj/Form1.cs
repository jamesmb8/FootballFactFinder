using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Thefinalproj
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetPlayers();
            LoadTable();
            UserAbility();
        }

        List<Player> playerList = new List<Player>();

        private void BTNSearch_Click(object sender, EventArgs e)
        {
           
            UsersPlayer();

        }

      
        private void BTNClear_Click(object sender, EventArgs e)
        {

            TBFirstName.Clear();
            TBLastName.Clear();

        }


        private void GetPlayers()
        {
            List<string> players = File.ReadAllLines("PlayerList.txt").ToList();
            foreach (string player in players)
            {
                List<string> PlayerDetails = player.Split(',').ToList();
                Player newplayer = new Player(PlayerDetails[0], PlayerDetails[1], Convert.ToInt32(PlayerDetails[2]), Convert.ToInt32(PlayerDetails[3]), Convert.ToInt32(PlayerDetails[4]), Convert.ToInt32(PlayerDetails[5]), Convert.ToInt32(PlayerDetails[6]));
                playerList.Add(newplayer);

            }
            

        }

        void UsersPlayer()
        {
            string User_firstName = TBFirstName.Text;
            string User_lastName = TBLastName.Text;
            bool isMatch = false;
            foreach (Player player in playerList)
            {
                if (player.FirstName.Equals(User_firstName) && player.LastName.Equals(User_lastName))
                {
                    LoadDetails(player);
                    isMatch = true;
                    break;
 
                }


            }
            if (!isMatch)
            {
                MessageBox.Show("Sorry we do not know the statistics for that player");
            }
           
            void LoadDetails(Player player)
            {
                TBFullName.Text = ($"{player.FirstName} {player.LastName}");


                TBGamesPlayed.Text = player.GamesPlayed.ToString();
                TBGoals.Text = player.Goals.ToString();
                TBAssists.Text = player.Assists.ToString();
                TBYellowCards.Text = player.YellowCards.ToString();
                TBRedCards.Text = player.RedCards.ToString();
               
            }

        }
        void LoadTable()
        {
            List<String> Table = File.ReadAllLines("Table.txt").ToList();
            foreach (String team in Table)
            {
                LBTable.Items.Add(team);

            }
        }
        void UserAbility()
        {
            TBFullName.Enabled = false;
            TBGamesPlayed.Enabled = false;
            TBGoals.Enabled = false;
            TBAssists.Enabled = false;
            TBYellowCards.Enabled = false;
            TBRedCards.Enabled = false;

        }

       

        private void LBTable_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        
    }
}