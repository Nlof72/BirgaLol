using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs
{
    public partial class Form1 : Form
    {
        Birga moscow;
        Person person;

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            person = new Person();
            moscow = new Birga((double)redCurs.Value,person);
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(moscow.days, moscow.rate);
        }
        const double k = 0.02;
        private void start_Click(object sender, EventArgs e)
        {
            start.Text = "Skip day";
            redCurs.Value = moscow.CalcCurs();
            chart1.Series[0].Points.AddXY(moscow.days, moscow.rate);
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 20;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            if (moscow.days <= 20) return;
            chart1.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = moscow.days - 20;
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<(int)redCount.Value; i++)
                moscow.SellDollars();
            UpdateInfo();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)redCount.Value; i++)
                moscow.BuyDollars();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            redScore.Text = Math.Round(person.score, 2) + "₽";
            redDoll.Text = person.dollars + "$";
        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            if(person.loans == 5)
            {
                person.score = -30000;
                UpdateInfo();
                return;
            }
            ++person.loans;
            person.score += 1000;
            UpdateInfo();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            redCurs.Value = moscow.CalcCurs();
            chart1.Series[0].Points.AddXY(moscow.days, moscow.rate);
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 20;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            if (moscow.days <= 20) return;
            chart1.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = moscow.days - 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Start Timer";
            }
            else
            {
                timer1.Start();
                button1.Text = "Stop Timer";
            }
        }
    }
}
