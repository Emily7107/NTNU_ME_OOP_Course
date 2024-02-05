
namespace u40873038H_Quiz5
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
            this.grp_coordinate = new System.Windows.Forms.GroupBox();
            this.grp_select = new System.Windows.Forms.GroupBox();
            this.grp_function = new System.Windows.Forms.GroupBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_x3 = new System.Windows.Forms.TextBox();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_y2 = new System.Windows.Forms.TextBox();
            this.txt_y3 = new System.Windows.Forms.TextBox();
            this.lbl_point1 = new System.Windows.Forms.Label();
            this.lbl_point2 = new System.Windows.Forms.Label();
            this.lbl_point3 = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.chk_area = new System.Windows.Forms.CheckBox();
            this.chk_perimeter = new System.Windows.Forms.CheckBox();
            this.chk_type = new System.Windows.Forms.CheckBox();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.bnt_calculate = new System.Windows.Forms.Button();
            this.grp_coordinate.SuspendLayout();
            this.grp_select.SuspendLayout();
            this.grp_function.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_coordinate
            // 
            this.grp_coordinate.Controls.Add(this.lbl_y);
            this.grp_coordinate.Controls.Add(this.lbl_x);
            this.grp_coordinate.Controls.Add(this.lbl_point3);
            this.grp_coordinate.Controls.Add(this.lbl_point2);
            this.grp_coordinate.Controls.Add(this.lbl_point1);
            this.grp_coordinate.Controls.Add(this.txt_y3);
            this.grp_coordinate.Controls.Add(this.txt_y2);
            this.grp_coordinate.Controls.Add(this.txt_y1);
            this.grp_coordinate.Controls.Add(this.txt_x3);
            this.grp_coordinate.Controls.Add(this.txt_x2);
            this.grp_coordinate.Controls.Add(this.txt_x1);
            this.grp_coordinate.Location = new System.Drawing.Point(29, 22);
            this.grp_coordinate.Name = "grp_coordinate";
            this.grp_coordinate.Size = new System.Drawing.Size(434, 238);
            this.grp_coordinate.TabIndex = 0;
            this.grp_coordinate.TabStop = false;
            this.grp_coordinate.Text = "座標輸入";
            // 
            // grp_select
            // 
            this.grp_select.Controls.Add(this.chk_type);
            this.grp_select.Controls.Add(this.chk_perimeter);
            this.grp_select.Controls.Add(this.chk_area);
            this.grp_select.Location = new System.Drawing.Point(29, 266);
            this.grp_select.Name = "grp_select";
            this.grp_select.Size = new System.Drawing.Size(434, 64);
            this.grp_select.TabIndex = 1;
            this.grp_select.TabStop = false;
            this.grp_select.Text = "選項";
            // 
            // grp_function
            // 
            this.grp_function.Controls.Add(this.bnt_calculate);
            this.grp_function.Controls.Add(this.txt_output);
            this.grp_function.Location = new System.Drawing.Point(29, 336);
            this.grp_function.Name = "grp_function";
            this.grp_function.Size = new System.Drawing.Size(434, 292);
            this.grp_function.TabIndex = 1;
            this.grp_function.TabStop = false;
            this.grp_function.Text = "功能鍵與輸出";
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(129, 52);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(100, 29);
            this.txt_x1.TabIndex = 0;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(129, 119);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(100, 29);
            this.txt_x2.TabIndex = 1;
            // 
            // txt_x3
            // 
            this.txt_x3.Location = new System.Drawing.Point(129, 184);
            this.txt_x3.Name = "txt_x3";
            this.txt_x3.Size = new System.Drawing.Size(100, 29);
            this.txt_x3.TabIndex = 2;
            // 
            // txt_y1
            // 
            this.txt_y1.Location = new System.Drawing.Point(282, 52);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.Size = new System.Drawing.Size(100, 29);
            this.txt_y1.TabIndex = 3;
            // 
            // txt_y2
            // 
            this.txt_y2.Location = new System.Drawing.Point(282, 119);
            this.txt_y2.Name = "txt_y2";
            this.txt_y2.Size = new System.Drawing.Size(100, 29);
            this.txt_y2.TabIndex = 4;
            // 
            // txt_y3
            // 
            this.txt_y3.Location = new System.Drawing.Point(282, 184);
            this.txt_y3.Name = "txt_y3";
            this.txt_y3.Size = new System.Drawing.Size(100, 29);
            this.txt_y3.TabIndex = 5;
            // 
            // lbl_point1
            // 
            this.lbl_point1.AutoSize = true;
            this.lbl_point1.Location = new System.Drawing.Point(39, 55);
            this.lbl_point1.Name = "lbl_point1";
            this.lbl_point1.Size = new System.Drawing.Size(51, 18);
            this.lbl_point1.TabIndex = 6;
            this.lbl_point1.Text = "Point1";
            // 
            // lbl_point2
            // 
            this.lbl_point2.AutoSize = true;
            this.lbl_point2.Location = new System.Drawing.Point(39, 122);
            this.lbl_point2.Name = "lbl_point2";
            this.lbl_point2.Size = new System.Drawing.Size(51, 18);
            this.lbl_point2.TabIndex = 7;
            this.lbl_point2.Text = "Point2";
            // 
            // lbl_point3
            // 
            this.lbl_point3.AutoSize = true;
            this.lbl_point3.Location = new System.Drawing.Point(39, 187);
            this.lbl_point3.Name = "lbl_point3";
            this.lbl_point3.Size = new System.Drawing.Size(50, 18);
            this.lbl_point3.TabIndex = 8;
            this.lbl_point3.Text = "point3";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Location = new System.Drawing.Point(163, 25);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(20, 18);
            this.lbl_x.TabIndex = 9;
            this.lbl_x.Text = "X";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(318, 25);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(20, 18);
            this.lbl_y.TabIndex = 10;
            this.lbl_y.Text = "Y";
            // 
            // chk_area
            // 
            this.chk_area.AutoSize = true;
            this.chk_area.Location = new System.Drawing.Point(21, 29);
            this.chk_area.Name = "chk_area";
            this.chk_area.Size = new System.Drawing.Size(106, 22);
            this.chk_area.TabIndex = 0;
            this.chk_area.Text = "計算面積";
            this.chk_area.UseVisualStyleBackColor = true;
            // 
            // chk_perimeter
            // 
            this.chk_perimeter.AutoSize = true;
            this.chk_perimeter.Location = new System.Drawing.Point(133, 28);
            this.chk_perimeter.Name = "chk_perimeter";
            this.chk_perimeter.Size = new System.Drawing.Size(106, 22);
            this.chk_perimeter.TabIndex = 1;
            this.chk_perimeter.Text = "計算周長";
            this.chk_perimeter.UseVisualStyleBackColor = true;
            // 
            // chk_type
            // 
            this.chk_type.AutoSize = true;
            this.chk_type.Location = new System.Drawing.Point(259, 28);
            this.chk_type.Name = "chk_type";
            this.chk_type.Size = new System.Drawing.Size(160, 22);
            this.chk_type.TabIndex = 2;
            this.chk_type.Text = "輸出三角形類別";
            this.chk_type.UseVisualStyleBackColor = true;
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(21, 58);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(398, 213);
            this.txt_output.TabIndex = 0;
            // 
            // bnt_calculate
            // 
            this.bnt_calculate.Location = new System.Drawing.Point(330, 22);
            this.bnt_calculate.Name = "bnt_calculate";
            this.bnt_calculate.Size = new System.Drawing.Size(89, 30);
            this.bnt_calculate.TabIndex = 1;
            this.bnt_calculate.Text = "計算";
            this.bnt_calculate.UseVisualStyleBackColor = true;
            this.bnt_calculate.Click += new System.EventHandler(this.bnt_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 640);
            this.Controls.Add(this.grp_function);
            this.Controls.Add(this.grp_select);
            this.Controls.Add(this.grp_coordinate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_coordinate.ResumeLayout(false);
            this.grp_coordinate.PerformLayout();
            this.grp_select.ResumeLayout(false);
            this.grp_select.PerformLayout();
            this.grp_function.ResumeLayout(false);
            this.grp_function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_coordinate;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_point3;
        private System.Windows.Forms.Label lbl_point2;
        private System.Windows.Forms.Label lbl_point1;
        private System.Windows.Forms.TextBox txt_y3;
        private System.Windows.Forms.TextBox txt_y2;
        private System.Windows.Forms.TextBox txt_y1;
        private System.Windows.Forms.TextBox txt_x3;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.GroupBox grp_select;
        private System.Windows.Forms.CheckBox chk_type;
        private System.Windows.Forms.CheckBox chk_perimeter;
        private System.Windows.Forms.CheckBox chk_area;
        private System.Windows.Forms.GroupBox grp_function;
        private System.Windows.Forms.Button bnt_calculate;
        private System.Windows.Forms.TextBox txt_output;
    }
}

