using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Splash : Form
    {
        public int timeLeft { get; set; }

        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft -= 1;
            }
            else
            {
                timer1.Stop();
                new Parent().Show();
                this.Hide();
            }
        }

        private void Splash_Load_1(object sender, EventArgs e)
        {
            timeLeft = 3;
            timer1.Start();
        }
    }
}
