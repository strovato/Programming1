using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ExponentGUI

{
    public partial class ExponentGUI : Form
    {
        static int X, A, B;
        

        public ExponentGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            X = Convert.ToInt32(textBox1.Text);
            A = Squared(X);
            B = Cubed(X);
            MessageBox.Show("Your number squared is: " + A + "\n\nYour number cubed is: " + B);

        }

        private void label1_Click(object sender, EventArgs e)
        {

           
             
        }

        static int Squared(int Z)
        {
            return Z * Z;
        }

        static int Cubed(int Y)
        {
            return Squared(Y) * Y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
