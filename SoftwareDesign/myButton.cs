using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SoftwareDesign
{
    class myButton : Button
    { 

        public void createButton(Form frm, string str, int x, int y, int width, int height, EventHandler evh)
        {
            Button btn;
            btn = new Button
            {
                Text = str,
                Location = new Point(x, y),
                Size = new Size(width, height)
            };
            btn.Click += evh;
            frm.Controls.Add(btn);
        }

    }
}
