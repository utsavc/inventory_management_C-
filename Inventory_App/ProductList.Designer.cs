namespace Inventory_App
{
    partial class ProductList
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
            this.button1 = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.pName = new System.Windows.Forms.Label();
            this.eEfficiency = new System.Windows.Forms.Label();
            this.pWidth = new System.Windows.Forms.Label();
            this.pDepth = new System.Windows.Forms.Label();
            this.pHeight = new System.Windows.Forms.Label();
            this.pWeight = new System.Windows.Forms.Label();
            this.pWarranty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // categoryBtn
            // 
            this.categoryBtn.Location = new System.Drawing.Point(12, 152);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(110, 42);
            this.categoryBtn.TabIndex = 1;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(12, 226);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(110, 42);
            this.reportBtn.TabIndex = 2;
            this.reportBtn.Text = "Report";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(532, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(211, 81);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(277, 24);
            this.searchBox.TabIndex = 6;
            // 
            // pName
            // 
            this.pName.AutoSize = true;
            this.pName.Location = new System.Drawing.Point(208, 157);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(110, 17);
            this.pName.TabIndex = 7;
            this.pName.Text = "Product Name : ";
            this.pName.Visible = false;
            // 
            // eEfficiency
            // 
            this.eEfficiency.AutoSize = true;
            this.eEfficiency.Location = new System.Drawing.Point(208, 186);
            this.eEfficiency.Name = "eEfficiency";
            this.eEfficiency.Size = new System.Drawing.Size(129, 17);
            this.eEfficiency.TabIndex = 8;
            this.eEfficiency.Text = "Energy Efficiency : ";
            this.eEfficiency.Visible = false;
            // 
            // pWidth
            // 
            this.pWidth.AutoSize = true;
            this.pWidth.Location = new System.Drawing.Point(208, 214);
            this.pWidth.Name = "pWidth";
            this.pWidth.Size = new System.Drawing.Size(141, 17);
            this.pWidth.TabIndex = 9;
            this.pWidth.Text = "Product Width (cm):  ";
            this.pWidth.Visible = false;
            // 
            // pDepth
            // 
            this.pDepth.AutoSize = true;
            this.pDepth.Location = new System.Drawing.Point(208, 239);
            this.pDepth.Name = "pDepth";
            this.pDepth.Size = new System.Drawing.Size(139, 17);
            this.pDepth.TabIndex = 10;
            this.pDepth.Text = "Product Depth (cm): ";
            this.pDepth.Visible = false;
            // 
            // pHeight
            // 
            this.pHeight.AutoSize = true;
            this.pHeight.Location = new System.Drawing.Point(208, 270);
            this.pHeight.Name = "pHeight";
            this.pHeight.Size = new System.Drawing.Size(146, 17);
            this.pHeight.TabIndex = 11;
            this.pHeight.Text = "Product Height  (cm): ";
            this.pHeight.Visible = false;
            // 
            // pWeight
            // 
            this.pWeight.AutoSize = true;
            this.pWeight.Location = new System.Drawing.Point(208, 303);
            this.pWeight.Name = "pWeight";
            this.pWeight.Size = new System.Drawing.Size(95, 17);
            this.pWeight.TabIndex = 12;
            this.pWeight.Text = "Weight (Kg) : ";
            this.pWeight.Visible = false;
            // 
            // pWarranty
            // 
            this.pWarranty.AutoSize = true;
            this.pWarranty.Location = new System.Drawing.Point(208, 336);
            this.pWarranty.Name = "pWarranty";
            this.pWarranty.Size = new System.Drawing.Size(291, 17);
            this.pWarranty.TabIndex = 13;
            this.pWarranty.Text = "Manufacturers Express Warranty  (months) : ";
            this.pWarranty.Visible = false;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 451);
            this.Controls.Add(this.pWarranty);
            this.Controls.Add(this.pWeight);
            this.Controls.Add(this.pHeight);
            this.Controls.Add(this.pDepth);
            this.Controls.Add(this.pWidth);
            this.Controls.Add(this.eEfficiency);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.categoryBtn);
            this.Controls.Add(this.button1);
            this.Name = "ProductList";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.Label pName;
        private System.Windows.Forms.Label eEfficiency;
        private System.Windows.Forms.Label pWidth;
        private System.Windows.Forms.Label pDepth;
        private System.Windows.Forms.Label pHeight;
        private System.Windows.Forms.Label pWeight;
        private System.Windows.Forms.Label pWarranty;
    }
}

