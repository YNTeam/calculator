namespace MyForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.t_equation = new System.Windows.Forms.TextBox();
            this.b_num1 = new System.Windows.Forms.Button();
            this.b_num2 = new System.Windows.Forms.Button();
            this.b_num3 = new System.Windows.Forms.Button();
            this.b_num4 = new System.Windows.Forms.Button();
            this.b_num5 = new System.Windows.Forms.Button();
            this.b_num6 = new System.Windows.Forms.Button();
            this.b_num7 = new System.Windows.Forms.Button();
            this.b_num8 = new System.Windows.Forms.Button();
            this.b_num9 = new System.Windows.Forms.Button();
            this.b_point = new System.Windows.Forms.Button();
            this.b_num0 = new System.Windows.Forms.Button();
            this.b_equal = new System.Windows.Forms.Button();
            this.t_result = new System.Windows.Forms.TextBox();
            this.b_del = new System.Windows.Forms.Button();
            this.b_add = new System.Windows.Forms.Button();
            this.b_mul = new System.Windows.Forms.Button();
            this.b_left = new System.Windows.Forms.Button();
            this.b_sub = new System.Windows.Forms.Button();
            this.b_div = new System.Windows.Forms.Button();
            this.b_right = new System.Windows.Forms.Button();
            this.b_clean = new System.Windows.Forms.Button();
            this.b_result = new System.Windows.Forms.Button();
            this.b_cleanq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_equation
            // 
            this.t_equation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t_equation.Location = new System.Drawing.Point(12, 12);
            this.t_equation.Name = "t_equation";
            this.t_equation.ReadOnly = true;
            this.t_equation.Size = new System.Drawing.Size(231, 21);
            this.t_equation.TabIndex = 0;
            // 
            // b_num1
            // 
            this.b_num1.Location = new System.Drawing.Point(12, 73);
            this.b_num1.Name = "b_num1";
            this.b_num1.Size = new System.Drawing.Size(31, 28);
            this.b_num1.TabIndex = 1;
            this.b_num1.Text = "1";
            this.b_num1.UseVisualStyleBackColor = true;
            this.b_num1.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num2
            // 
            this.b_num2.Location = new System.Drawing.Point(51, 73);
            this.b_num2.Name = "b_num2";
            this.b_num2.Size = new System.Drawing.Size(31, 28);
            this.b_num2.TabIndex = 2;
            this.b_num2.Text = "2";
            this.b_num2.UseVisualStyleBackColor = true;
            this.b_num2.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num3
            // 
            this.b_num3.Location = new System.Drawing.Point(90, 73);
            this.b_num3.Name = "b_num3";
            this.b_num3.Size = new System.Drawing.Size(31, 28);
            this.b_num3.TabIndex = 3;
            this.b_num3.Text = "3";
            this.b_num3.UseVisualStyleBackColor = true;
            this.b_num3.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num4
            // 
            this.b_num4.Location = new System.Drawing.Point(12, 107);
            this.b_num4.Name = "b_num4";
            this.b_num4.Size = new System.Drawing.Size(31, 28);
            this.b_num4.TabIndex = 4;
            this.b_num4.Text = "4";
            this.b_num4.UseVisualStyleBackColor = true;
            this.b_num4.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num5
            // 
            this.b_num5.Location = new System.Drawing.Point(51, 107);
            this.b_num5.Name = "b_num5";
            this.b_num5.Size = new System.Drawing.Size(31, 28);
            this.b_num5.TabIndex = 5;
            this.b_num5.Text = "5";
            this.b_num5.UseVisualStyleBackColor = true;
            this.b_num5.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num6
            // 
            this.b_num6.Location = new System.Drawing.Point(91, 107);
            this.b_num6.Name = "b_num6";
            this.b_num6.Size = new System.Drawing.Size(31, 28);
            this.b_num6.TabIndex = 6;
            this.b_num6.Text = "6";
            this.b_num6.UseVisualStyleBackColor = true;
            this.b_num6.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num7
            // 
            this.b_num7.Location = new System.Drawing.Point(12, 141);
            this.b_num7.Name = "b_num7";
            this.b_num7.Size = new System.Drawing.Size(31, 28);
            this.b_num7.TabIndex = 7;
            this.b_num7.Text = "7";
            this.b_num7.UseVisualStyleBackColor = true;
            this.b_num7.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num8
            // 
            this.b_num8.Location = new System.Drawing.Point(51, 141);
            this.b_num8.Name = "b_num8";
            this.b_num8.Size = new System.Drawing.Size(31, 28);
            this.b_num8.TabIndex = 8;
            this.b_num8.Text = "8";
            this.b_num8.UseVisualStyleBackColor = true;
            this.b_num8.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num9
            // 
            this.b_num9.Location = new System.Drawing.Point(91, 141);
            this.b_num9.Name = "b_num9";
            this.b_num9.Size = new System.Drawing.Size(31, 28);
            this.b_num9.TabIndex = 9;
            this.b_num9.Text = "9";
            this.b_num9.UseVisualStyleBackColor = true;
            this.b_num9.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_point
            // 
            this.b_point.Font = new System.Drawing.Font("宋体", 10F);
            this.b_point.Location = new System.Drawing.Point(12, 175);
            this.b_point.Name = "b_point";
            this.b_point.Size = new System.Drawing.Size(31, 28);
            this.b_point.TabIndex = 10;
            this.b_point.Text = ".";
            this.b_point.UseVisualStyleBackColor = true;
            this.b_point.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_num0
            // 
            this.b_num0.Location = new System.Drawing.Point(51, 175);
            this.b_num0.Name = "b_num0";
            this.b_num0.Size = new System.Drawing.Size(31, 28);
            this.b_num0.TabIndex = 12;
            this.b_num0.Text = "0";
            this.b_num0.UseVisualStyleBackColor = true;
            this.b_num0.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_equal
            // 
            this.b_equal.Location = new System.Drawing.Point(138, 176);
            this.b_equal.Name = "b_equal";
            this.b_equal.Size = new System.Drawing.Size(68, 28);
            this.b_equal.TabIndex = 13;
            this.b_equal.Text = "=";
            this.b_equal.UseVisualStyleBackColor = true;
            this.b_equal.Click += new System.EventHandler(this.b_equal_Click);
            // 
            // t_result
            // 
            this.t_result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t_result.Location = new System.Drawing.Point(12, 33);
            this.t_result.Name = "t_result";
            this.t_result.ReadOnly = true;
            this.t_result.Size = new System.Drawing.Size(231, 21);
            this.t_result.TabIndex = 14;
            this.t_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_del
            // 
            this.b_del.Location = new System.Drawing.Point(91, 175);
            this.b_del.Name = "b_del";
            this.b_del.Size = new System.Drawing.Size(31, 28);
            this.b_del.TabIndex = 15;
            this.b_del.Text = "←";
            this.b_del.UseVisualStyleBackColor = true;
            this.b_del.Click += new System.EventHandler(this.b_del_Click);
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(138, 73);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(31, 28);
            this.b_add.TabIndex = 16;
            this.b_add.Text = "+";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_mul
            // 
            this.b_mul.Location = new System.Drawing.Point(175, 73);
            this.b_mul.Name = "b_mul";
            this.b_mul.Size = new System.Drawing.Size(31, 28);
            this.b_mul.TabIndex = 17;
            this.b_mul.Text = "*";
            this.b_mul.UseVisualStyleBackColor = true;
            this.b_mul.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_left
            // 
            this.b_left.Location = new System.Drawing.Point(138, 141);
            this.b_left.Name = "b_left";
            this.b_left.Size = new System.Drawing.Size(31, 28);
            this.b_left.TabIndex = 18;
            this.b_left.Text = "(";
            this.b_left.UseVisualStyleBackColor = true;
            this.b_left.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_sub
            // 
            this.b_sub.Location = new System.Drawing.Point(138, 107);
            this.b_sub.Name = "b_sub";
            this.b_sub.Size = new System.Drawing.Size(31, 28);
            this.b_sub.TabIndex = 19;
            this.b_sub.Text = "-";
            this.b_sub.UseVisualStyleBackColor = true;
            this.b_sub.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_div
            // 
            this.b_div.Location = new System.Drawing.Point(175, 107);
            this.b_div.Name = "b_div";
            this.b_div.Size = new System.Drawing.Size(31, 28);
            this.b_div.TabIndex = 20;
            this.b_div.Text = "/";
            this.b_div.UseVisualStyleBackColor = true;
            this.b_div.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_right
            // 
            this.b_right.Location = new System.Drawing.Point(175, 141);
            this.b_right.Name = "b_right";
            this.b_right.Size = new System.Drawing.Size(31, 28);
            this.b_right.TabIndex = 21;
            this.b_right.Text = ")";
            this.b_right.UseVisualStyleBackColor = true;
            this.b_right.Click += new System.EventHandler(this.b_num_Click);
            // 
            // b_clean
            // 
            this.b_clean.Location = new System.Drawing.Point(212, 73);
            this.b_clean.Name = "b_clean";
            this.b_clean.Size = new System.Drawing.Size(31, 28);
            this.b_clean.TabIndex = 22;
            this.b_clean.Text = "C";
            this.b_clean.UseVisualStyleBackColor = true;
            this.b_clean.Click += new System.EventHandler(this.b_clean_Click);
            // 
            // b_result
            // 
            this.b_result.Location = new System.Drawing.Point(212, 141);
            this.b_result.Name = "b_result";
            this.b_result.Size = new System.Drawing.Size(31, 28);
            this.b_result.TabIndex = 23;
            this.b_result.Text = "R";
            this.b_result.UseVisualStyleBackColor = true;
            this.b_result.Click += new System.EventHandler(this.b_result_Click);
            // 
            // b_cleanq
            // 
            this.b_cleanq.Location = new System.Drawing.Point(212, 107);
            this.b_cleanq.Name = "b_cleanq";
            this.b_cleanq.Size = new System.Drawing.Size(31, 28);
            this.b_cleanq.TabIndex = 24;
            this.b_cleanq.Text = "CQ";
            this.b_cleanq.UseVisualStyleBackColor = true;
            this.b_cleanq.Click += new System.EventHandler(this.b_cleanq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 216);
            this.Controls.Add(this.b_cleanq);
            this.Controls.Add(this.b_result);
            this.Controls.Add(this.b_clean);
            this.Controls.Add(this.b_right);
            this.Controls.Add(this.b_div);
            this.Controls.Add(this.b_sub);
            this.Controls.Add(this.b_left);
            this.Controls.Add(this.b_mul);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_del);
            this.Controls.Add(this.t_result);
            this.Controls.Add(this.b_equal);
            this.Controls.Add(this.b_num0);
            this.Controls.Add(this.b_point);
            this.Controls.Add(this.b_num9);
            this.Controls.Add(this.b_num8);
            this.Controls.Add(this.b_num7);
            this.Controls.Add(this.b_num6);
            this.Controls.Add(this.b_num5);
            this.Controls.Add(this.b_num4);
            this.Controls.Add(this.b_num3);
            this.Controls.Add(this.b_num2);
            this.Controls.Add(this.b_num1);
            this.Controls.Add(this.t_equation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "计算器";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_equation;
        private System.Windows.Forms.Button b_num1;
        private System.Windows.Forms.Button b_num2;
        private System.Windows.Forms.Button b_num3;
        private System.Windows.Forms.Button b_num4;
        private System.Windows.Forms.Button b_num5;
        private System.Windows.Forms.Button b_num6;
        private System.Windows.Forms.Button b_num7;
        private System.Windows.Forms.Button b_num8;
        private System.Windows.Forms.Button b_num9;
        private System.Windows.Forms.Button b_point;
        private System.Windows.Forms.Button b_num0;
        private System.Windows.Forms.Button b_equal;
        private System.Windows.Forms.TextBox t_result;
        private System.Windows.Forms.Button b_del;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_mul;
        private System.Windows.Forms.Button b_left;
        private System.Windows.Forms.Button b_sub;
        private System.Windows.Forms.Button b_div;
        private System.Windows.Forms.Button b_right;
        private System.Windows.Forms.Button b_clean;
        private System.Windows.Forms.Button b_result;
        private System.Windows.Forms.Button b_cleanq;
    }
}

