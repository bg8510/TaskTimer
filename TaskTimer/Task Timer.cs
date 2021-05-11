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
        Stopwatch stopwatch1, stopwatch2, stopwatch3, stopwatch4;
        int minutes1, minutes2, minutes3, minutes4;
        TimeSpan tspan1, tspan2, tspan3, tspan4;

        public Form1()
        {
            InitializeComponent();
            stopwatch1 = new Stopwatch();
            stopwatch2 = new Stopwatch();
            stopwatch3 = new Stopwatch();
            stopwatch4 = new Stopwatch();

        }
// -----------------------------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart1.Enabled = false;
            btnStopContinue1.Enabled = true;
            stopwatch1.Start();
        }

        private void btnStopContinue_Click(object sender, EventArgs e)
        {
            if(btnStopContinue1.Text == "Pause")
            {
                stopwatch1.Stop();
                btnStopContinue1.Text = "Continue";
                btnReset1.Enabled = true;

                tspan1 += stopwatch1.Elapsed;
                minutes1 = tspan1.Minutes;

                if (minutes1 < 22.5) minutes1 = 25;
                else if (minutes1 < 37.5) minutes1 = 50;
                else minutes1 = 75;

                string elapsedTime = tspan1.Hours.ToString() + "." + minutes1.ToString();
                lblTime1.Text = elapsedTime;
            }
            else
            {
                stopwatch1.Restart();
                btnStopContinue1.Text = "Pause";
                btnReset1.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch1.Reset();
            tspan1 = new TimeSpan();
            lblTime1.Text = "0.0";
            btnStart1.Enabled = true;
            btnStopContinue1.Text = "Pause";
            btnStopContinue1.Enabled = false;
            btnReset1.Enabled = false;
            timer1Description.Text = "";
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
// ------------------------------------------------------------------------------
        private void btnStart2_Click(object sender, EventArgs e)
        {
            btnStart2.Enabled = false;
            btnStopContinue2.Enabled = true;
            stopwatch2.Start();
        }

        private void btnStopContinue2_Click(object sender, EventArgs e)
        {
            if (btnStopContinue2.Text == "Pause")
            {
                stopwatch2.Stop();
                btnStopContinue2.Text = "Continue";
                btnReset2.Enabled = true;

                tspan2 += stopwatch2.Elapsed;
                minutes2 = tspan2.Minutes;

                if (minutes2 < 22.5) minutes2 = 25;
                else if (minutes2 < 37.5) minutes2 = 50;
                else minutes2 = 75;

                string elapsedTime = tspan2.Hours.ToString() + "." + minutes2.ToString();
                lblTime2.Text = elapsedTime;
            }
            else
            {
                stopwatch2.Restart();
                btnStopContinue2.Text = "Pause";
                btnReset2.Enabled = false;
            }
        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            stopwatch2.Reset();
            tspan2 = new TimeSpan();
            lblTime2.Text = "0.0";
            btnStart2.Enabled = true;
            btnStopContinue2.Text = "Pause";
            btnStopContinue2.Enabled = false;
            btnReset2.Enabled = false;
            timer2Description.Text = "";
        }
// ----------------------------------------------------------------------------------
        private void btnStart3_Click(object sender, EventArgs e)
        {
            btnStart3.Enabled = false;
            btnStopContinue3.Enabled = true;
            stopwatch3.Start();
        }

        private void btnStopContinue3_Click(object sender, EventArgs e)
        {
            if (btnStopContinue3.Text == "Pause")
            {
                stopwatch3.Stop();
                btnStopContinue3.Text = "Continue";
                btnReset3.Enabled = true;

                tspan3 = stopwatch3.Elapsed;
                minutes3 += tspan3.Minutes;

                if (minutes3 < 22.5) minutes3 = 25;
                else if (minutes3 < 37.5) minutes3 = 50;
                else minutes3 = 75;

                string elapsedTime = tspan3.Hours.ToString() + "." + minutes3.ToString();
                lblTime3.Text = elapsedTime;
            }
            else
            {
                stopwatch3.Restart();
                btnStopContinue3.Text = "Pause";
                btnReset3.Enabled = false;
            }
        }

        private void btnReset3_Click(object sender, EventArgs e)
        {
            stopwatch3.Reset();
            tspan3 = new TimeSpan();
            lblTime3.Text = "0.0";
            btnStart3.Enabled = true;
            btnStopContinue3.Text = "Pause";
            btnStopContinue3.Enabled = false;
            btnReset3.Enabled = false;
            timer3Description.Text = "";
        }
// -------------------------------------------------------------------------------
        private void btnStart4_Click(object sender, EventArgs e)
        {
            btnStart4.Enabled = false;
            btnStopContinue4.Enabled = true;
            stopwatch4.Start();
        }

        private void btnStopContinue4_Click(object sender, EventArgs e)
        {
            if (btnStopContinue4.Text == "Pause")
            {
                stopwatch4.Stop();
                btnStopContinue4.Text = "Continue";
                btnReset4.Enabled = true;

                tspan4 += stopwatch4.Elapsed;
                minutes4 = tspan4.Minutes;

                if (minutes4 < 22.5) minutes4 = 25;
                else if (minutes4 < 37.5) minutes4 = 50;
                else minutes4 = 75;

                string elapsedTime = tspan4.Hours.ToString() + "." + minutes4.ToString();
                lblTime4.Text = elapsedTime;
            }
            else
            {
                stopwatch4.Restart();
                btnStopContinue4.Text = "Pause";
                btnReset4.Enabled = false;
            }
        }

        private void btnReset4_Click(object sender, EventArgs e)
        {
            stopwatch4.Reset();
            tspan4 = new TimeSpan();
            lblTime4.Text = "0.0";
            btnStart4.Enabled = true;
            btnStopContinue4.Text = "Pause";
            btnStopContinue4.Enabled = false;
            btnReset4.Enabled = false;
            timer4Description.Text = "";
        }
    }
}