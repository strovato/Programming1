﻿namespace FontSelector
{
    partial class FontSelector
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
            this.textSizeList = new System.Windows.Forms.ListBox();
            this.textFontList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSizeList
            // 
            this.textSizeList.FormattingEnabled = true;
            this.textSizeList.Items.AddRange(new object[] {
            "8",
            "14",
            "20",
            "24"});
            this.textSizeList.Location = new System.Drawing.Point(39, 31);
            this.textSizeList.Name = "textSizeList";
            this.textSizeList.Size = new System.Drawing.Size(51, 56);
            this.textSizeList.TabIndex = 2;
            this.textSizeList.SelectedIndexChanged += new System.EventHandler(this.textSizeList_SelectedIndexChanged);
            // 
            // textFontList
            // 
            this.textFontList.FormattingEnabled = true;
            this.textFontList.Items.AddRange(new object[] {
            "Arial",
            "Calabri",
            "Georgia",
            "Times New Roman"});
            this.textFontList.Location = new System.Drawing.Point(150, 31);
            this.textFontList.Name = "textFontList";
            this.textFontList.Size = new System.Drawing.Size(105, 56);
            this.textFontList.TabIndex = 3;
            this.textFontList.SelectedIndexChanged += new System.EventHandler(this.textFontList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Font";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hello";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FontSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFontList);
            this.Controls.Add(this.textSizeList);
            this.Controls.Add(this.button1);
            this.Name = "FontSelector";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox textSizeList;
        private System.Windows.Forms.ListBox textFontList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

