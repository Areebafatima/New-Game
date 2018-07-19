using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_game
{
    public partial class Quit : Form
    {
        public Quit()
        {
            InitializeComponent();
        }

        private void Quit_Load(object sender, EventArgs e)
        {
            this.Text = "Confirm Quit";
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;
            this.label1.Text = "Are you sure you want to quit the game ?";
            this.label1.ForeColor = Color.Coral;
            pictureBox1.Image = Properties.Resources.yesB1;
           // pictureBox1.Image = Properties.Resources.b21;  
            pictureBox2.Image = Properties.Resources.noBt2;
            pictureBox3.Image = Properties.Resources.Information;
            this.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
