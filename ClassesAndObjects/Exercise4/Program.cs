using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Casino Royale", "Eon Productions", "PG­13");
            Movie movie2 = new Movie("Glass", "Buena Vista International", "PG­13");
            Movie movie3 = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            Movie[] movies = new Movie[3];
            movies[0] = movie1;
            movies[1] = movie2;
            movies[2] = movie3;

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i].ShowMoviesName();
            }
            Console.WriteLine();
            Movie[] pgMovies = Movie.ratingPG(movies);
            Console.WriteLine("Movies with 'PG' rating:");

            for (int i = 0; i < pgMovies.Length; i++)
            {
                if (pgMovies[i] != null)
                pgMovies[i].ShowMoviesName();
            }
            
            Console.Read();
        }
    }
}
