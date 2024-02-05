using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u40873038H_Quiz6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            double density;
            switch(cb_material.SelectedIndex)
            {
                case 0:
                    density = 2.7;
                    txt_showD.Text = density.ToString();
                    break;
                case 1:
                    density = 7.87;
                    txt_showD.Text = density.ToString();
                    break;
                case 2:
                    density = 11.3;
                    txt_showD.Text = density.ToString();
                    break;
                default:
                    break;
            }
        }

        private void cb_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_shape.SelectedIndex)
            {
                case 0:
                    lbl_radius.Text = "半徑";
                    lbl_radius.Visible = true;
                    txt_radius.Visible = true;
                    lbl_high.Visible = false;
                    txt_high.Visible = false;
                    break;
                case 1:
                    lbl_radius.Text = "邊長";
                    lbl_radius.Visible = true;
                    txt_radius.Visible = true;
                    lbl_high.Visible = false;
                    txt_high.Visible = false;
                    break;
                case 2:
                    lbl_radius.Text = "半徑";
                    lbl_high.Text = "高度";
                    lbl_radius.Visible = true;
                    txt_radius.Visible = true;
                    lbl_high.Visible = true;
                    txt_high.Visible = true;
                    break;
                case 3:
                    lbl_radius.Text = "邊長";
                    lbl_high.Text = "高度";
                    lbl_radius.Visible = true;
                    txt_radius.Visible = true;
                    lbl_high.Visible = true;
                    txt_high.Visible = true;
                    break;
            }
        }

        private void btn_amount_Click(object sender, EventArgs e)
        {
            
            switch(cb_shape.SelectedIndex)
            {
                case 0:
                    Ball ball =new Ball(double.Parse(txt_showD.Text),double.Parse(txt_radius.Text));
                    txt_message.AppendText(ball.ShowMessage());
                    txt_ball.Text = Ball.Amount.ToString();
                    break;
                case 1:
                    Cube cube =new Cube(double.Parse(txt_showD.Text), double.Parse(txt_radius.Text));
                    txt_message.AppendText(cube.ShowMessage());
                    txt_cube.Text = Cube.Amount.ToString();
                    break;
                case 2:
                    Cylinder cylinder = new Cylinder(double.Parse(txt_showD.Text), double.Parse(txt_radius.Text),double.Parse(txt_high.Text));
                    txt_message.AppendText(cylinder.ShowMessage());
                    txt_cylinder.Text = Cylinder.Amount.ToString();
                    break;
                case 3:
                    Pyramid pyramid = new Pyramid(double.Parse(txt_showD.Text), double.Parse(txt_radius.Text), double.Parse(txt_high.Text));
                    txt_message.AppendText(pyramid.ShowMessage());
                    txt_pyramid.Text = Pyramid.Amount.ToString();
                    break;

            }
            int sum = Ball.Amount+Cube.Amount+Cylinder.Amount+ Pyramid.Amount;
            txt_amount.Text = sum.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_message.Text = "";
            txt_amount.Text = "";
            txt_ball.Text = "";
            txt_cube.Text = "";
            txt_cylinder.Text = "";
            txt_pyramid.Text = "";
        }
    }
}
