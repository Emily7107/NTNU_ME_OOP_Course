using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u40873038H_Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_calculate_Click(object sender, EventArgs e)
        {
            Triangle p = new Triangle();
            string message = "";
            p.CreatePoints();
            p.ptArr[0].xCoord = double.Parse(txt_x1.Text);
            p.ptArr[0].yCoord = double.Parse(txt_y1.Text);
            p.ptArr[1].xCoord = double.Parse(txt_x2.Text);
            p.ptArr[1].yCoord = double.Parse(txt_y2.Text);
            p.ptArr[2].xCoord = double.Parse(txt_x3.Text);
            p.ptArr[2].yCoord = double.Parse(txt_y3.Text);
            if (p.isValid())
            {
                if (chk_area.Checked)
                    message += "Area=" + p.Area().ToString() + Environment.NewLine;
                if (chk_perimeter.Checked)
                    message += "Perimeter=" + p.Perimeter().ToString() + Environment.NewLine;
                if (chk_type.Checked)
                {
                    switch (p.ShapeType())
                    {
                        case 1:
                            message += "本三角形為直角三角形";
                            break;
                        case 2:
                            message += "本三角形為銳角三角形";
                            break;
                        case 3:
                            message += "本三角形為鈍角三角形";
                            break;
                    }
                }
            }
            else
                message = "此三點無法形成三角形";
            txt_output.Text = message;
        }
    }
}
