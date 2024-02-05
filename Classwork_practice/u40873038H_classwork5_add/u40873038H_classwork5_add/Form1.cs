using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u40873038H_classwork5_add
{
    public partial class Form1 : Form
    {
        private RadioButton[,] rad;
        private GroupBox[,] group;
        private TextBox[,] txt;
        private int count = 0;
        private string message = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_create_Click(object sender, EventArgs e)
        {
            if (grp_visualization.Controls.Count > 0)
                ClearAllObjectInVisualization();
            if (grp_coordinate.Controls.Count > 5)
                ClearAlltextboxInCoordinate();
            int rows = Convert.ToInt32(txt_intputrow.Text);
            int cols = Convert.ToInt32(txt_intputcol.Text);
            rad = new RadioButton[rows, cols];
            group = new GroupBox[rows, cols];
            txt = new TextBox[3, 4];
            int rd_xpos = 5;
            int rd_ypos = 9;
            int gb_xpos = 10;
            int gb_ypos = 15;
            int tx_xpos = 22;
            int tx_ypos = 60;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.rad[i, j] = new RadioButton();
                    this.group[i, j] = new GroupBox();
                    this.group[i, j].Controls.Add(this.rad[i, j]);
                    this.group[i, j].Size = new System.Drawing.Size(25, 25);
                    this.group[i, j].Location = new System.Drawing.Point(gb_xpos + j * 36, gb_ypos + i * 30);
                    this.rad[i, j].Size = new System.Drawing.Size(17, 16);
                    this.rad[i, j].Location = new System.Drawing.Point(rd_xpos, rd_ypos);
                    this.grp_visualization.Controls.Add(this.group[i, j]);
                    this.rad[i, j].Name = "rad_" + (i + j).ToString();
                    this.rad[i, j].CheckedChanged += new EventHandler(this.RadiobuttonChecked);
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    this.txt[i, j] = new TextBox();
                    this.grp_coordinate.Controls.Add(txt[i, j]);
                    this.txt[i, j].Size = new System.Drawing.Size(50, 29);
                    this.txt[i, j].Location = new System.Drawing.Point(tx_xpos + j * 80, tx_ypos + i * 35);
                    if (j >= 2)
                    {
                        this.txt[i, j].Text = "0";
                        this.txt[i, j].Enabled = false;
                    }
                }
            }
            txt_intputrow.Enabled = false;
            txt_intputcol.Enabled = false;
            txt_xInterval.Enabled = false;
            txt_YInterval.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(txt_intputrow.Text);
            int cols = Convert.ToInt32(txt_intputcol.Text);
                count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.rad[i, j].Checked = false;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    this.rad[i, j].Enabled = true;
            }
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 3; j++)
                    txt[i, j].Text = "";
            }
            txt_intputrow.Enabled = true;
            txt_intputcol.Enabled = true;
            txt_xInterval.Enabled = true;
            txt_YInterval.Enabled = true;
        }
        private void RadiobuttonChecked(object sender, EventArgs e)
        {
            int k = 0, h = 0;
            RadioButton num = (RadioButton)sender;
            int rows = int.Parse(txt_intputrow.Text);
            int cols = int.Parse(txt_intputcol.Text);
            if (num.Checked == true)
                count += 1;
            if (count <= 3)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (rad[i, j].Checked == true)
                        {
                            txt[k, h].Text = i.ToString();
                            txt[k, h + 1].Text = j.ToString();
                            k++;
                            h = 0;
                        }
                        else if (count == 3)
                            this.rad[i, j].Enabled = false;
                    }
                }
            }
            coordinate();
        }
        private void ClearAllObjectInVisualization()
        {
            while (grp_visualization.Controls.Count > 0)
            {
                foreach (Control item in rad)
                {
                    item.Dispose();
                }
                foreach (Control item in group)
                {
                    item.Dispose();
                }
            }
        }
        private void coordinate()
        {
            int xinterval = Convert.ToInt32(txt_xInterval.Text);
            int yinterval = Convert.ToInt32(txt_YInterval.Text);
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    if (txt[i, j].Text != "")
                    {
                        if (j == 0)
                            txt[i, j + 3].Text = (yinterval * (int.Parse(txt[i, j].Text))).ToString();
                        else
                            txt[i, j + 1].Text = (xinterval * (int.Parse(txt[i, j].Text))).ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle p = new Triangle();
            p.CreatePoints();
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 2; j <= 3; j++)
                {
                    if (j == 2)
                        p.ptArr[i].xCoord = double.Parse(txt[i, j].Text);
                    else
                        p.ptArr[i].yCoord = double.Parse(txt[i, j].Text);
                }
            }
            if (p.isValid())
            {
                message += ("Area = " + p.Area().ToString() + "\r\n");
                message += ("Perimeter = " + p.Perimeter().ToString() + "\r\n");
                switch (p.ShapeType())
                {
                    case 1:
                        message += ("本三角形為直角三角形" + "\r\n");
                        break;
                    case 2:
                        message += ("本三角形為銳角三角形" + "\r\n");
                        break;
                    case 3:
                        message += ("本三角形為鈍角三角形" + "\r\n");
                        break;
                    default:
                        message += ("Error" + "\r\n");
                        break;
                }

            }
            else
                message += ("此三點無法形成三角形" + "\r\n");
            textBox5.Text = message;
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            message = "";
        }
        private void ClearAlltextboxInCoordinate()
        {
            while (grp_coordinate.Controls.Count > 5)
            {
                foreach (Control item in txt)
                {
                    item.Dispose();
                }
            }
        }
    }
}
