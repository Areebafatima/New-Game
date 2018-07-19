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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        private void Message_Load(object sender, EventArgs e)
        {
            this.Text = "Memory Match";
            this.BackColor = Color.White;
            this.label1.BackColor = Color.Transparent;
            this.label1.ForeColor = Color.DarkMagenta;
            this.label1.Text = "CONGRATULATIONS !";
            this.label2.BackColor = Color.Transparent;
            this.label2.ForeColor = Color.Coral;
            this.label2.Text = "Hurrah !";
            this.button1.Text = "OK";
            this.button1.BackColor = Color.SteelBlue;
            this.button1.ForeColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.label3.Text = "You are won the match";
            this.label3.BackColor = Color.Transparent;
            this.label3.ForeColor = Color.ForestGreen;
        }
    }
}
