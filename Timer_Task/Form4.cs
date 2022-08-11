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
    //enum Colors {Black, Red, Yellow, Green, SkyBlue, Blue, Pink, White };

    public partial class Form4 : Form
    {
        Timer t = new Timer();
        float step = 0;        
        Random rnd = new Random();
        //private IEnumerable<Color> colors;

        Color one = Color.Black;
        Color two = Color.White;


        public Form4()
        {
            InitializeComponent();
            t.Tick += Form4_BackColorChanged;
            t.Interval = 500;
            t.Start();
        }

        private void Form4_BackColorChanged(object sender, EventArgs e)
        {
            if (step >= 1f)
            {
                step = 0;

                int R = rnd.Next(0, 255);
                int G = rnd.Next(0, 255);
                int B = rnd.Next(0, 255);
                one = two;
                two = Color.FromArgb(R, G, B);
            }
            int mixR = (int)(one.R * (1f - step) + two.R * step);
            int mixG = (int)(one.G * (1f - step) + two.G * step);
            int mixB = (int)(one.B * (1f - step) + two.B * step);
            this.BackColor = Color.FromArgb(mixR, mixG, mixB);

            step += 0.05f;          
        }       
    }
}
