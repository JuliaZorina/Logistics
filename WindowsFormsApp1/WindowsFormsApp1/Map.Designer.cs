﻿namespace WindowsFormsApp1
{
    partial class Form3
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
            this.button36 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(16, 196);
            this.button36.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(197, 52);
            this.button36.TabIndex = 8;
            this.button36.Text = "Заказы";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(16, 133);
            this.button35.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(197, 52);
            this.button35.TabIndex = 7;
            this.button35.Text = "Грузовое пространство";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(16, 74);
            this.button34.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(197, 52);
            this.button34.TabIndex = 6;
            this.button34.Text = "Маршрут";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(16, 15);
            this.button33.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(197, 52);
            this.button33.TabIndex = 5;
            this.button33.Text = "Заявки";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(257, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(786, 502);
            this.webBrowser1.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Маршрут";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}