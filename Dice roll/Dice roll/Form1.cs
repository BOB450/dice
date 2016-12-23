using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_roll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 7);
            label1.Text = num.ToString();

           // if (num == 6)
           // {
             //   Application.Exit();
            //}
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 100);
            label1.Text = num.ToString();

        }
    }
}
