using MyForm.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void b_num_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button b_num = (Button)sender;
                this.t_equation.AppendText(b_num.Text);
            }
        }

        private void b_equal_Click(object sender, EventArgs e)
        {
            this.t_result.Text = EquationUtil.ComputeEquation(this.t_equation.Text);
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            int length = this.t_equation.Text.Length-1;
            if (length >= 0)
            {
                this.t_equation.Text = this.t_equation.Text.Remove(length);
                this.t_equation.SelectionStart = length;
            }
        }

        private void b_clean_Click(object sender, EventArgs e)
        {
            this.t_equation.Text = "";
            this.t_result.Text = "";
        }

        private void b_result_Click(object sender, EventArgs e)
        {
            this.t_equation.Text = string.Concat(this.t_equation.Text, this.t_result.Text);
        }

        private void b_cleanq_Click(object sender, EventArgs e)
        {
            this.t_equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                case '-':
                case '+':
                case '*':
                case '/':
                case '(':
                case ')':
                    this.t_equation.AppendText(e.KeyChar.ToString());
                    break;
                case '=':
                    b_equal_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    b_del_Click(sender, e);
                    break;
                case Keys.Enter:
                    b_equal_Click(sender, e);
                    break;
                case Keys.Delete:
                    b_cleanq_Click(sender, e);
                    break;
                default:
                    break;
            }
        }
    }
}
