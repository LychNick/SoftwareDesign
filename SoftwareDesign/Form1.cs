using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign
{
    public partial class Form1 : Form
    {
        myButton test = new myButton();
        myTextBox textBox = new myTextBox();
        Calendar cal = new Calendar();
        private const int K = 75;

        DateTime date;
        public Form1()
        {
            InitializeComponent();
            date = DateTime.Now.AddDays(-1 * DateTime.Now.Day + 1);
            String str;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    str = Convert.ToString((i * 7) + j);
                    test.createButton(this, str, j * K, (i * K + 25), K, K, Click_conf);
                }
            }
            textBox.createTextBox(this, "current year", K * 8 + 10, 0, K, K, "yearText");
            textBox.createTextBox(this, " ", K * 8 + 10 + K, 0, K, K, "year");
            textBox.createTextBox(this, "current month", K * 8 + 10, 25, K, K, "monthText");
            textBox.createTextBox(this, " ", K * 8 + 10 + K, 25, K, K, "month");

            DayOfWeek dw = DayOfWeek.Monday;
            for (int i = 0; i < 7; i++)
            {
                textBox.createTextBox(this, dw.ToString(), (i * K + K), 0, K, K, dw.ToString());
                dw++;
                if (Convert.ToInt32(dw) == 7) { dw = DayOfWeek.Sunday; }
            }

            cal.outCurrentMonth(this, date);

            Button btn;
            btn = new Button
            {
                Text = " -> ",
                Location = new Point(8 * K, 6 * K / 2),
                Size = new Size(K, K)
            };
            btn.Click += button1_Click;
            this.Controls.Add(btn);

            btn = new Button
            {
                Text = " <- ",
                Location = new Point(0, 6 * K / 2),
                Size = new Size(K, K)
            };
            btn.Click += button2_Click;
            this.Controls.Add(btn);
        }

        public void Click_conf(Object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Yellow)
            {
                (sender as Button).BackColor = Color.Blue;
            }
            else
                (sender as Button).BackColor = Color.Yellow;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(1);
            cal.outCurrentMonth(this, date);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(-1);
            cal.outCurrentMonth(this, date);
        }
    }
}
