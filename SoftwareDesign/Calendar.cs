using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign
{
    class Calendar
    {
        public void outCurrentMonth(Form1 frm, DateTime date)
        {
            int pogt = DateTime.DaysInMonth(date.Year, date.Month);
            int i = 1 - WeekNumber(date.DayOfWeek);
            foreach (var btn in frm.Controls.OfType<Button>())
            {
                if (btn.Text == " -> " || btn.Text == " <- ")
                {
                    continue;
                }
                if (i <= pogt && i > 0)
                {
                    btn.Text = i.ToString();
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.Text = " - ";
                    btn.BackColor = Color.Red;
                }
                i++;
            }
            var text = frm.Controls["year"];
            text.Text = date.Year.ToString();
            text = frm.Controls["month"];
            text.Text = date.Month.ToString();
        }

        private int WeekNumber(DayOfWeek dayOfWeek)
        {
            try
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Monday:
                        return 0;
                    case DayOfWeek.Tuesday:
                        return 1;
                    case DayOfWeek.Wednesday:
                        return 2;
                    case DayOfWeek.Thursday:
                        return 3;
                    case DayOfWeek.Friday:
                        return 4;
                    case DayOfWeek.Saturday:
                        return 5;
                    case DayOfWeek.Sunday:
                        return 6;
                    default:
                        throw new ArgumentNullException(paramName: nameof(dayOfWeek), message: "day of week cant be null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
