using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midexam_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_material.SelectedIndex = 0;
            cb_shape.SelectedIndex = 0;
            cb_sortType.SelectedIndex = 0;
        }
        private ShapeType.Material mType;
        private List<Shape3D> shapeArr = new List<Shape3D>();
        private List<IRollable> rollArr = new List<IRollable>();
        private delegate bool CompareFunc(Shape3D a, Shape3D b);

        private void cb_material_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = cb_material.SelectedItem.ToString();
            mType = MaterialTable.Type(material);
            txt_density.Text = MaterialTable.Density(material).ToString();
        }

        private void cb_shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_shape.SelectedItem.ToString())
            {
                case "球":
                    lbl_1.Text = "半徑";
                    lbl_1.Visible = true;
                    lbl_2.Visible = false;
                    txt_1.Visible = true;
                    txt_2.Visible = false;
                    break;
                case "立方體":
                    lbl_1.Text = "邊長";
                    lbl_1.Visible = true;
                    lbl_2.Visible = false;
                    txt_1.Visible = true;
                    txt_2.Visible = false;
                    break;
                case "圓柱體":
                    lbl_1.Text = "半徑";
                    lbl_2.Text = "高";
                    lbl_1.Visible = true;
                    lbl_2.Visible = true;
                    txt_1.Visible = true;
                    txt_2.Visible = true;
                    break;
                case "金字塔":
                    lbl_1.Text = "邊長";
                    lbl_2.Text = "高";
                    lbl_1.Visible = true;
                    lbl_2.Visible = true;
                    txt_1.Visible = true;
                    txt_2.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            switch(cb_shape.SelectedItem.ToString())
            {
                case "球":
                    shapeArr.Add(new Ball(double.Parse(txt_1.Text), mType));
                    break;
                case "立方體":
                    shapeArr.Add(new Cube(double.Parse(txt_1.Text), mType));
                    break;
                case "圓柱體":
                    shapeArr.Add(new Cylinder(double.Parse(txt_1.Text),double.Parse(txt_2.Text), mType));
                    break;
                case "金字塔":
                    shapeArr.Add(new Pyramid(double.Parse(txt_1.Text), double.Parse(txt_2.Text), mType));
                    break;
                default:
                    break;
            }
            txt_ball.Text = Ball.Amount.ToString();
            txt_cube.Text = Cube.Amount.ToString();
            txt_cylinder.Text = Cylinder.Amount.ToString();
            txt_pyramid.Text = Pyramid.Amount.ToString();
            txt_sum.Text = Shape3D.Amount.ToString();
            ShowAllMessage(txt_message);
        }
        private void ShowAllMessage(TextBox msg)
        {
            string info = "";
            foreach(var shape in shapeArr)
            {
                info += (shape.ShapeProperty() + "\r\n");
            }
            msg.Text = info;
        }
        private bool CompareByShapeTypeAscend(Shape3D a, Shape3D b)
        {
            if (a.GeoType > b.GeoType)
                return true;
            else
                return false;
        }
        private bool CompareByShapeTypeDescend(Shape3D a, Shape3D b)
        {
            if (a.GeoType < b.GeoType)
                return true;
            else
                return false;
        }
        private bool CompareByMaterialAscend(Shape3D a, Shape3D b)
        {
            if (a.MaterialType > b.MaterialType)
                return true;
            else
                return false;
        }
        private bool CompareByMaterialDescend(Shape3D a, Shape3D b)
        {
            if (a.MaterialType < b.MaterialType)
                return true;
            else
                return false;
        }
        private bool CompareByVolumeAscend(Shape3D a, Shape3D b)
        {
            if (a.Volume() > b.Volume())
                return true;
            else
                return false;
        }
        private bool CompareByVolumeDescend(Shape3D a, Shape3D b)
        {
            if (a.Volume() < b.Volume())
                return true;
            else
                return false;
        }
        private bool CompareByWeightAscend(Shape3D a, Shape3D b)
        {
            if (a.Weight() > b.Weight())
                return true;
            else
                return false;
        }
        private bool CompareByWeightDescend(Shape3D a, Shape3D b)
        {
            if (a.Weight() < b.Weight())
                return true;
            else
                return false;
        }
        private void BubbleSort(CompareFunc cmp)
        {
            Shape3D temp;
            for(int i=0;i<shapeArr.Count;i++)
            {
                for(int j=0;j<shapeArr.Count-1;j++)
                {
                    if(cmp(shapeArr[j],shapeArr[j+1]))
                    {
                        temp = shapeArr[j];
                        shapeArr[j] = shapeArr[j + 1];
                        shapeArr[j + 1] = temp;
                    }
                }
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            switch (cb_sortType.SelectedItem.ToString())
            {
                case "形狀":
                    if (rb_ascend.Checked)
                        BubbleSort(CompareByShapeTypeAscend);
                    else
                        BubbleSort(CompareByShapeTypeDescend);
                    break;
                case "材料":
                    if (rb_ascend.Checked)
                        BubbleSort(CompareByMaterialAscend);
                    else
                        BubbleSort(CompareByMaterialDescend);
                    break;
                case "體積":
                    if (rb_ascend.Checked)
                        BubbleSort(CompareByVolumeAscend);
                    else
                        BubbleSort(CompareByVolumeDescend);
                    break;
                case "重量":
                    if (rb_ascend.Checked)
                        BubbleSort(CompareByWeightAscend);
                    else
                        BubbleSort(CompareByWeightDescend);
                    break;
                default:
                    break;
            }
            ShowAllMessage(txt_sort);
        }
        private int CompareByDistence(IRollable a,IRollable b)
        {
            if (a.Distence() < b.Distence())
                return 1;
            else
                return -1;
        }
        private void ShowRollMessage()
        {
            string info = "";
            foreach(var shape in rollArr)
            {
                info += (shape.RollShapeProperty() + "\r\n");
            }
            txt_rollMessage.Text = info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IRollable rollshape = null;
            rollArr.Clear();
            foreach(var shape in shapeArr)
            {
                rollshape = shape as IRollable;
                if (rollshape != null)
                    rollArr.Add(rollshape);
            }
            rollArr.Sort(CompareByDistence);
            ShowRollMessage();
        }
    }
}
