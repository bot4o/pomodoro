using System.Reflection.Emit;
using System.Windows.Forms;
using System.Timers;
using System.IO.Packaging;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Metrics;

namespace pomodoro_app
{
    public partial class Form1 : Form
    {
        private bool togglebtn = false;
        private bool b = false;
        private int counter = 1;
        private int halfCounter = 1;

        private int totalCount = 8;

        private Work w = new Work();
        private LongBrake lb = new LongBrake();
        private ShortBrake sb = new ShortBrake();

        public int currentMinutes;
        public int currentSeconds;
        private Color theme = Color.FromArgb(24, 24, 127);

        public Form1()
        {
            InitializeComponent();
            this.currentMinutes = w.Minutes;
            this.currentSeconds = w.Seconds;
            btn_work.BackColor = Color.Black;
            this.BackColor = theme;
            labelTimer.Text = $"{w.Minutes:00}:{w.Seconds:00}";
            this.BackColor = w.Theme;
            labelCounter.Text += counter.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            UpdateToggleButtonAppearance();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            togglebtn = !togglebtn;
            UpdateToggleButtonAppearance();

            if (togglebtn)
            {
                timerCountdown.Start();
            }
            else
            {
                timerCountdown.Stop();
            }
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            if (currentMinutes == 0 && currentSeconds == 0)
            {

                timerCountdown.Stop();
                if (counter == totalCount)
                {
                    counter = 1;
                    halfCounter = 1;
                    MessageBox.Show("End!!!");
                    Application.Exit();
                }

                if (b == true)
                {
                    btn_work.PerformClick();
                    counter++;
                    halfCounter++;
                    labelCounter.Text = counter.ToString();
                }
                else if (halfCounter >= 4)
                {
                    halfCounter = 0;
                    btn_lbreak.PerformClick();
                }
                else
                {
                    btn_sbreak.PerformClick();
                }


            }
            else if (currentSeconds == 0)
            {
                currentMinutes--;
                currentSeconds = 59;
            }
            else
            {
                currentSeconds--;
            }


        }
        public void btn_work_Click(object sender, EventArgs e)
        {
            b = false;
            TimerReset();
            this.currentMinutes = w.Minutes;
            this.currentSeconds = w.Seconds;
            this.theme = w.Theme;
            UpdateTimeLabel();

            btn_work.BackColor = Color.Black;
            btn_sbreak.BackColor = default;
            btn_lbreak.BackColor = default;
        }
        private void btn_sbreak_Click(object sender, EventArgs e)
        {
            TimerReset();
            b = true;
            this.currentMinutes = sb.Minutes;
            this.currentSeconds = sb.Seconds;
            this.theme = sb.Theme;
            UpdateTimeLabel();

            btn_work.BackColor = default;
            btn_sbreak.BackColor = Color.Black;
            btn_lbreak.BackColor = default;
        }
        private void btn_lbreak_Click(object sender, EventArgs e)
        {
            TimerReset();
            b = true;
            this.currentMinutes = lb.Minutes;
            this.currentSeconds = lb.Seconds;
            this.theme = lb.Theme;
            UpdateTimeLabel();

            btn_work.BackColor = default;
            btn_sbreak.BackColor = default;
            btn_lbreak.BackColor = Color.Black;
        }
        private void UpdateToggleButtonAppearance()
        {
            if (togglebtn)
            {
                btnStart.Text = "PAUSE";
            }
            else
            {
                btnStart.Text = "START";
            }
        }
        public void UpdateTimeLabel()
        {
            labelTimer.Text = $"{currentMinutes:00}:{currentSeconds:00}";
            this.BackColor = theme;
        }
        public void TimerReset()
        {
            timerCountdown.Stop();
            if (btnStart.Text != "START")
            {
                togglebtn = !togglebtn;
            }
            UpdateToggleButtonAppearance();
        }
        //menu strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f2 = new TimeSelect(w, sb, lb);
            f2.Show();
        }
    }
}