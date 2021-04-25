using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTimer
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStopContinue.Enabled = true;
            stopwatch.Start();
        }

        private void btnStopContinue_Click(object sender, EventArgs e)
        {
            if(btnStopContinue.Text == "Stop")
            {
                stopwatch.Stop();
                btnStopContinue.Text = "Continue";
                btnReset.Enabled = true;
            }
            else
            {
                stopwatch.Restart();
                btnStopContinue.Text = "Stop";
                btnReset.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lblTime.Text = "0";
            btnStart.Enabled = true;
            btnStopContinue.Text = "Stop";
        }
    }
}