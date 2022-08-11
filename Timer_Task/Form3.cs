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
    public partial class Form3 : Form
    {
        private Timer t = new Timer();
        DateTime date_now = DateTime.Now;
        DateTime date_independency = new DateTime(2022, 08, 24, 0, 0, 0);

        private void label1_Move(object sender, EventArgs e)
        {
            label1.Text = "До дня Незалежності залишилось: " + date_independency.Subtract(date_now).ToString();
        }

        public Form3()
        {
            InitializeComponent();
            
            t.Tick += label1_Move;
            t.Interval = 1;
            t.Start();           
        }       
    }
}
