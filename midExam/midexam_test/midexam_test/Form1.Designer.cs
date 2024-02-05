
namespace midexam_test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.密度 = new System.Windows.Forms.Label();
            this.材質 = new System.Windows.Forms.Label();
            this.txt_density = new System.Windows.Forms.TextBox();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.cb_shape = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pyramid = new System.Windows.Forms.TextBox();
            this.txt_cylinder = new System.Windows.Forms.TextBox();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_game = new System.Windows.Forms.Button();
            this.txt_roll = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.rb_descend = new System.Windows.Forms.RadioButton();
            this.rb_ascend = new System.Windows.Forms.RadioButton();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sort = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.密度);
            this.groupBox1.Controls.Add(this.材質);
            this.groupBox1.Controls.Add(this.txt_density);
            this.groupBox1.Controls.Add(this.cb_material);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // 密度
            // 
            this.密度.AutoSize = true;
            this.密度.Location = new System.Drawing.Point(31, 108);
            this.密度.Name = "密度";
            this.密度.Size = new System.Drawing.Size(44, 18);
            this.密度.TabIndex = 3;
            this.密度.Text = "密度";
            // 
            // 材質
            // 
            this.材質.AutoSize = true;
            this.材質.Location = new System.Drawing.Point(33, 48);
            this.材質.Name = "材質";
            this.材質.Size = new System.Drawing.Size(44, 18);
            this.材質.TabIndex = 2;
            this.材質.Text = "材質";
            // 
            // txt_density
            // 
            this.txt_density.Location = new System.Drawing.Point(118, 105);
            this.txt_density.Name = "txt_density";
            this.txt_density.ReadOnly = true;
            this.txt_density.Size = new System.Drawing.Size(229, 29);
            this.txt_density.TabIndex = 1;
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cb_material.Location = new System.Drawing.Point(118, 41);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(229, 26);
            this.cb_material.TabIndex = 0;
            this.cb_material.SelectedIndexChanged += new System.EventHandler(this.cb_material_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_2);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_2);
            this.groupBox2.Controls.Add(this.txt_1);
            this.groupBox2.Controls.Add(this.cb_shape);
            this.groupBox2.Location = new System.Drawing.Point(24, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geometry";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(33, 172);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(50, 18);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "label5";
            this.lbl_2.Visible = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(31, 107);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(50, 18);
            this.lbl_1.TabIndex = 5;
            this.lbl_1.Text = "label4";
            this.lbl_1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "形狀";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(118, 169);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(229, 29);
            this.txt_2.TabIndex = 3;
            this.txt_2.Visible = false;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(118, 104);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(229, 29);
            this.txt_1.TabIndex = 2;
            this.txt_1.Visible = false;
            // 
            // cb_shape
            // 
            this.cb_shape.FormattingEnabled = true;
            this.cb_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cb_shape.Location = new System.Drawing.Point(118, 44);
            this.cb_shape.Name = "cb_shape";
            this.cb_shape.Size = new System.Drawing.Size(229, 26);
            this.cb_shape.TabIndex = 1;
            this.cb_shape.SelectedIndexChanged += new System.EventHandler(this.cb_shape_SelectedIndexChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(24, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 195);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount of Shape";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(17, 71);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 35);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "金字塔";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "圓柱體";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "立方體";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "球";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "總數";
            // 
            // txt_pyramid
            // 
            this.txt_pyramid.Location = new System.Drawing.Point(283, 151);
            this.txt_pyramid.Name = "txt_pyramid";
            this.txt_pyramid.Size = new System.Drawing.Size(64, 29);
            this.txt_pyramid.TabIndex = 6;
            // 
            // txt_cylinder
            // 
            this.txt_cylinder.Location = new System.Drawing.Point(197, 151);
            this.txt_cylinder.Name = "txt_cylinder";
            this.txt_cylinder.Size = new System.Drawing.Size(64, 29);
            this.txt_cylinder.TabIndex = 5;
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(107, 151);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(64, 29);
            this.txt_cube.TabIndex = 4;
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(17, 151);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(64, 29);
            this.txt_ball.TabIndex = 3;
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(118, 71);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(229, 29);
            this.txt_sum.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_game);
            this.groupBox4.Controls.Add(this.txt_roll);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txt_message);
            this.groupBox4.Location = new System.Drawing.Point(429, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 790);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // btn_game
            // 
            this.btn_game.Location = new System.Drawing.Point(21, 574);
            this.btn_game.Name = "btn_game";
            this.btn_game.Size = new System.Drawing.Size(95, 35);
            this.btn_game.TabIndex = 14;
            this.btn_game.Text = "滾球大賽";
            this.btn_game.UseVisualStyleBackColor = true;
            this.btn_game.Click += new System.EventHandler(this.btn_game_Click);
            // 
            // txt_roll
            // 
            this.txt_roll.Location = new System.Drawing.Point(17, 615);
            this.txt_roll.Multiline = true;
            this.txt_roll.Name = "txt_roll";
            this.txt_roll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_roll.Size = new System.Drawing.Size(632, 157);
            this.txt_roll.TabIndex = 6;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_check);
            this.groupBox5.Controls.Add(this.rb_descend);
            this.groupBox5.Controls.Add(this.rb_ascend);
            this.groupBox5.Controls.Add(this.cb_sort);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txt_sort);
            this.groupBox5.Location = new System.Drawing.Point(7, 261);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(658, 306);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sort";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(479, 22);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(95, 35);
            this.btn_check.TabIndex = 13;
            this.btn_check.Text = "確認";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // rb_descend
            // 
            this.rb_descend.AutoSize = true;
            this.rb_descend.Location = new System.Drawing.Point(380, 29);
            this.rb_descend.Name = "rb_descend";
            this.rb_descend.Size = new System.Drawing.Size(69, 22);
            this.rb_descend.TabIndex = 9;
            this.rb_descend.TabStop = true;
            this.rb_descend.Text = "遞減";
            this.rb_descend.UseVisualStyleBackColor = true;
            // 
            // rb_ascend
            // 
            this.rb_ascend.AutoSize = true;
            this.rb_ascend.Location = new System.Drawing.Point(295, 28);
            this.rb_ascend.Name = "rb_ascend";
            this.rb_ascend.Size = new System.Drawing.Size(69, 22);
            this.rb_ascend.TabIndex = 8;
            this.rb_ascend.TabStop = true;
            this.rb_ascend.Text = "遞增";
            this.rb_ascend.UseVisualStyleBackColor = true;
            // 
            // cb_sort
            // 
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Items.AddRange(new object[] {
            "形狀",
            "材料",
            "體積",
            "重量"});
            this.cb_sort.Location = new System.Drawing.Point(127, 28);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(148, 26);
            this.cb_sort.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "排序方法";
            // 
            // txt_sort
            // 
            this.txt_sort.Location = new System.Drawing.Point(10, 63);
            this.txt_sort.Multiline = true;
            this.txt_sort.Name = "txt_sort";
            this.txt_sort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sort.Size = new System.Drawing.Size(632, 227);
            this.txt_sort.TabIndex = 5;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(17, 28);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(632, 227);
            this.txt_message.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 829);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label 密度;
        private System.Windows.Forms.Label 材質;
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
        private System.Windows.Forms.Button btn_game;
        private System.Windows.Forms.TextBox txt_roll;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.RadioButton rb_descend;
        private System.Windows.Forms.RadioButton rb_ascend;
        private System.Windows.Forms.ComboBox cb_sort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_sort;
        private System.Windows.Forms.TextBox txt_message;
    }
}

