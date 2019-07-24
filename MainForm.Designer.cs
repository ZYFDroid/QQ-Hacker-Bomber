namespace 专治骗子
{
    partial class MainForm
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userKeyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordKeyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.httpMethodBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.ForeColor = System.Drawing.Color.Silver;
            this.urlBox.Location = new System.Drawing.Point(91, 36);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(446, 21);
            this.urlBox.TabIndex = 0;
            this.urlBox.Text = "在此处输入完整轰炸地址 Type whole url here";
            this.urlBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UrlBox_MouseClick);
            this.urlBox.TextChanged += new System.EventHandler(this.UrlBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "UserKey:";
            // 
            // userKeyBox
            // 
            this.userKeyBox.ForeColor = System.Drawing.Color.Silver;
            this.userKeyBox.Location = new System.Drawing.Point(91, 74);
            this.userKeyBox.Name = "userKeyBox";
            this.userKeyBox.Size = new System.Drawing.Size(446, 21);
            this.userKeyBox.TabIndex = 2;
            this.userKeyBox.Text = "在此输入网站接入的UserKey";
            this.userKeyBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserKeyBox_MouseClick);
            this.userKeyBox.TextChanged += new System.EventHandler(this.UserKeyBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(-2, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "PasswordKey:";
            // 
            // passwordKeyBox
            // 
            this.passwordKeyBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordKeyBox.Location = new System.Drawing.Point(91, 112);
            this.passwordKeyBox.Name = "passwordKeyBox";
            this.passwordKeyBox.Size = new System.Drawing.Size(446, 21);
            this.passwordKeyBox.TabIndex = 4;
            this.passwordKeyBox.Text = "在此输入网站接入的PasswordKey";
            this.passwordKeyBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordKeyBox_MouseClick);
            this.passwordKeyBox.TextChanged += new System.EventHandler(this.PasswordKeyBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "HttpMethod:";
            // 
            // httpMethodBox
            // 
            this.httpMethodBox.ForeColor = System.Drawing.Color.Silver;
            this.httpMethodBox.Location = new System.Drawing.Point(91, 148);
            this.httpMethodBox.Name = "httpMethodBox";
            this.httpMethodBox.Size = new System.Drawing.Size(446, 21);
            this.httpMethodBox.TabIndex = 6;
            this.httpMethodBox.Text = "在此处输入完整轰炸地址 Type whole url here";
            this.httpMethodBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HttpMethodBox_MouseClick);
            this.httpMethodBox.TextChanged += new System.EventHandler(this.HttpMethodBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "线程数:";
            // 
            // numBox
            // 
            this.numBox.ForeColor = System.Drawing.Color.Silver;
            this.numBox.Location = new System.Drawing.Point(91, 186);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(446, 21);
            this.numBox.TabIndex = 8;
            this.numBox.Text = "数字越大，炸的越爽，当然骗子可能把你的IP封了你就没法炸了qwp";
            this.numBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumBox_MouseClick);
            this.numBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            this.numBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Let\'s Bomb!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.httpMethodBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordKeyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userKeyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QQHarkerBomber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userKeyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordKeyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox httpMethodBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Button button1;
    }
}