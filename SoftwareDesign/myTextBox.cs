using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign
{
    class myTextBox : TextBox
    {
        public void createTextBox(Form frm, string str, int x, int y, int width, int height, string name)
        {
            TextBox text = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                Text = str,
                Enabled = false,
                BackColor = Color.White,
                Name = name
            };
            frm.Controls.Add(text);
        }
    }
}
