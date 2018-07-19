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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private Timer tm;
        private void Form3_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 2 * 1000;
            tm.Tick += new EventHandler(tm_Tick);
            tm.Start();
            this.Text = "Level 2";
            //this.BackColor = Color.White;
            this.BackgroundImage = Properties.Resources.Background1a;
            this.label1.Text = "Remeber the objects ";
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = Color.Chocolate;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            pictureBox1.Image = Properties.Resources.Mobile;
            pictureBox2.Image = Properties.Resources.Sheep;
            pictureBox3.Image = Properties.Resources.tool1;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
    }
}
