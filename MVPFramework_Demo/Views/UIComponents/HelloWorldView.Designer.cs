﻿namespace MVPFramework_Demo
{
    partial class HelloWorldView
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
            this.lbsay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsay
            // 
            this.lbsay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsay.AutoSize = true;
            this.lbsay.Location = new System.Drawing.Point(339, 171);
            this.lbsay.Name = "lbsay";
            this.lbsay.Size = new System.Drawing.Size(41, 12);
            this.lbsay.TabIndex = 0;
            this.lbsay.Text = "label1";
            this.lbsay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbsay.Click += new System.EventHandler(this.label1_Click);
            // 
            // HelloWorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsay);
            this.Name = "HelloWorldView";
            this.Text = "HelloWorld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbsay;
    }
}
