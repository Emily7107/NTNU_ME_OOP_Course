
namespace u40873038H_Quiz6
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
            this.grp_material = new System.Windows.Forms.GroupBox();
            this.lbl_D = new System.Windows.Forms.Label();
            this.lbl_material = new System.Windows.Forms.Label();
            this.txt_showD = new System.Windows.Forms.TextBox();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.grp_geometery = new System.Windows.Forms.GroupBox();
            this.lbl_high = new System.Windows.Forms.Label();
            this.txt_high = new System.Windows.Forms.TextBox();
            this.lbl_radius = new System.Windows.Forms.Label();
            this.lbl_shape = new System.Windows.Forms.Label();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.cb_shape = new System.Windows.Forms.ComboBox();
            this.grp_AmountOfShape = new System.Windows.Forms.GroupBox();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.txt_pyramid = new System.Windows.Forms.TextBox();
            this.txt_cylinder = new System.Windows.Forms.TextBox();
            this.txt_cube = new System.Windows.Forms.TextBox();
            this.txt_ball = new System.Windows.Forms.TextBox();
            this.lbl_pyramid = new System.Windows.Forms.Label();
            this.lbl_cylinder = new System.Windows.Forms.Label();
            this.lbl_cube = new System.Windows.Forms.Label();
            this.lal_ball = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_amount = new System.Windows.Forms.Button();
            this.grp_message = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.grp_material.SuspendLayout();
            this.grp_geometery.SuspendLayout();
            this.grp_AmountOfShape.SuspendLayout();
            this.grp_message.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_material
            // 
            this.grp_material.Controls.Add(this.lbl_D);
            this.grp_material.Controls.Add(this.lbl_material);
            this.grp_material.Controls.Add(this.txt_showD);
            this.grp_material.Controls.Add(this.cb_material);
            this.grp_material.Location = new System.Drawing.Point(36, 12);
            this.grp_material.Name = "grp_material";
            this.grp_material.Size = new System.Drawing.Size(436, 133);
            this.grp_material.TabIndex = 0;
            this.grp_material.TabStop = false;
            this.grp_material.Text = "Material";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Location = new System.Drawing.Point(40, 82);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(44, 18);
            this.lbl_D.TabIndex = 3;
            this.lbl_D.Text = "密度";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Location = new System.Drawing.Point(40, 31);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(44, 18);
            this.lbl_material.TabIndex = 2;
            this.lbl_material.Text = "材質";
            // 
            // txt_showD
            // 
            this.txt_showD.Location = new System.Drawing.Point(139, 79);
            this.txt_showD.Name = "txt_showD";
            this.txt_showD.ReadOnly = true;
            this.txt_showD.Size = new System.Drawing.Size(205, 29);
            this.txt_showD.TabIndex = 1;
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cb_material.Location = new System.Drawing.Point(139, 28);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(205, 26);
            this.cb_material.TabIndex = 0;
            this.cb_material.SelectedIndexChanged += new System.EventHandler(this.cb_material_SelectedIndexChanged);
            // 
            // grp_geometery
            // 
            this.grp_geometery.Controls.Add(this.lbl_high);
            this.grp_geometery.Controls.Add(this.txt_high);
            this.grp_geometery.Controls.Add(this.lbl_radius);
            this.grp_geometery.Controls.Add(this.lbl_shape);
            this.grp_geometery.Controls.Add(this.txt_radius);
            this.grp_geometery.Controls.Add(this.cb_shape);
            this.grp_geometery.Location = new System.Drawing.Point(36, 161);
            this.grp_geometery.Name = "grp_geometery";
            this.grp_geometery.Size = new System.Drawing.Size(436, 190);
            this.grp_geometery.TabIndex = 1;
            this.grp_geometery.TabStop = false;
            this.grp_geometery.Text = "Geometry";
            // 
            // lbl_high
            // 
            this.lbl_high.AutoSize = true;
            this.lbl_high.Location = new System.Drawing.Point(40, 146);
            this.lbl_high.Name = "lbl_high";
            this.lbl_high.Size = new System.Drawing.Size(52, 18);
            this.lbl_high.TabIndex = 7;
            this.lbl_high.Text = "參數2";
            this.lbl_high.Visible = false;
            // 
            // txt_high
            // 
            this.txt_high.Location = new System.Drawing.Point(139, 143);
            this.txt_high.Name = "txt_high";
            this.txt_high.Size = new System.Drawing.Size(205, 29);
            this.txt_high.TabIndex = 6;
            this.txt_high.Visible = false;
            // 
            // lbl_radius
            // 
            this.lbl_radius.AutoSize = true;
            this.lbl_radius.Location = new System.Drawing.Point(40, 95);
            this.lbl_radius.Name = "lbl_radius";
            this.lbl_radius.Size = new System.Drawing.Size(52, 18);
            this.lbl_radius.TabIndex = 5;
            this.lbl_radius.Text = "參數1";
            this.lbl_radius.Visible = false;
            // 
            // lbl_shape
            // 
            this.lbl_shape.AutoSize = true;
            this.lbl_shape.Location = new System.Drawing.Point(40, 47);
            this.lbl_shape.Name = "lbl_shape";
            this.lbl_shape.Size = new System.Drawing.Size(44, 18);
            this.lbl_shape.TabIndex = 4;
            this.lbl_shape.Text = "形狀";
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(139, 92);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(205, 29);
            this.txt_radius.TabIndex = 4;
            this.txt_radius.Visible = false;
            // 
            // cb_shape
            // 
            this.cb_shape.FormattingEnabled = true;
            this.cb_shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cb_shape.Location = new System.Drawing.Point(139, 44);
            this.cb_shape.Name = "cb_shape";
            this.cb_shape.Size = new System.Drawing.Size(205, 26);
            this.cb_shape.TabIndex = 1;
            this.cb_shape.SelectedIndexChanged += new System.EventHandler(this.cb_shape_SelectedIndexChanged);
            // 
            // grp_AmountOfShape
            // 
            this.grp_AmountOfShape.Controls.Add(this.lbl_sum);
            this.grp_AmountOfShape.Controls.Add(this.txt_pyramid);
            this.grp_AmountOfShape.Controls.Add(this.txt_cylinder);
            this.grp_AmountOfShape.Controls.Add(this.txt_cube);
            this.grp_AmountOfShape.Controls.Add(this.txt_ball);
            this.grp_AmountOfShape.Controls.Add(this.lbl_pyramid);
            this.grp_AmountOfShape.Controls.Add(this.lbl_cylinder);
            this.grp_AmountOfShape.Controls.Add(this.lbl_cube);
            this.grp_AmountOfShape.Controls.Add(this.lal_ball);
            this.grp_AmountOfShape.Controls.Add(this.txt_amount);
            this.grp_AmountOfShape.Controls.Add(this.btn_amount);
            this.grp_AmountOfShape.Location = new System.Drawing.Point(36, 357);
            this.grp_AmountOfShape.Name = "grp_AmountOfShape";
            this.grp_AmountOfShape.Size = new System.Drawing.Size(436, 199);
            this.grp_AmountOfShape.TabIndex = 1;
            this.grp_AmountOfShape.TabStop = false;
            this.grp_AmountOfShape.Text = "Amount Of Shape";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(169, 22);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(44, 18);
            this.lbl_sum.TabIndex = 10;
            this.lbl_sum.Text = "總和";
            // 
            // txt_pyramid
            // 
            this.txt_pyramid.Location = new System.Drawing.Point(336, 139);
            this.txt_pyramid.Name = "txt_pyramid";
            this.txt_pyramid.Size = new System.Drawing.Size(41, 29);
            this.txt_pyramid.TabIndex = 9;
            // 
            // txt_cylinder
            // 
            this.txt_cylinder.Location = new System.Drawing.Point(238, 139);
            this.txt_cylinder.Name = "txt_cylinder";
            this.txt_cylinder.Size = new System.Drawing.Size(41, 29);
            this.txt_cylinder.TabIndex = 8;
            // 
            // txt_cube
            // 
            this.txt_cube.Location = new System.Drawing.Point(127, 139);
            this.txt_cube.Name = "txt_cube";
            this.txt_cube.Size = new System.Drawing.Size(41, 29);
            this.txt_cube.TabIndex = 7;
            // 
            // txt_ball
            // 
            this.txt_ball.Location = new System.Drawing.Point(33, 139);
            this.txt_ball.Name = "txt_ball";
            this.txt_ball.Size = new System.Drawing.Size(41, 29);
            this.txt_ball.TabIndex = 6;
            // 
            // lbl_pyramid
            // 
            this.lbl_pyramid.AutoSize = true;
            this.lbl_pyramid.Location = new System.Drawing.Point(327, 115);
            this.lbl_pyramid.Name = "lbl_pyramid";
            this.lbl_pyramid.Size = new System.Drawing.Size(62, 18);
            this.lbl_pyramid.TabIndex = 5;
            this.lbl_pyramid.Text = "金字塔";
            // 
            // lbl_cylinder
            // 
            this.lbl_cylinder.AutoSize = true;
            this.lbl_cylinder.Location = new System.Drawing.Point(226, 115);
            this.lbl_cylinder.Name = "lbl_cylinder";
            this.lbl_cylinder.Size = new System.Drawing.Size(62, 18);
            this.lbl_cylinder.TabIndex = 4;
            this.lbl_cylinder.Text = "圓柱體";
            // 
            // lbl_cube
            // 
            this.lbl_cube.AutoSize = true;
            this.lbl_cube.Location = new System.Drawing.Point(115, 115);
            this.lbl_cube.Name = "lbl_cube";
            this.lbl_cube.Size = new System.Drawing.Size(62, 18);
            this.lbl_cube.TabIndex = 3;
            this.lbl_cube.Text = "立方體";
            // 
            // lal_ball
            // 
            this.lal_ball.AutoSize = true;
            this.lal_ball.Location = new System.Drawing.Point(41, 115);
            this.lal_ball.Name = "lal_ball";
            this.lal_ball.Size = new System.Drawing.Size(26, 18);
            this.lal_ball.TabIndex = 2;
            this.lal_ball.Text = "球";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(172, 55);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(204, 29);
            this.txt_amount.TabIndex = 1;
            // 
            // btn_amount
            // 
            this.btn_amount.Location = new System.Drawing.Point(33, 52);
            this.btn_amount.Name = "btn_amount";
            this.btn_amount.Size = new System.Drawing.Size(88, 30);
            this.btn_amount.TabIndex = 0;
            this.btn_amount.Text = "Add";
            this.btn_amount.UseVisualStyleBackColor = true;
            this.btn_amount.Click += new System.EventHandler(this.btn_amount_Click);
            // 
            // grp_message
            // 
            this.grp_message.Controls.Add(this.btn_clear);
            this.grp_message.Controls.Add(this.txt_message);
            this.grp_message.Location = new System.Drawing.Point(502, 12);
            this.grp_message.Name = "grp_message";
            this.grp_message.Size = new System.Drawing.Size(568, 544);
            this.grp_message.TabIndex = 1;
            this.grp_message.TabStop = false;
            this.grp_message.Text = "Message";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(464, 398);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 29);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(19, 31);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_message.Size = new System.Drawing.Size(533, 340);
            this.txt_message.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 581);
            this.Controls.Add(this.grp_message);
            this.Controls.Add(this.grp_AmountOfShape);
            this.Controls.Add(this.grp_geometery);
            this.Controls.Add(this.grp_material);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_material.ResumeLayout(false);
            this.grp_material.PerformLayout();
            this.grp_geometery.ResumeLayout(false);
            this.grp_geometery.PerformLayout();
            this.grp_AmountOfShape.ResumeLayout(false);
            this.grp_AmountOfShape.PerformLayout();
            this.grp_message.ResumeLayout(false);
            this.grp_message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_material;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.Label lbl_material;
        private System.Windows.Forms.TextBox txt_showD;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.GroupBox grp_geometery;
        private System.Windows.Forms.Label lbl_radius;
        private System.Windows.Forms.Label lbl_shape;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.ComboBox cb_shape;
        private System.Windows.Forms.GroupBox grp_AmountOfShape;
        private System.Windows.Forms.TextBox txt_cylinder;
        private System.Windows.Forms.TextBox txt_cube;
        private System.Windows.Forms.TextBox txt_ball;
        private System.Windows.Forms.Label lbl_pyramid;
        private System.Windows.Forms.Label lbl_cylinder;
        private System.Windows.Forms.Label lbl_cube;
        private System.Windows.Forms.Label lal_ball;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_amount;
        private System.Windows.Forms.GroupBox grp_message;
        private System.Windows.Forms.TextBox txt_pyramid;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label lbl_high;
        private System.Windows.Forms.TextBox txt_high;
        private System.Windows.Forms.Label lbl_sum;
    }
}

