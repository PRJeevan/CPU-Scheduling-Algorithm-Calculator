using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPU_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            n = 1;
            ProgramForm P = new ProgramForm();
            this.Hide();
            P.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = 2;
            ProgramForm P = new ProgramForm();
            this.Hide();
            P.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 3;
            ProgramForm P = new ProgramForm();
            this.Hide();
            P.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = 4;
            ProgramForm P = new ProgramForm();
            this.Hide();
            P.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
