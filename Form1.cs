using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();

            playerBox = new PictureBox(); // Initialize the player box

            playerBox.BackColor = Color.Red; // Set the color of the player box
            playerBox.Size = new Size(50, 50); // Set the size of the player box
            playerBox.Location = new Point(375, 375); // Set the initial position of the player box

            Controls.Add(playerBox); // Add the player box to the form

            KeyDown += playerBox_KeyDown; // Subscribe to the KeyDown event of the form
        }

        //private void Player_Load(object sender, EventArgs e)
        //{
        //    // Set the initial position of the player box
        //    playerBox.Left = (this.ClientSize.Width - playerBox.Width) / 2;
        //    playerBox.Top = (this.ClientSize.Height - playerBox.Height) / 2;
        //}

        //private void playerBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    playerBox.Focus(); // Ensure the player box has focus to receive key events
        //    int moveAmount = 10; // Amount to move the player box

        //    if (e.KeyCode == Keys.Left)
        //    {
        //        playerBox.Left -= moveAmount;
        //    }

        //    if (e.KeyCode == Keys.Right)
        //    {
        //        playerBox.Left += moveAmount;
        //    }

        //    //switch (e.KeyCode)
        //    //{
        //    //    case Keys.Left:
        //    //        playerBox.Left -= moveAmount;
        //    //        break;
        //    //    case Keys.Right:
        //    //        playerBox.Left += moveAmount;
        //    //        break;
        //    //}
        //}

        private void playerBox_KeyDown(object sender, EventArgs e)
        {
            playerBox.Refresh();

            int moveAmount = 10;

            if (playerBox.Location.X >= 1 && playerBox.Location.X <= 489)
            {

                if (e is KeyEventArgs keyEventArgs)
                {
                    if (keyEventArgs.KeyCode == Keys.Left)
                    {
                        playerBox.Left -= moveAmount;
                        playerBox.Refresh(); // Refresh the player box to update its position
                    }
                    else if (keyEventArgs.KeyCode == Keys.Right)
                    {
                        playerBox.Left += moveAmount;
                        playerBox.Refresh(); // Refresh the player box to update its position
                    }

                    playerBox.Refresh();

                }
            }

            else
            {
                if (playerBox.Location.X < 1)
                {
                    playerBox.Left = 1; // Prevent moving left beyond the boundary
                    playerBox.Refresh();
                }
                else if (playerBox.Location.X > 489)
                {
                    playerBox.Left = 489; // Prevent moving right beyond the boundary
                    playerBox.Refresh();
                }

                playerBox.Refresh();

            }
        }

        //public static void Main()
        //{
        //    Player player = new Player();

        //    player.Show();
        //    player.Width = 1000; // Set the width of the form
        //    player.Height = 500; // Set the height of the form

        //    Application.Run(new Player());
        //}
    }
}
