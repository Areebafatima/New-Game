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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        bool pb1 = false;
        bool pb2 = false;
        bool pb3 = false;

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Level 2";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.White;

            this.label1.Text = " Find the Objects ";
            this.label1.BackColor = Color.White;
            this.label1.ForeColor = Color.DarkMagenta;
            pictureBox1.Image = Properties.Resources.Axle;
            pictureBox2.Image = Properties.Resources.Chair;
            pictureBox3.Image = Properties.Resources.Banana;
            pictureBox4.Image = Properties.Resources.Bear;
            pictureBox5.Image = Properties.Resources.tool1img2;
            pictureBox6.Image = Properties.Resources.Umbrella;
            pictureBox7.Image = Properties.Resources.Van;
            pictureBox8.Image = Properties.Resources.Shirt;
            pictureBox9.Image = Properties.Resources.Sheep2;
            pictureBox10.Image = Properties.Resources.Book2;
            pictureBox11.Image = Properties.Resources.OnionLike;
            pictureBox12.Image = Properties.Resources.Mobile2;
            pictureBox13.Image = Properties.Resources.Lion;
            pictureBox14.Image = Properties.Resources.Keys;
            pictureBox15.Image = Properties.Resources.Dog1;
            checkBox1.Text = "Correct Object";
            checkBox2.Text = "Correct Object";
            checkBox3.Text = "Correct Object";
            checkBox1.ForeColor = Color.DarkMagenta;
            checkBox2.ForeColor = Color.Green;
            checkBox3.ForeColor = Color.DarkGoldenrod;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;

        }

        public void CheckforWinner()
        {
            if (pb1 == true && pb2 == true && pb3 == true)
            {
                MessageBox mb = new MessageBox();
                mb.Show();
                //Application.Exit();
            } 

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!","Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            checkBox1.Checked = true;
            pb1 = true;
            
            CheckforWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
            checkBox2.Checked = true;
            pb2 = true;
            CheckforWinner();
        }


        private void pictureBox12_Click(object sender, EventArgs e)
        {
            checkBox3.Visible = true;
            checkBox3.Checked = true;
            pb3 = true;
            CheckforWinner();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Loser !!", "Memory Match Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        
    }

}
