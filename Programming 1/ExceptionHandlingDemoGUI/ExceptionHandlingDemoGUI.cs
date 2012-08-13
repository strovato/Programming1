using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExceptionHandlingDemoGUI
{
    public partial class ExceptionHandlingDemoGUI : Form
    {
        public ExceptionHandlingDemoGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test = 0;
            try
            {
                test = Convert.ToInt32(textBox1.Text);
                MessageBox.Show("You entered " + test + ".");
            }
            catch (Exception)
            {
                MessageBox.Show("You did not enter an Integer.");
            }

            textBox1.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
