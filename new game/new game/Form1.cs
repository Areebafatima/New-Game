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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Timer tm;
        private void Form1_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 2 * 1000;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
            this.Text = "Level 1";
            this.label1.Text = "Remeber this picture ";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pictureBox1.Image = Properties.Resources.pic1;
            this.BackgroundImage = Properties.Resources.Background1;
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = Color.DarkOrange;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
