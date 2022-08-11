using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Task
{
    public partial class Form5 : Form
    {
        Timer t = new Timer();
        private static int clk = 0;
        private bool fClick = false;
        public static int max_clk = clk;
       
        public Form5()
        {
            InitializeComponent();
            t.Tick += button1_Click;
            t.Interval = 20000;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
                t.Stop();
                //if (clk == 0)
                //{
                //    MessageBox.Show("Ви нічого не клікали!", "Пробуйте ще!");
                //}
                      MessageBox.Show("Кількість кліків: " + clk, "Максимальний рекорд: " + max_clk, MessageBoxButtons.RetryCancel);  
               max_clk += clk;
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            t.Start();
            if (!fClick)
            {
                fClick = true;               
            }
            else
            {
                clk++;                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
