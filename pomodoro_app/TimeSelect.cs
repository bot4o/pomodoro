using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pomodoro_app
{
    public partial class TimeSelect : Form
    {
        private Work w;
        private ShortBrake sb;
        private LongBrake lb;
        private Form1 form1Instance;

        public TimeSelect(Form1 form1, Work work, ShortBrake shortBrake, LongBrake longBrake)
        {
            InitializeComponent();
            w = work;
            sb = shortBrake;
            lb = longBrake;
            form1Instance = form1;

            textBox1.Text = work.Minutes.ToString();
            textBox2.Text = shortBrake.Minutes.ToString();
            textBox3.Text = longBrake.Minutes.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidInteger(textBox1.Text) && IsValidInteger(textBox2.Text) && IsValidInteger(textBox3.Text))
            {
                w.Minutes = int.Parse(textBox1.Text);
                sb.Minutes = int.Parse(textBox2.Text);
                lb.Minutes = int.Parse(textBox3.Text);

                // Trigger the btn_work_Click method in Form1
                form1Instance.btn_work_Click(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Please enter valid integers in all three fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

        private bool IsValidInteger(string input)
        {
            int parsedValue;
            return int.TryParse(input, out parsedValue);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            w.Minutes = 25;
            sb.Minutes = 15;
            lb.Minutes = 60;

            form1Instance.btn_work_Click(null, EventArgs.Empty);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
