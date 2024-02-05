
namespace Quiz6_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.cb_shape = new System.Windows.Forms.ComboBox();
            this.txt_density = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.txt_cylinder = new System.Windows.Forms.TextBox();
            this.txt_pyramid = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_density);
            this.groupBox1.Controls.Add(this.cb_material);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_2);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_2);
            this.groupBox2.Controls.Add(this.txt_1);
            this.groupBox2.Controls.Add(this.cb_shape);
            this.groupBox2.Location = new System.Drawing.Point(27, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geometry";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_pyramid);
            this.groupBox3.Controls.Add(this.txt_cylinder);
            this.groupBox3.Controls.Add(this.txt_cube);
            this.groupBox3.Controls.Add(this.txt_ball);
            this.groupBox3.Controls.Add(this.txt_sum);
            this.groupBox3.Location = new System.Drawing.Point(27, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 192);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Of Shape";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_clear);
            this.groupBox4.Controls.Add(this.txt_message);
            this.groupBox4.Location = new System.Drawing.Point(473, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 560);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cb_material.Location = new System.Drawing.Point(127, 37);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(238, 26);
            this.cb_material.TabIndex = 0;
            this.cb_material.SelectedIndexChanged += new System.EventHandler(this.cb_material_SelectedIndexChanged);
            // 
            // cb_shape
            // 
            this.cb_shape.FormattingEnabled = true;
            this.cb_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cb_shape.Location = new System.Drawing.Point(127, 41);
            this.cb_shape.Name = "cb_shape";
            this.cb_shape.Size = new System.Drawing.Size(238, 26);
            this.cb_shape.TabIndex = 1;
            this.cb_shape.SelectedIndexChanged += new System.EventHandler(this.cb_shape_SelectedIndexChanged);
            // 
            // txt_density
            // 
            this.txt_density.Location = new System.Drawing.Point(127, 93);
            this.txt_density.Name = "txt_density";
            this.txt_density.ReadOnly = true;
            this.txt_density.Size = new System.Drawing.Size(238, 29);
            this.txt_density.TabIndex = 1;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(127, 86);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(238, 29);
            this.txt_1.TabIndex = 2;
            this.txt_1.Visible = false;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(127, 131);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(238, 29);
            this.txt_2.TabIndex = 3;
            this.txt_2.Visible = false;
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(127, 73);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(238, 29);
            this.txt_sum.TabIndex = 2;
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(33, 145);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(59, 29);
            this.txt_ball.TabIndex = 3;
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(127, 145);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(59, 29);
            this.txt_cube.TabIndex = 4;
            // 
            // txt_cylinder
            // 
            this.txt_cylinder.Location = new System.Drawing.Point(224, 145);
            this.txt_cylinder.Name = "txt_cylinder";
            this.txt_cylinder.Size = new System.Drawing.Size(59, 29);
            this.txt_cylinder.TabIndex = 5;
            // 
            // txt_pyramid
            // 
            this.txt_pyramid.Location = new System.Drawing.Point(319, 145);
            this.txt_pyramid.Name = "txt_pyramid";
            this.txt_pyramid.Size = new System.Drawing.Size(59, 29);
            this.txt_pyramid.TabIndex = 6;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(21, 37);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(509, 370);
            this.txt_message.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "材質";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "形狀";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(42, 89);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(52, 18);
            this.lbl_1.TabIndex = 5;
            this.lbl_1.Text = "參數1";
            this.lbl_1.Visible = false;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(43, 134);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(52, 18);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "參數2";
            this.lbl_2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "總數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "球";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "立方體";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "圓柱體";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "金字塔";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 71);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 29);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(442, 428);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 597);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_density;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.ComboBox cb_shape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pyramid;
        private System.Windows.Forms.TextBox txt_cylinder;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_message;
    }
}

