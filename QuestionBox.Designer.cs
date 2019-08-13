namespace 专治骗子
{
    partial class QuestionBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "是否使用GUI界面?";
            // 
            // yes
            // 
            this.yes.Location = new System.Drawing.Point(43, 87);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(86, 35);
            this.yes.TabIndex = 1;
            this.yes.Text = "是";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(233, 87);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(86, 35);
            this.no.TabIndex = 2;
            this.no.Text = "否";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.No_Click);
            // 
            // QuestionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 134);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label1);
            this.Name = "QuestionBox";
            this.Text = "QQHarkerBomber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
    }
}