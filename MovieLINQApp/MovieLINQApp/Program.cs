using System;
using MovieLINQApp.Entities;
using MovieLINQApp.Helpers;
using System.Collections.Generic;
using System.Linq;


namespace MovieLINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = MovieHelper.GetAllActionMovies();
            Console.ForegroundColor = ConsoleColor.Red;
            //Find all movies that their titles starts with "L"
            //LAMBDA
            var moviesTitleL = movies.Where(movie => movie.Title.StartsWith('L')).ToList();
            moviesTitleL.ForEach(movie => Console.WriteLine(movie.Title));
            
            //QUERY
            var movieTitleLQ = (from movie in movies where movie.Title.StartsWith('L') select movie.Title).ToList();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            //Find the NUMBER of movies that have rating higher than 7.5
            //LAMBDA
            var numberMoviesRating = movies.Where(movie => movie.Rating > 7.5).ToList().Count;
            //Console.WriteLine(numberMoviesRating);
            //Query
            var numberMoviesRatingQ = (from movie in movies where movie.Rating > 7.5 select movie).ToList().Count;
            Console.WriteLine(numberMoviesRatingQ);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies TITLES with year of production before 2005
            //LAMBDA
            var allMovieTitlesL = movies.Where(movie => movie.Year < 2005).Select(movie => movie.Title).ToList();
            //allMovieTitlesL.ForEach(movie => Console.WriteLine(movie));

            //Query
            var allMoviesTitleQ = (from movie in movies where movie.Year > 2005 select movie.Title).ToList();
            allMoviesTitleQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies TITLES and RATING that have rating higher then 8.0
            //LAMBDA
            var allTitlesHighRatingL = movies.Where(movie => movie.Rating > 8.0).Select(movie => new {  movie.Title, movie.Rating }).ToList();
            allTitlesHighRatingL.ForEach(movie => Console.WriteLine(movie));

            //Query
            var allTitlesHighRatingQ = (from movie in movies where movie.Rating > 7.5 select movie ).Select(movie => new { title = movie.Title, rating = movie.Rating }).ToList();
            //allTitlesHighRatingQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------");
            //Find first 5 movies that have duration time longer then 2 hours
            //LAMBDA
            var first5Movies = movies.Where(movie => movie.Duration > 120).Take(5).ToList();
            //first5Movies.ForEach(movie => Console.WriteLine(movie.Title));
            //Query
            var first5MoviesQ = (from movie in movies where movie.Duration > 120 select movie).Take(5).ToList();
            first5MoviesQ.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            //Find last 3 movies TITLES and DURATION that have duration less then 2 hours
            //LAMBDA
            var last3Movies = movies.Where(movie => movie.Duration < 120).Select(movie => new { movie.Title, movie.Duration }).TakeLast(3).ToList();
            //last3Movies.ForEach(movie => Console.WriteLine(movie));

            //Query
            var last3MoviesQ = (from movie in movies where movie.Duration < 120 select movie).Select(movie => new { movie.Title, movie.Duration }).TakeLast(3).ToList();
            last3MoviesQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed
            //LAMBDA
            var allTitlesRatingDesc = movies.OrderByDescending(movie => movie.Duration).Select(movie => new { movie.Title, movie.Rating }).ToList();
            //allTitlesRatingDesc.ForEach(movie => Console.WriteLine(movie));

            //Query
            var allTitlesRatingDescQ = (from movie in movies orderby movie.Duration descending select movie).Select(movie => new { movie.Title, movie.Rating }).ToList();
            allTitlesRatingDescQ.ForEach(movie => Console.WriteLine(movie));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            //LAMBDA
            var allMoviesStartAIncludes7Char = movies.Where(movie => !movie.Title.StartsWith('A') && movie.Title.Length > 7).ToList();
            //allMoviesStartAIncludes7Char.ForEach(movie => Console.WriteLine(movie.Title));
            //Query
            var allMoviesStartAIncludes7ChaQ = (from movie in movies where !movie.Title.StartsWith('A') && movie.Title.Length > 7 select movie).ToList();
            allMoviesStartAIncludes7ChaQ.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour  and 50min
            //LAMBDA
            var moviesRatingHihger7 = movies.Where(movie => movie.Rating > 7.2 && movie.Duration < 110).Select(movie => movie.Title).ToList();
            //moviesRatingHihger7.ForEach(movie => Console.WriteLine(movie));

            //Query
            var moviesRatingHigher7Q = (from movie in movies where movie.Rating > 7.2 && movie.Duration < 110 select movie).ToList();
            moviesRatingHigher7Q.ForEach(movie => Console.WriteLine(movie.Title));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------------------------------------");
            //Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            //LAMBDA
            var moviesTitlesLess10Char = movies.Where(movie => movie.Title.Length < 10 && movie.Duration > 120).OrderBy(movie => movie.Title).Select(movie => new { movie.Title, movie.Rating }).ToList();
            //moviesTitlesLess10Char.ForEach(movie => Console.WriteLine(movie));

            //Query
            var moviesTitlesLess10CharQ = (from movie in movies where movie.Title.Length < 10 && movie.Duration > 120 orderby movie.Title select movie).Select(movie => new { movie.Title, movie.Rating }).ToList();
            moviesTitlesLess10CharQ.ForEach(movie => Console.WriteLine(movie));

            Console.ReadLine();
        }
    }
}
