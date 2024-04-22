using System.Threading.Channels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2last
{
    public partial class Form1 : Form
    {
        Point startLocation;

        public Form1()
        {
            InitializeComponent();
            startgame();
        }

        private void startgame()
        {
            startLocation = panelOuter.Location;
            Cursor.Position = PointToScreen(startLocation);
        }

        private void forbidden(object sender, EventArgs e)
        {
            startgame();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("You win the game. \nDo you want to play again?", "Congratulations", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                startgame();
            }
            else
            {
                Close();
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void for2(object sender, EventArgs e)
        {
            startgame();
        }
    }
}

