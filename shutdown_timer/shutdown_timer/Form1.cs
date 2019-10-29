using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace shutdown_timer
{
    public partial class Form1 : Form
    {
        String ProcessType;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", ProcessType + " /t " + textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    ProcessType = "/s";
                    break;
                case 1:
                    ProcessType = "/r";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", ProcessType + " /t " + textBox1.Text);
        }
    }
}
