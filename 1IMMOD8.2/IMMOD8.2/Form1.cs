using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMMOD8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] P = new double[5];

            P[0] = P[1] = P[2] = P[3] = P[4]= 0.2;

            string[] Text = new string[5];
            Text[0] = "Спроси позже";
            Text[1] = "Нельзя сказать точно";
            Text[2] = "Бесспорно";
            Text[3] = "Нет";
            Text[4] = "Вероятнее всего";

            Random rand = new Random();
            double alfa = rand.NextDouble();

            double A = alfa;
            int k = 0;
            while (A > 0)
            {
                A = A - P[k];
                k++;
            }

            k = k - 1;

            if (k == 0)
            {
                label2.Text = Text[0];
                label2.Visible = true;
            }
            else
                if (k == 1)
            {
                label2.Text = Text[1];
                label2.Visible = true;
            }
            if (k == 2)
            {
                label2.Text = Text[2];
                label2.Visible = true;
            }
            else
            if (k == 3)
            {
                label2.Text = Text[3];
                label2.Visible = true;
            }
            else
            if (k == 4)
            {
                label2.Text = Text[4];
                label2.Visible = true;
            }


        }
    }
}
