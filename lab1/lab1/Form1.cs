using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += " " + Environment.UserName;
            label2.Text += " " + Environment.MachineName;
            label3.Text += " " + Environment.OSVersion;
            label4.Text += " " + Environment.SystemDirectory;
            label5.Text += " " + Environment.ProcessorCount;
            label6.Text += " " + Environment.CurrentDirectory;
            if (Environment.Is64BitOperatingSystem == true)
            {
                label7.Text = "Разрядность системы: 64";
            }
            else
            {
                label7.Text = "Разрядность системы: 32";
            }
            if (Environment.Is64BitProcess == true)
            {
                label8.Text = "Разрядность процесса: 64";
            }
            else
            {
                label8.Text = "Разрядность процесса: 32";
            }
        }
    }

}