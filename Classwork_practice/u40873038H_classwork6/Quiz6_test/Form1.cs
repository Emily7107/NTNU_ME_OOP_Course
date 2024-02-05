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
        private Ball[] ballArr = new Ball[100];
        private Cube[] cubeArr = new Cube[100];
        private Cylinder[] cylinderArr = new Cylinder[100];
        private Pyramid[] pyramidArr = new Pyramid[100];
        private void cb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            double density= 0;
            switch (cb_material.SelectedIndex)
            {
                case 0:
                    density = 2.70;
                    break;
                case 1:
                    density=7.87;
                    break;
                case 2:
                    density = 11.30;
                    break;
            }
            txt_density.Text = density.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            int sum;
            switch(cb_shape.SelectedIndex)
            {
                case 0:
                    ballArr[Ball.Amount] = new Ball(double.Parse(txt_density.Text), double.Parse(txt_1.Text));
                    txt_ball.Text = Ball.Amount.ToString();
                    txt_message.AppendText(ballArr[Ball.Amount-1].Message());
                    break;
                case 1:
                    cubeArr[Cube.Amount] = new Cube(double.Parse(txt_density.Text), double.Parse(txt_1.Text));
                    txt_cube.Text = Cube.Amount.ToString();
                    txt_message.AppendText(cubeArr[Cube.Amount-1].Message());
                    break;
                case 2:
                    cylinderArr[Cylinder.Amount] = new Cylinder(double.Parse(txt_density.Text), double.Parse(txt_1.Text),double.Parse(txt_2.Text));
                    txt_cylinder.Text = Cylinder.Amount.ToString();
                    txt_message.AppendText(cylinderArr[Cylinder.Amount-1].Message());
                    break;
                case 3:
                    pyramidArr[Pyramid.Amount] = new Pyramid(double.Parse(txt_density.Text), double.Parse(txt_1.Text), double.Parse(txt_2.Text));
                    txt_pyramid.Text = Pyramid.Amount.ToString();
                    txt_message.AppendText(pyramidArr[Pyramid.Amount-1].Message());
                    break;

            }
            sum = Ball.Amount+ Cube.Amount+Cylinder.Amount+ Pyramid.Amount;
            txt_sum.Text = sum.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_message.Text = "";
            txt_ball.Text = "";
            txt_cube.Text = "";
            txt_pyramid.Text = "";
            txt_cylinder.Text = "";
            txt_sum.Text = "";
            txt_compare.Text = "";
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            Ball maxball=new Ball();
            Cube maxcube = new Cube();
            Cylinder maxcylinder = new Cylinder();
            Pyramid maxpyramid = new Pyramid();
            for(int i=0;i<Ball.Amount-1;i++)
            {
                if (ballArr[i].Weight() > maxball.Weight())
                    maxball = ballArr[i];
            }
            for (int i = 0; i < Cube.Amount-1; i++)
            {
                if (cubeArr[i].Weight() > maxcube.Weight())
                    maxcube = cubeArr[i];
            }
            for (int i = 0; i < Cylinder.Amount-1; i++)
            {
                if (cylinderArr[i].Weight() > maxcylinder.Weight())
                    maxcylinder = cylinderArr[i];
            }
            for (int i = 0; i < Pyramid.Amount-1; i++)
            {
                if (pyramidArr[i].Weight() > maxpyramid.Weight())
                    maxpyramid = pyramidArr[i];
            }
            if (maxball.Weight() > maxcube.Weight() && maxball.Weight() > maxcylinder.Weight() && maxball.Weight() > maxpyramid.Weight())
                txt_compare.Text = maxball.Message();
            else if(maxcube.Weight()>maxball.Weight()&& maxcube.Weight() > maxcylinder.Weight()&& maxcube.Weight() > maxpyramid.Weight())
                txt_compare.Text = maxcube.Message();
            else if(maxcylinder.Weight()>maxball.Weight()&& maxcylinder.Weight() > maxcube.Weight()&& maxcylinder.Weight() > maxpyramid.Weight())
                txt_compare.Text = maxcylinder.Message();
            else
                txt_compare.Text = maxpyramid.Message();
        }
    }
}
