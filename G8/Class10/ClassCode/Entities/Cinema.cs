﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Cinema must be entered");
            }
            if(halls == null || halls.Count == 0)
            {
                throw new Exception("There must be halls");
            }
            if(movies == null || movies.Count == 0)
            {
                throw new Exception("There must be movies");
            }

            Name = name;
            Halls = halls;
            ListOfMovies = movies;
        }

        public void WatchMovie(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}
