﻿namespace Inventory_App
{
    partial class CategoryList
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
            this.reportBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(12, 216);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(110, 42);
            this.reportBtn.TabIndex = 5;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            // 
            // categoryBtn
            // 
            this.categoryBtn.Location = new System.Drawing.Point(12, 142);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(110, 42);
            this.categoryBtn.TabIndex = 4;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Product ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button2.Location = new System.Drawing.Point(232, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "TV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(376, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Fridge";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Location = new System.Drawing.Point(232, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 46);
            this.button4.TabIndex = 9;
            this.button4.Text = "Washing Machine";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Location = new System.Drawing.Point(542, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 46);
            this.button5.TabIndex = 10;
            this.button5.Text = "Vacuum Cleaner";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.Location = new System.Drawing.Point(376, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 46);
            this.button6.TabIndex = 11;
            this.button6.Text = "Air Fryer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 429);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.categoryBtn);
            this.Controls.Add(this.button1);
            this.Name = "CategoryList";
            this.Text = "CategoryList";
            this.Load += new System.EventHandler(this.CategoryList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}