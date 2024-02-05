
namespace Quiz5
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
            this.lbl_point1 = new System.Windows.Forms.Label();
            this.lbl_Point2 = new System.Windows.Forms.Label();
            this.lbl_Point3 = new System.Windows.Forms.Label();
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.grp_coordenter = new System.Windows.Forms.GroupBox();
            this.chk_area = new System.Windows.Forms.CheckBox();
            this.chk_Tritype = new System.Windows.Forms.CheckBox();
            this.chk_perimeter = new System.Windows.Forms.CheckBox();
            this.grp_select = new System.Windows.Forms.GroupBox();
            this.grp_output = new System.Windows.Forms.GroupBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.grp_coordenter.SuspendLayout();
            this.grp_select.SuspendLayout();
            this.grp_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_point1
            // 
            this.lbl_point1.AutoSize = true;
            this.lbl_point1.Location = new System.Drawing.Point(28, 60);
            this.lbl_point1.Name = "lbl_point1";
            this.lbl_point1.Size = new System.Drawing.Size(51, 18);
            this.lbl_point1.TabIndex = 0;
            this.lbl_point1.Text = "Point1";
            // 
            // lbl_Point2
            // 
            this.lbl_Point2.AutoSize = true;
            this.lbl_Point2.Location = new System.Drawing.Point(28, 106);
            this.lbl_Point2.Name = "lbl_Point2";
            this.lbl_Point2.Size = new System.Drawing.Size(51, 18);
            this.lbl_Point2.TabIndex = 1;
            this.lbl_Point2.Text = "Point2";
            // 
            // lbl_Point3
            // 
            this.lbl_Point3.AutoSize = true;
            this.lbl_Point3.Location = new System.Drawing.Point(28, 148);
            this.lbl_Point3.Name = "lbl_Point3";
            this.lbl_Point3.Size = new System.Drawing.Size(51, 18);
            this.lbl_Point3.TabIndex = 2;
            this.lbl_Point3.Text = "Point3";
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(187, 26);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(20, 18);
            this.lbl_X.TabIndex = 9;
            this.lbl_X.Text = "X";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(381, 26);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(20, 18);
            this.lbl_Y.TabIndex = 10;
            this.lbl_Y.Text = "Y";
            // 
            // grp_coordenter
            // 
            this.grp_coordenter.Controls.Add(this.lbl_X);
            this.grp_coordenter.Controls.Add(this.lbl_Y);
            this.grp_coordenter.Controls.Add(this.lbl_point1);
            this.grp_coordenter.Controls.Add(this.lbl_Point2);
            this.grp_coordenter.Controls.Add(this.lbl_Point3);
            this.grp_coordenter.Location = new System.Drawing.Point(32, 30);
            this.grp_coordenter.Name = "grp_coordenter";
            this.grp_coordenter.Size = new System.Drawing.Size(567, 217);
            this.grp_coordenter.TabIndex = 11;
            this.grp_coordenter.TabStop = false;
            this.grp_coordenter.Text = "座標輸入";
            // 
            // chk_area
            // 
            this.chk_area.AutoSize = true;
            this.chk_area.Location = new System.Drawing.Point(17, 44);
            this.chk_area.Name = "chk_area";
            this.chk_area.Size = new System.Drawing.Size(106, 22);
            this.chk_area.TabIndex = 12;
            this.chk_area.Text = "計算面積";
            this.chk_area.UseVisualStyleBackColor = true;
            // 
            // chk_Tritype
            // 
            this.chk_Tritype.AutoSize = true;
            this.chk_Tritype.Location = new System.Drawing.Point(357, 44);
            this.chk_Tritype.Name = "chk_Tritype";
            this.chk_Tritype.Size = new System.Drawing.Size(160, 22);
            this.chk_Tritype.TabIndex = 13;
            this.chk_Tritype.Text = "輸出三角形類別";
            this.chk_Tritype.UseVisualStyleBackColor = true;
            // 
            // chk_perimeter
            // 
            this.chk_perimeter.AutoSize = true;
            this.chk_perimeter.Location = new System.Drawing.Point(180, 44);
            this.chk_perimeter.Name = "chk_perimeter";
            this.chk_perimeter.Size = new System.Drawing.Size(106, 22);
            this.chk_perimeter.TabIndex = 14;
            this.chk_perimeter.Text = "計算周長";
            this.chk_perimeter.UseVisualStyleBackColor = true;
            // 
            // grp_select
            // 
            this.grp_select.Controls.Add(this.chk_perimeter);
            this.grp_select.Controls.Add(this.chk_Tritype);
            this.grp_select.Controls.Add(this.chk_area);
            this.grp_select.Location = new System.Drawing.Point(32, 263);
            this.grp_select.Name = "grp_select";
            this.grp_select.Size = new System.Drawing.Size(567, 89);
            this.grp_select.TabIndex = 15;
            this.grp_select.TabStop = false;
            this.grp_select.Text = "選項";
            // 
            // grp_output
            // 
            this.grp_output.Controls.Add(this.btn_calculate);
            this.grp_output.Controls.Add(this.txt_output);
            this.grp_output.Location = new System.Drawing.Point(32, 371);
            this.grp_output.Name = "grp_output";
            this.grp_output.Size = new System.Drawing.Size(567, 333);
            this.grp_output.TabIndex = 16;
            this.grp_output.TabStop = false;
            this.grp_output.Text = "功能鍵與輸出";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(438, 28);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(111, 32);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "計算";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(17, 81);
            this.txt_output.Multiline = true;
            this.txt_output.Name = "txt_output";
            this.txt_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_output.Size = new System.Drawing.Size(532, 227);
            this.txt_output.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 717);
            this.Controls.Add(this.grp_output);
            this.Controls.Add(this.grp_select);
            this.Controls.Add(this.grp_coordenter);
            this.Name = "Form1";
            this.Text = "兩點之間的距離";
            this.grp_coordenter.ResumeLayout(false);
            this.grp_coordenter.PerformLayout();
            this.grp_select.ResumeLayout(false);
            this.grp_select.PerformLayout();
            this.grp_output.ResumeLayout(false);
            this.grp_output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_point1;
        private System.Windows.Forms.Label lbl_Point2;
        private System.Windows.Forms.Label lbl_Point3;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.GroupBox grp_coordenter;
        private System.Windows.Forms.CheckBox chk_area;
        private System.Windows.Forms.CheckBox chk_Tritype;
        private System.Windows.Forms.CheckBox chk_perimeter;
        private System.Windows.Forms.GroupBox grp_select;
        private System.Windows.Forms.GroupBox grp_output;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txt_output;
    }
}

