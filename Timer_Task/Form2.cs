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
    public partial class Form2 : Form
    {
        Timer t = new Timer();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        public Form2()
        {
            InitializeComponent();
            Text = timer.ElapsedMilliseconds.ToString();
            t.Tick += Form2_Load;
            timer.Start();  
            t.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Text = timer.ElapsedMilliseconds.ToString();    
        }
    }
}
