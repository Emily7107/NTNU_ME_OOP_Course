
namespace midexam_practice
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
            System.Windows.Forms.GroupBox groupBox5;
            this.label11 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.rb_descend = new System.Windows.Forms.RadioButton();
            this.rb_ascend = new System.Windows.Forms.RadioButton();
            this.cb_sortType = new System.Windows.Forms.ComboBox();
            this.txt_sort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_pyramid = new System.Windows.Forms.TextBox();
            this.txt_cylinder = new System.Windows.Forms.TextBox();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_rollMessage = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox5 = new System.Windows.Forms.GroupBox();
            groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(this.label11);
            groupBox5.Controls.Add(this.btn_check);
            groupBox5.Controls.Add(this.rb_descend);
            groupBox5.Controls.Add(this.rb_ascend);
            groupBox5.Controls.Add(this.cb_sortType);
            groupBox5.Controls.Add(this.txt_sort);
            groupBox5.Location = new System.Drawing.Point(0, 216);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(582, 265);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Sort";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "排序方式";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(444, 24);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(93, 33);
            this.btn_check.TabIndex = 9;
            this.btn_check.Text = "確認";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // rb_descend
            // 
            this.rb_descend.AutoSize = true;
            this.rb_descend.Location = new System.Drawing.Point(345, 28);
            this.rb_descend.Name = "rb_descend";
            this.rb_descend.Size = new System.Drawing.Size(69, 22);
            this.rb_descend.TabIndex = 8;
            this.rb_descend.TabStop = true;
            this.rb_descend.Text = "遞減";
            this.rb_descend.UseVisualStyleBackColor = true;
            // 
            // rb_ascend
            // 
            this.rb_ascend.AutoSize = true;
            this.rb_ascend.Location = new System.Drawing.Point(270, 29);
            this.rb_ascend.Name = "rb_ascend";
            this.rb_ascend.Size = new System.Drawing.Size(69, 22);
            this.rb_ascend.TabIndex = 7;
            this.rb_ascend.TabStop = true;
            this.rb_ascend.Text = "遞增";
            this.rb_ascend.UseVisualStyleBackColor = true;
            // 
            // cb_sortType
            // 
            this.cb_sortType.FormattingEnabled = true;
            this.cb_sortType.Items.AddRange(new object[] {
            "形狀",
            "材料",
            "體積",
            "重量"});
            this.cb_sortType.Location = new System.Drawing.Point(109, 28);
            this.cb_sortType.Name = "cb_sortType";
            this.cb_sortType.Size = new System.Drawing.Size(138, 26);
            this.cb_sortType.TabIndex = 6;
            // 
            // txt_sort
            // 
            this.txt_sort.Location = new System.Drawing.Point(21, 70);
            this.txt_sort.Multiline = true;
            this.txt_sort.Name = "txt_sort";
            this.txt_sort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_sort.Size = new System.Drawing.Size(546, 181);
            this.txt_sort.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.txt_density);
            this.groupBox1.Controls.Add(this.cb_material);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "密度";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(44, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "材質";
            // 
            // txt_density
            // 
            this.txt_density.Location = new System.Drawing.Point(120, 79);
            this.txt_density.Name = "txt_density";
            this.txt_density.ReadOnly = true;
            this.txt_density.Size = new System.Drawing.Size(219, 29);
            this.txt_density.TabIndex = 1;
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cb_material.Location = new System.Drawing.Point(120, 29);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(219, 26);
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
            this.groupBox2.Location = new System.Drawing.Point(24, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geometry";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(38, 134);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(50, 18);
            this.lbl_2.TabIndex = 6;
            this.lbl_2.Text = "label5";
            this.lbl_2.Visible = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(38, 87);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(50, 18);
            this.lbl_1.TabIndex = 5;
            this.lbl_1.Text = "label4";
            this.lbl_1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "形狀";
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(120, 134);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(219, 29);
            this.txt_2.TabIndex = 3;
            this.txt_2.Visible = false;
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(120, 84);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(219, 29);
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
            this.cb_shape.Location = new System.Drawing.Point(120, 38);
            this.cb_shape.Name = "cb_shape";
            this.cb_shape.Size = new System.Drawing.Size(219, 26);
            this.cb_shape.TabIndex = 1;
            this.cb_shape.SelectedIndexChanged += new System.EventHandler(this.cb_shape_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.txt_pyramid);
            this.groupBox3.Controls.Add(this.txt_cylinder);
            this.groupBox3.Controls.Add(this.txt_cube);
            this.groupBox3.Controls.Add(this.txt_ball);
            this.groupBox3.Controls.Add(this.txt_sum);
            this.groupBox3.Location = new System.Drawing.Point(24, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 172);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Of Shape";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "金字塔";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "圓柱體";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "立方體";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "球";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "總數";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 63);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 33);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_pyramid
            // 
            this.txt_pyramid.Location = new System.Drawing.Point(277, 128);
            this.txt_pyramid.Name = "txt_pyramid";
            this.txt_pyramid.Size = new System.Drawing.Size(62, 29);
            this.txt_pyramid.TabIndex = 6;
            // 
            // txt_cylinder
            // 
            this.txt_cylinder.Location = new System.Drawing.Point(190, 128);
            this.txt_cylinder.Name = "txt_cylinder";
            this.txt_cylinder.Size = new System.Drawing.Size(62, 29);
            this.txt_cylinder.TabIndex = 5;
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(103, 128);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(62, 29);
            this.txt_cube.TabIndex = 4;
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(15, 128);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(62, 29);
            this.txt_ball.TabIndex = 3;
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(120, 67);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(219, 29);
            this.txt_sum.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txt_rollMessage);
            this.groupBox4.Controls.Add(groupBox5);
            this.groupBox4.Controls.Add(this.txt_message);
            this.groupBox4.Location = new System.Drawing.Point(428, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(582, 668);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "滾球大賽";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_rollMessage
            // 
            this.txt_rollMessage.Location = new System.Drawing.Point(21, 541);
            this.txt_rollMessage.Multiline = true;
            this.txt_rollMessage.Name = "txt_rollMessage";
            this.txt_rollMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_rollMessage.Size = new System.Drawing.Size(546, 108);
            this.txt_rollMessage.TabIndex = 6;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(21, 29);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(546, 181);
            this.txt_message.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_density;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.ComboBox cb_shape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_pyramid;
        private System.Windows.Forms.TextBox txt_cylinder;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_rollMessage;
        private System.Windows.Forms.RadioButton rb_descend;
        private System.Windows.Forms.RadioButton rb_ascend;
        private System.Windows.Forms.ComboBox cb_sortType;
        private System.Windows.Forms.TextBox txt_sort;
        private System.Windows.Forms.TextBox txt_message;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}

