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
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        private void Exit_Load(object sender, EventArgs e)
        {
            this.Text = "Memory Match Game , Game Over";
            this.BackgroundImage = Properties.Resources.Congratz1A;
            pictureBox1.Image = Properties.Resources.Happyface1;
            button1.Text = "Quit";
            button2.Text = "Next";
            button1.BackColor = Color.DarkGoldenrod;
            button2.BackColor = Color.DarkGoldenrod;
            //label1.Text = "Hurrah !! You Won !!";
            //label1.BackColor = Color.Transparent;
            //label1.ForeColor = Color.DarkMagenta;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button2.FlatStyle = FlatStyle.Popup;
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Quit qt = new Quit();
            qt.ShowDialog();
        }

        }
    }

