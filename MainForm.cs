using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 专治骗子
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {
            urlBox.ForeColor = Color.Black;
        }

        private void UserKeyBox_TextChanged(object sender, EventArgs e)
        {
            userKeyBox.ForeColor = Color.Black;
        }

        private void HttpMethodBox_TextChanged(object sender, EventArgs e)
        {
            httpMethodBox.ForeColor = Color.Black;
        }

        private void PasswordKeyBox_TextChanged(object sender, EventArgs e)
        {
            passwordKeyBox.ForeColor = Color.Black;
        }

        private void NumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            numBox.ForeColor = Color.Black;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((!numBox.ForeColor.Equals(Color.Black)) || (!httpMethodBox.ForeColor.Equals(Color.Black)) || (!passwordKeyBox.ForeColor.Equals(Color.Black)) || (!userKeyBox.ForeColor.Equals(Color.Black)) || (!urlBox.ForeColor.Equals(Color.Black)))
            {
                button1.Text = "还没填完呢急啥子qwq";
                return;
            }

            Program.Bomb(urlBox.Text,userKeyBox.Text,passwordKeyBox.Text,httpMethodBox.Text,numBox.ForeColor.Equals(Color.Black)?int.Parse(numBox.Text):1);
            //配置数据
            Close();
        }

        private void UrlBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!urlBox.ForeColor.Equals(Color.Black))
            {
                urlBox.Text = "";
            }
        }

        private void UserKeyBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!userKeyBox.ForeColor.Equals(Color.Black))
            {
                userKeyBox.Text = "";
            }
        }

        private void PasswordKeyBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!passwordKeyBox.ForeColor.Equals(Color.Black))
            {
                passwordKeyBox.Text = "";
            }
        }

        private void HttpMethodBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!httpMethodBox.ForeColor.Equals(Color.Black))
            {
                httpMethodBox.Text = "";
            }
        }

        private void NumBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!numBox.ForeColor.Equals(Color.Black))
            {
                numBox.Text = "";
            }
        }
    }
}
