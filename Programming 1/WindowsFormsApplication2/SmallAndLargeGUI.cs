using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class SmallAndLargeGUI : Form
    {
        static int[] Nums = new int[10];
        static int I = 0;

        public SmallAndLargeGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (I == Nums.Length - 1)
            {
                Nums[I] = Convert.ToInt32(textBox1.Text); 
                Limits(Nums);
                Application.Exit();
            }
            else
            {
                Nums[I] = Convert.ToInt32(textBox1.Text);
                I++;
                textBox1.Clear();
            }
        }

        static void Limits(int[] Z)
        {
            int Max = Z.Max();
            int Min = Z.Min();

            MessageBox.Show("The smallest number is " + Min + ", and the largest number is " + Max + ".");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
