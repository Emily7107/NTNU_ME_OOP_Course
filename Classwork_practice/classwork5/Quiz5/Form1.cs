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
            InitializeDynamicTextBox();
        }
        private TextBox[,] txt;
        private void InitializeDynamicTextBox()
        {
            txt = new System.Windows.Forms.TextBox[3, 2];
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 1; j++)
                    this.txt[i, j] = new System.Windows.Forms.TextBox();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                    this.grp_coordenter.Controls.Add(this.txt[i, j]);
            }
            int xPos = 80;
            int yPos = 37;
            int xInc = 125;
            int yInc = 30;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    this.txt[i, j].Location = new System.Drawing.Point(xPos + j * xInc, yPos + i * yInc);
                    this.txt[i, j].Size = new System.Drawing.Size(100, 25);
                }
            }
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string message= "";
            Triangle point = new Triangle();
            point.CreatePoints();
            point.ptArr[0].xCoord = double.Parse(txt[0,0].Text);
            point.ptArr[0].yCoord = double.Parse(txt[0,1].Text);
            point.ptArr[1].xCoord = double.Parse(txt[1,0].Text);
            point.ptArr[1].yCoord = double.Parse(txt[1,1].Text);
            point.ptArr[2].xCoord = double.Parse(txt[2,0].Text);
            point.ptArr[2].yCoord = double.Parse(txt[2,1].Text);
            
            if (point.isValid())
            {
                if (chk_area.Checked)
                    message += ("Area=" + point.Area().ToString() + Environment.NewLine);
                if (chk_perimeter.Checked)
                    message += ("Perimeter=" + point.Perimeter().ToString() + Environment.NewLine);
                if(chk_Tritype.Checked)
                {
                    switch(point.ShapeType())
                    {
                        case 1:
                            message += "本三角形為直角三角形!";
                            break;
                        case 2:
                            message += "本三角形為銳角三角形!";
                            break;
                        case 3:
                            message += "本三角形為鈍角三角形!";
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
