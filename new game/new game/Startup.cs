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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        Quit frm5 = new Quit();
        private void Startup_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Cover;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pictureBox1.Image = Properties.Resources.b21;
            pictureBox2.Image = Properties.Resources.b21;
            this.label1.Text = "Play";
            this.label1.BackColor = Color.White;
            this.label2.BackColor = Color.White;
            this.label1.ForeColor = Color.Green;
            this.label2.ForeColor = Color.Green;
            this.label2.Text = "Quit";
            this.ShowIcon = false;
            this.Cursor = Cursors.Hand;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            frm5.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm5.ShowDialog();
        }
    }
}
