using LibraryManagementApplication.bus;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VehicleFactoryApp.bus;

namespace LibraryManagementApplication
{
    public partial class fmMovie : Form
    {
        int index;
        List<Movie> movies = new List<Movie>();

        public fmMovie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            if (!string.IsNullOrEmpty(tbMovieCode.Text) && Validator.IsHigher(int.Parse(tbHour.Text), int.Parse(tbMinute.Text), int.Parse(tbSecond.Text)) == true)
            {
                movie.MovieCode = int.Parse(tbMovieCode.Text);
                movie.Title = tbTitle.Text;
                movie.MovieType = (MovieType)Enum.Parse(typeof(MovieType), cbMovieType.Text);
                movie.Language = tbLanguage.Text;
                movie.Actor.Name = tbActor.Text;
                movie.Duration.NumberOfHour = int.Parse(tbHour.Text);
                movie.Duration.NmuberOfMinute = int.Parse(tbMinute.Text);
                movie.Duration.NumberOfSecond = int.Parse(tbSecond.Text);
                movie.Year = int.Parse(tbYear.Text);

                movies.Add(movie);
                MessageBox.Show("< Movie Added! >");
                Refresh();
            }
            else
            {
                MessageBox.Show("Movie Code cannot be null or Duration is invalid");
            }
        }

        private void Refresh()
        {
            lbMovies.Items.Clear();
            
            foreach (Movie aMovie in movies)
                lbMovies.Items.Add(aMovie);

            Movie movie = new Movie();

            tbMovieCode.Text = "";
            tbTitle.Text = "";
            cbMovieType.Text = movie.MovieType.ToString();
            tbLanguage.Text = "";
            tbActor.Text = "";
            tbHour.Text = "";
            tbMinute.Text = "";
            tbSecond.Text = "";
            tbYear.Text = "";

            tbMovieCode.Focus();
        }

        private void Erase()
        {
            Movie movie = new Movie();
            lbMovies.Items.Clear();
            tbMovieCode.Text = "";
            tbTitle.Text = "";
            cbMovieType.Text = movie.MovieType.ToString();
            tbLanguage.Text = "";
            tbActor.Text = "";
            tbHour.Text = "";
            tbMinute.Text = "";
            tbSecond.Text = "";
            tbYear.Text = "";
            tbSearch.Text = "";
            tbMovieCode.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Erase();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                movies[index].MovieCode = int.Parse(tbMovieCode.Text);
                movies[index].Title = tbTitle.Text;
                movies[index].MovieType = (MovieType)Enum.Parse(typeof(MovieType), cbMovieType.Text);
                movies[index].Language = tbLanguage.Text;
                movies[index].Actor.Name = tbActor.Text;
                movies[index].Duration.NumberOfHour = int.Parse(tbHour.Text);
                movies[index].Duration.NmuberOfMinute = int.Parse(tbMinute.Text);
                movies[index].Duration.NumberOfSecond = int.Parse(tbSecond.Text);
                movies[index].Year = int.Parse(tbYear.Text);
            }
            catch { }

            Refresh();
        }

        private void fmLibrary_Load(object sender, EventArgs e)
        {
            cbMovieType.DataSource = Enum.GetValues(typeof(MovieType));

            tbMovieCode.Focus();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbMovies.SelectedIndex;
            tbMovieCode.Text = Convert.ToString(movies[index].MovieCode);
            tbTitle.Text = movies[index].Title;
            cbMovieType.Text = movies[index].MovieType.ToString();
            tbLanguage.Text = movies[index].Language;
            tbActor.Text = movies[index].Actor.Name;
            tbHour.Text = Convert.ToString(movies[index].Duration.NumberOfHour);
            tbMinute.Text = Convert.ToString(movies[index].Duration.NmuberOfMinute);
            tbSecond.Text = Convert.ToString(movies[index].Duration.NumberOfSecond);
            tbYear.Text = Convert.ToString(movies[index].Year);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to remove this book?";
            string caption = "Removing!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.movies.RemoveAt(index);
                MessageBox.Show("\n Student number  " + ++index + " removed ");
                Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to exit?";
            string caption = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            lbMovies.Items.Clear();
            foreach (Movie movie in movies)
            {
                if (movie.Title == tbSearch.Text)
                {
                    lbMovies.Items.Add(movie);
                }
            }
        }
    }
}
