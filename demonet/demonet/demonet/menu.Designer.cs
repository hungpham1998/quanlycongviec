﻿namespace demonet
{
    partial class menu
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chao = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(398, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 148);
            this.button5.TabIndex = 5;
            this.button5.Text = "BÁO CÁO TUẦN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(998, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 143);
            this.button4.TabIndex = 4;
            this.button4.Text = "CÔNG VIỆC";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(695, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 144);
            this.button3.TabIndex = 3;
            this.button3.Text = "THÀNH VIÊN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 144);
            this.button2.TabIndex = 2;
            this.button2.Text = "DỰ ÁN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 144);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chao
            // 
            this.chao.AutoSize = true;
            this.chao.Location = new System.Drawing.Point(1162, 42);
            this.chao.Name = "chao";
            this.chao.Size = new System.Drawing.Size(46, 17);
            this.chao.TabIndex = 0;
            this.chao.Text = "label1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 148);
            this.button6.TabIndex = 6;
            this.button6.Text = "ĐÁNH GIÁ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(695, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(219, 148);
            this.button7.TabIndex = 7;
            this.button7.Text = "BÁO CÁO TỔNG HƠPK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 608);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label chao;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}