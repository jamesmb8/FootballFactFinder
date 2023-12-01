using System.Security.Cryptography.X509Certificates;

namespace Thefinalproj
{
   


    
    public partial class Form1 : Form
    {


       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void TBLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLLastName_Click(object sender, EventArgs e)
        {

        }

        private void TBFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLFirstName_Click(object sender, EventArgs e)
        {

        }

        private void TBFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {

        }

        private void TBFullName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TBFirstName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void getPlayers()
        {
            List<string> players = File.ReadAllLines("PlayerList.txt").ToList();
            foreach (string player in players)
            {
               List<string>PlayerDetails = player.Split(',').ToList();
               Player newplayer = new Player(PlayerDetails[0], PlayerDetails)


            }

        }
    }
}