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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find the object";
            this.label1.ForeColor = Color.DarkOrange;
            this.label1.BackColor = Color.Transparent;
            this.BackColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.ShowIcon = false;
            pictureBox1.Image = Properties.Resources.Sofa;
            pictureBox2.Image = Properties.Resources.Flower;
            pictureBox3.Image = Properties.Resources.Pineapple;
            pictureBox4.Image = Properties.Resources.Pilayer1;
            pictureBox5.Image = Properties.Resources.Monkey;
            pictureBox6.Image = Properties.Resources.Keys;
            pictureBox7.Image = Properties.Resources.laptopfinal;
            pictureBox8.Image = Properties.Resources.Hoe;
            pictureBox9.Image = Properties.Resources.Black_Grapes;
            pictureBox10.Image = Properties.Resources.Banana;
            pictureBox11.Image = Properties.Resources.Book2;
            pictureBox12.Image = Properties.Resources.Box;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are Loser !!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are Loser !!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser !!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser !!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer! You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox mb = new MessageBox();
            mb.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bloomer!  You are loser", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
