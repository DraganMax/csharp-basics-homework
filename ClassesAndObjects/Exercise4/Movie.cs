using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;
 

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        static public Movie[] ratingPG (Movie[] movies)
        {
            
            Movie[] pgFilms = new Movie[movies.Length];

            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i]._rating == "PG")
                {
                    pgFilms[i] = movies[i];
                }
            }
        
            return pgFilms;
        }

        public void ShowMoviesName()
        {
            Console.WriteLine($"Title: {_title}, Studio: {_studio}, Rating: {_rating}");
        }
    }
}
