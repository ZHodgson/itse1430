﻿using System;
using System.Windows.Forms;

using MovieLibrary.Business;
using MovieLibrary.Winforms;

namespace MovieLibrary
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();

            _movies = new MemoryMovieDatabase();

            #region Playing with objects

            //Full name
            //MovieLibrary.Business.Movie;
            //var movie = new Movie();

            //movie.title = "Jaws";
            //movie.description = movie.title;

            //movie = new Movie();

            //DisplayMovie(movie);
            //DisplayMovie(null);
            //DisplayConfirmation("Are you sure?", "Start");
            #endregion
        }
        #endregion

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);

            new SeedDatabase().SeedIfEmpty(_movies);

            UpdateUI();
        }

        private Movie GetSelectedMovie ()
        {
            return lstMovies.SelectedItem as Movie;
        }

        private void UpdateUI ()
        {
            lstMovies.Items.Clear();

            var movies = _movies.GetAll();
            foreach (var movie in movies)
            {
                lstMovies.Items.Add(movie);
            };
        }

        #region Event Handlers

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            MovieForm child = new MovieForm();

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                //TODO: Save the movie
                var movie = _movies.Add(child.Movie);
                if (movie != null)
                {
                    UpdateUI();
                    return;
                };

                DisplayError("Add failed");
            } while (true);
        }

        private void OnMovieEdit ( object sender, EventArgs e )
        {
            //Verify movie
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            var child = new MovieForm();
            child.Movie = movie;
            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                // Save the movie
                var error = _movies.Update(movie.Id, child.Movie);
                if (String.IsNullOrEmpty(error))
                {
                    UpdateUI();
                    return;
                };

                DisplayError(error);
            } while (true);
        }

        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //Verify movie
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            //Confirm
            if (!DisplayConfirmation($"Are you sure you want to delete {movie.Title}?", "Delete"))
                return;

            //TODO: Delete
            _movies.Delete(movie.Id);
            UpdateUI();
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }
        #endregion

        #region Private Members

        private readonly MemoryMovieDatabase _movies;

        private bool DisplayConfirmation ( string message, string title )
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

        /// <summary>Displays an error message.</summary>
        /// <param name="message">Error to display.</param>
        private void DisplayError ( string message )
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}
