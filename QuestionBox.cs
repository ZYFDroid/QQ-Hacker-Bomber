﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 专治骗子
{
    public partial class QuestionBox : Form
    {
        public QuestionBox()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Close();
            MainForm main = new MainForm();
            main.ShowDialog();
        }

        private void No_Click(object sender, EventArgs e)
        {
            new BomberPerformer(new GeneralBomber(Data.url, Data.userKey, Data.passwordKey, Data.httpMethod), Data.threadCount).StartBomber();
            Close();
        }
    }
}
