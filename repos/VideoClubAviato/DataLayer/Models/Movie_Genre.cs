using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Movie_Genre
    {
        //TABELA MOVIES!
        private int Id_Movie;
        private string Movie_Name;
        private int Movie_Year;
        private double Movie_Duration;
        private bool Movie_Oskar;
        private double Movie_IMDB_Rating;
        private string Movie_Status;
        private int Movie_Amount;
        private double Movie_Rental_Price;
        private int Id_Genre_Genres;
        private int Id_Director_Directors;


        //TABELA GENRE

        private int Id_Genre;
        private string Genre_Name;

        public Movie_Genre() { }

        public Movie_Genre(int id_Movie, string movie_Name, int movie_Year, double movie_Duration, bool movie_Oskar, double movie_IMDB_Rating, string movie_Status, int movie_Amount, double movie_Rental_Price, int id_Genre_Genres, int id_Director_Directors, int id_Genre, string genre_Name)
        {
            Id_Movie = id_Movie;
            Movie_Name = movie_Name;
            Movie_Year = movie_Year;
            Movie_Duration = movie_Duration;
            Movie_Oskar = movie_Oskar;
            Movie_IMDB_Rating = movie_IMDB_Rating;
            Movie_Status = movie_Status;
            Movie_Amount = movie_Amount;
            Movie_Rental_Price = movie_Rental_Price;
            Id_Genre_Genres = id_Genre_Genres;
            Id_Director_Directors = id_Director_Directors;
            Id_Genre = id_Genre;
            Genre_Name = genre_Name;
        }

        public int GetSetId_Movie1 { get => Id_Movie; set => Id_Movie = value; }
        public string GetSetMovie_Name1 { get => Movie_Name; set => Movie_Name = value; }
        public int GetSetMovie_Year1 { get => Movie_Year; set => Movie_Year = value; }
        public double GetSetMovie_Duration1 { get => Movie_Duration; set => Movie_Duration = value; }
        public bool GetSetMovie_Oskar1 { get => Movie_Oskar; set => Movie_Oskar = value; }
        public double GetSetMovie_IMDB_Rating1 { get => Movie_IMDB_Rating; set => Movie_IMDB_Rating = value; }
        public string GetSetMovie_Status1 { get => Movie_Status; set => Movie_Status = value; }
        public int GetSetMovie_Amount1 { get => Movie_Amount; set => Movie_Amount = value; }
        public double GetSetMovie_Rental_Price1 { get => Movie_Rental_Price; set => Movie_Rental_Price = value; }
        public int GetSetId_Genre_Genres1 { get => Id_Genre_Genres; set => Id_Genre_Genres = value; }
        public int GetSetId_Director_Directors1 { get => Id_Director_Directors; set => Id_Director_Directors = value; }
        public int GetSetId_Genre1 { get => Id_Genre; set => Id_Genre = value; }
        public string GetSetGenre_Name1 { get => Genre_Name; set => Genre_Name = value; }
    }
}
