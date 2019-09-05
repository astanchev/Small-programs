using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Letter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int stopAndStart = 0;
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (stopAndStart == 0)
            {
                timer1.Enabled = true;
                stopAndStart = 1;
                buttonRun.Text = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                stopAndStart = 0;
                buttonRun.Text = "Start";
            }
        }

        private char[] cirilicLetters =
        {
            'А', 'Б', 'В', 'Г', 'Д',
            'Е', 'Ж', 'З', 'И', 'Й',
            'К', 'Л', 'М', 'Н', 'О',
            'П', 'Р', 'С', 'Т', 'У',
            'Ф', 'Х', 'Ц', 'Ч', 'Ъ',
            'ь', 'Ю', 'Я'
        };
        private int increment = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            increment++;
            label.Text = cirilicLetters[increment].ToString();
            if (increment == cirilicLetters.Length - 1)
            {
                increment = 0;
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
