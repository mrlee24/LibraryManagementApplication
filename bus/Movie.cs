using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.bus
{
    class Movie
    {
        private int movieCode;
        private string title;
        private MovieType movieType;
        private string language;
        private Actor actor;
        private Time duration;
        private int year;

        public int MovieCode { get => movieCode; set => movieCode = value; }
        public string Title { get => title; set => title = value; }
        public string Language { get => language; set => language = value; }

        public Actor Actor { get => actor; set => actor = value; }
        public int Year { get => year; set => year = value; }
        public Time Duration { get => duration; set => duration = value; }
        public MovieType MovieType { get => movieType; set => movieType = value; }

        public Movie()
        {
            this.movieCode = 0;
            this.title = "Underfine";
            this.MovieType = MovieType.Undefine;
            this.language = "Underfine";
            this.actor = new Actor();
            this.Duration = new Time();
            this.Year = 2000;
        }

        public Movie(int movieCode, string title, MovieType movieType, string language, Actor actor, Time duration, int year)
        {
            this.movieCode = movieCode;
            this.title = title;
            this.MovieType = movieType;
            this.language = language;
            this.actor = actor;
            this.Duration = duration;
            this.year = year;
        }

        public override string ToString()
        {
            return ("Movie Code: " + this.movieCode + " Title: " + this.title + " Movie Type: " + this.MovieType + " Language: " + this.language + " Actor: " + this.actor.Name + " Duration: " + this.duration.NumberOfHour + ":" + this.duration.NmuberOfMinute + ":" + this.duration.NumberOfSecond + " Year: " + this.year);
        }
    }
}
