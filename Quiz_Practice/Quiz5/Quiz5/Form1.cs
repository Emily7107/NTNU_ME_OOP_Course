using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string message= "";
            Triangle point = new Triangle();
            point.CreatePoints();
            point.ptArr[0].xCoord = double.Parse(txt_x1.Text);
            point.ptArr[0].yCoord = double.Parse(txt_y1.Text);
            point.ptArr[1].xCoord = double.Parse(txt_x2.Text);
            point.ptArr[1].yCoord = double.Parse(txt_y2.Text);
            point.ptArr[2].xCoord = double.Parse(txt_x3.Text);
            point.ptArr[2].yCoord = double.Parse(txt_y3.Text);
            if (point.isValid())
            {
                if (chk_area.Checked)
                    message += ("Area=" + point.Area().ToString() + Environment.NewLine);

                if (chk_perimeter.Checked)
                    message += ("Perimeter=" + point.Perimeter().ToString() + Environment.NewLine);
                    txt_output.AppendText("Perimeter=" + point.Perimeter().ToString() + "\n");
                if (chk_Tritype.Checked)
                {
                    switch (point.ShapeType())
                    {
                        case 1:
                            message += "本三角形為直角三角形!";
                            txt_output.Text="本三角形直角三角形!";
                            break;
                        case 2:
                            message += "本三角形為銳角三角形!";
                            MessageBox.Show("本三角形銳角三角形!");
                            break;
                        case 3:
                            message += "本三角形為鈍角三角形!";
                            MessageBox.Show("本三角形鈍角三角形!");
                            break;
                    }
                }
            }
            else
                message+=("此三點無法形成三角形!");
            txt_output.Text=message;
        }
    }
}
