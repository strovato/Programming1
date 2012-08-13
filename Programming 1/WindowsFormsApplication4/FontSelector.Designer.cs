namespace WindowsFormsApplication4
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
            this.Font = new System.Windows.Forms.ListBox();
            this.Size = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Font
            // 
            this.Font.FormattingEnabled = true;
            this.Font.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Georgia",
            "Times New Roman"});
            this.Font.Location = new System.Drawing.Point(77, 41);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(119, 56);
            this.Font.TabIndex = 0;
            this.Font.SelectedIndexChanged += new System.EventHandler(this.Font_SelectedIndexChanged);
            // 
            // Size
            // 
            this.Size.FormattingEnabled = true;
            this.Size.Items.AddRange(new object[] {
            "12",
            "24",
            "36",
            "48"});
            this.Size.Location = new System.Drawing.Point(77, 142);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(119, 56);
            this.Size.TabIndex = 1;
            this.Size.SelectedIndexChanged += new System.EventHandler(this.Size_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FontSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Font);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontSelector";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Font;
        private System.Windows.Forms.ListBox Size;
        private System.Windows.Forms.Button button1;
    }
}

