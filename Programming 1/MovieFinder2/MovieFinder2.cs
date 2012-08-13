using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieFinder2
{
    public partial class MovieFinder2 : Form
    {
        
        
        public MovieFinder2()
        {
            InitializeComponent();
        }
      

        
        private void button1_Click(object sender, EventArgs e)
        {
            int year, year1;

            listBox1.Items.Clear(); 
            listBox2.Items.Clear();

            try
            {
                year = Convert.ToInt32(textBox1.Text);
                year1 = year - 1;

                label2.Visible = true;
                label3.Visible = true;
                listBox1.Visible = true;
                listBox2.Visible = true;

                label2.Text = "Movies released before " + year1 + ":";
                label3.Text = "Movies released in " + year + " or after.";

                
                

                /*
                var preMovies = 
                    from x in this.moviesDataSet.masterMovieList
                    where x.ReleaseDate < year
                    orderby x.ReleaseDate descending
                    select x;
                foreach (var x in preMovies)
                    listBox1.Items.Add(x.ReleaseDate + " " +  x.Title);

                var postMovies =
                    from x in this.moviesDataSet.masterMovieList
                    where x.ReleaseDate >= year
                    orderby x.ReleaseDate descending
                    select x;
                foreach (var x in preMovies)
                    listBox2.Items.Add(x.ReleaseDate + " " + x.Title);
                */

            }
            catch (Exception)
            {
                MessageBox.Show("You did not enter a valid year.");
                textBox1.Clear();
            }
        }

        private void MovieFinder2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDataSet.movieList' table. You can move, or remove it, as needed.
            this.movieListTableAdapter.Fill(this.moviesDataSet.movieList);

        }

       


       

        
    }
}
