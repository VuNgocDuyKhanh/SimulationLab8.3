using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            decimal N = NumTrials.Value;
            decimal Prob5Value = N - (Prob1.Value + Prob2.Value + Prob3.Value + Prob4.Value);

            decimal n1 = Prob1.Value;
            decimal n2 = Prob2.Value;
            decimal n3 = Prob3.Value;
            decimal n4 = Prob4.Value;
            decimal n5 = Prob5Value;

            decimal p1 = n1 / N;
            decimal p2 = n2 / N;
            decimal p3 = n3 / N;
            decimal p4 = n4 / N;
            decimal p5 = n5 / N;

            chart1.Series[0].Points.AddXY(1, p1);
            chart1.Series[0].Points.AddXY(2, p2);
            chart1.Series[0].Points.AddXY(3, p3);
            chart1.Series[0].Points.AddXY(4, p4);
            chart1.Series[0].Points.AddXY(5, p5);
        }
    }
}
