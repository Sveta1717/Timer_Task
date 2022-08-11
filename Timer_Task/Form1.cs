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
    public partial class Form1 : Form
    {        
        Timer t = new Timer();        
        
        public Form1()
        {
            InitializeComponent();
            t.Interval = 10;
            t.Tick += button1_Move;           
        }

        private void button1_Move(object sender, EventArgs e)
        {            
                button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {                                   
              t.Start();
        }       
    }
}
