using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class FontSelector : Form
    {
        string textFont;
        int textSize;
        public FontSelector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textSizeList.SelectedIndex < 0)
            {
                textSizeList.SelectedIndex = 0;
            }

            if (textFontList.SelectedIndex < 0)
            {
                textFontList.SelectedIndex = 0;
            }

            textSize = Convert.ToInt32(textSizeList.SelectedItem);
            textFont = Convert.ToString(textFontList.SelectedItem);

            label3.Visible = true;
            label3.Font = new Font(textFont, textSize);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textFontList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textSizeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
