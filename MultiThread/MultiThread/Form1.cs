using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            progressBar1.Maximum = 100000;
            progressBar2.Maximum = 100000;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Loop1);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Loop2);
            thread.Start();

        }

        void Loop1()
        {
            for (int i = 0; i < 100000; i++)
            {
                progressBar1.Value++;
            }
        }
        void Loop2()
        {
            for (int i = 0; i < 100000; i++)
            {

                progressBar2.Value++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Loop1);

            Thread thread = new Thread(Loop2);
            thread1.Start();
            thread.Start();

        }
    }
}
