using MovieLINQApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLINQApp.Helpers
{
    public class MovieHelper
    {
        public static List<Movie> GetAllActionMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "The Mountain II", Year = 2016, Rating = 8.9f, Duration = 135 },
                new Movie(){ Title = "Seven Samurai", Year = 1954, Rating = 8.6f, Duration = 207 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Man from Nowhere", Year = 2010, Rating = 7.8f, Duration = 119 },
                new Movie(){ Title = "Gladiator", Year = 2000, Rating = 8.5f, Duration = 155 },
                new Movie(){ Title = "Avengers: Endgame", Year = 2009, Rating = 8.4f, Duration = 181 },
                new Movie(){ Title = "Kung Fu Hustle", Year = 2004, Rating = 7.7f, Duration = 99 },
                new Movie(){ Title = "Iron Man", Year = 2008, Rating = 7.9f, Duration = 126 },
                new Movie(){ Title = "Big Hero 6", Year = 2014, Rating = 7.8f, Duration = 102 },
                new Movie(){ Title = "The Dark Knight", Year = 2008, Rating = 9.0f, Duration = 152 },
                new Movie(){ Title = "13 Assassins", Year = 2010, Rating = 7.6f, Duration = 141 },
                new Movie(){ Title = "Grindhouse", Year = 2007, Rating = 7.5f, Duration = 191 },

                new Movie(){ Title = "The Good, Bad and Ugly", Year = 1966, Rating = 8.8f, Duration = 191 },
                new Movie(){ Title = "The Godfather", Year = 1972, Rating = 9.1f, Duration = 175 },
                new Movie(){ Title = "The Godfather II", Year = 1974, Rating = 9.0f, Duration = 202 },
                new Movie(){ Title = "Thr Godfather III", Year = 1990, Rating = 7.6f, Duration = 162 },
                new Movie(){ Title = "Fight Club", Year = 1999, Rating = 8.8f, Duration = 139 },
                new Movie(){ Title = "Pulp Fiction", Year = 1994, Rating = 8.9f, Duration = 154 },
                new Movie(){ Title = "Shindler's List", Year = 1993, Rating = 8.9f, Duration = 195 },
                new Movie(){ Title = "The 13th Warrior", Year = 1999, Rating = 6.6f, Duration = 102 },
                new Movie(){ Title = "The Last  Mohicans", Year = 1992, Rating = 7.7f, Duration = 112 },
                new Movie(){ Title = "Mad Max", Year = 1979, Rating = 6.9f, Duration = 91 },
                new Movie(){ Title = "Logan", Year = 2017, Rating = 8.1f, Duration = 137 },
                new Movie(){ Title = "Rush Hour", Year = 1998, Rating = 7.0f, Duration = 98 },
                new Movie(){ Title = "A Few Best Man", Year = 2011, Rating = 5.7f, Duration = 97 },
                new Movie(){ Title = "The Gentlmen", Year = 2019, Rating = 8.0f, Duration = 113 },
                new Movie(){ Title = "Going in Style", Year = 2017, Rating = 6.6f, Duration = 96 },
                new Movie(){ Title = "Fast and Furious: Hobs&Show", Year = 2019, Rating = 6.5f, Duration = 137 },
                new Movie(){ Title = "John Wick", Year = 2014, Rating = 7.4f, Duration = 101 },
            };
        }
    }
}
