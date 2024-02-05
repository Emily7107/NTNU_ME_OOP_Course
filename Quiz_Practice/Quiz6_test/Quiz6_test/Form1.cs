using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz6_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            double density=0;
            switch(cb_material.SelectedIndex)
            {
                case 0:
                    density = 2.7;
                    break;
                case 1:
                    density = 7.87;
                    break;
                case 2:
                    density = 11.3;
                    break;
            }
            txt_density.Text = density.ToString();
        }

        private void cb_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_shape.SelectedIndex)
            {
                case 0:
                    lbl_1.Text = "半徑";
                    lbl_1.Visible = true;
                    txt_1.Visible = true;
                    lbl_2.Visible = false;
                    txt_2.Visible = false;
                    break;
                case 1:
                    lbl_1.Text = "邊長";
                    lbl_1.Visible = true;
                    txt_1.Visible = true;
                    lbl_2.Visible = false;
                    txt_2.Visible = false;
                    break;
                case 2:
                    lbl_1.Text = "半徑";
                    lbl_2.Text = "高";
                    lbl_1.Visible = true;
                    txt_1.Visible = true;
                    lbl_2.Visible = true;
                    txt_2.Visible = true;
                    break;
                case 3:
                    lbl_1.Text = "邊長";
                    lbl_2.Text = "高";
                    lbl_1.Visible = true;
                    txt_1.Visible = true;
                    lbl_2.Visible = true;
                    txt_2.Visible = true;
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            switch(cb_shape.SelectedIndex)
            {
                case 0:
                    Ball ball = new Ball(double.Parse(txt_density.Text), double.Parse(txt_1.Text));
                    txt_ball.Text = Ball.Amount.ToString();
                    txt_message.AppendText(ball.Message());
                    break;
                case 1:
                    Cube cube = new Cube(double.Parse(txt_density.Text), double.Parse(txt_1.Text));
                    txt_cube.Text = Cube.Amount.ToString();
                    txt_message.AppendText(cube.Message());
                    break;
                case 2:
                    Cylinder cylinder = new Cylinder(double.Parse(txt_density.Text), double.Parse(txt_1.Text),double.Parse(txt_2.Text));
                    txt_cylinder.Text = Cylinder.Amount.ToString();
                    txt_message.AppendText(cylinder.Message());
                    break;
                case 3:
                    Pyramid pyramid = new Pyramid(double.Parse(txt_density.Text), double.Parse(txt_1.Text), double.Parse(txt_2.Text));
                    txt_pyramid.Text = Pyramid.Amount.ToString();
                    txt_message.AppendText(pyramid.Message());
                    break;

            }
            int sum = Ball.Amount+ Cube.Amount+Cylinder.Amount+Pyramid.Amount;
            txt_sum.Text = sum.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_message.Text = "";
            txt_ball.Text = "";
            txt_cylinder.Text = "";
            txt_cube.Text = "";
            txt_pyramid.Text = "";
            txt_sum.Text = "";
        }
    }
}
