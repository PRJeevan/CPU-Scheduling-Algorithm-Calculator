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
    public partial class FCFS : Form
    {
        public FCFS()
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
    }
}
