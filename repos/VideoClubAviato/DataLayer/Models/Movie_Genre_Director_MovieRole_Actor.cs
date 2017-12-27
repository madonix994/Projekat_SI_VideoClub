using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Movie_Genre_Director_MovieRole_Actor
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

        //TABELA DIRECTOR

        private int Id_Director;
        private string Director_Name;
        private string Director_Surname;
        private DateTime Director_Date_Of_Birth;
        private bool Director_Oscar;

        //Klasa Movie_Role

        private int Id_Role;
        private string Role_Name;
        private string Role_Description;
        private int Id_Actor_Actors;
        private int Id_Movie_Movies;


        //Klasa Actor

        private int Id_Actor;
        private string Actor_Name;
        private string Actor_Surname;
        private DateTime Actor_Date_Of_Birth;
        private bool Actor_Oscar;

        public Movie_Genre_Director_MovieRole_Actor() { }

        public Movie_Genre_Director_MovieRole_Actor(int id_Movie, string movie_Name, int movie_Year, double movie_Duration, bool movie_Oskar, double movie_IMDB_Rating, string movie_Status, int movie_Amount, double movie_Rental_Price, int id_Genre_Genres, int id_Director_Directors, int id_Genre, string genre_Name, int id_Director, string director_Name, string director_Surname, DateTime director_Date_Of_Birth, bool director_Oscar, int id_Role, string role_Name, string role_Description, int id_Actor_Actors, int id_Movie_Movies, int id_Actor, string actor_Name, string actor_Surname, DateTime actor_Date_Of_Birth, bool actor_Oscar)
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
            Id_Director = id_Director;
            Director_Name = director_Name;
            Director_Surname = director_Surname;
            Director_Date_Of_Birth = director_Date_Of_Birth;
            Director_Oscar = director_Oscar;
            Id_Role = id_Role;
            Role_Name = role_Name;
            Role_Description = role_Description;
            Id_Actor_Actors = id_Actor_Actors;
            Id_Movie_Movies = id_Movie_Movies;
            Id_Actor = id_Actor;
            Actor_Name = actor_Name;
            Actor_Surname = actor_Surname;
            Actor_Date_Of_Birth = actor_Date_Of_Birth;
            Actor_Oscar = actor_Oscar;
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
        public int GetSetId_Director1 { get => Id_Director; set => Id_Director = value; }
        public string GetSetDirector_Name1 { get => Director_Name; set => Director_Name = value; }
        public string GetSetDirector_Surname1 { get => Director_Surname; set => Director_Surname = value; }
        public DateTime GetSetDirector_Date_Of_Birth1 { get => Director_Date_Of_Birth; set => Director_Date_Of_Birth = value; }
        public bool GetSetDirector_Oscar1 { get => Director_Oscar; set => Director_Oscar = value; }
        public int GetSetId_Role1 { get => Id_Role; set => Id_Role = value; }
        public string GetSetRole_Name1 { get => Role_Name; set => Role_Name = value; }
        public string GetSetRole_Description1 { get => Role_Description; set => Role_Description = value; }
        public int GetSetId_Actor_Actors1 { get => Id_Actor_Actors; set => Id_Actor_Actors = value; }
        public int GetSetId_Movie_Movies1 { get => Id_Movie_Movies; set => Id_Movie_Movies = value; }
        public int GetSetId_Actor1 { get => Id_Actor; set => Id_Actor = value; }
        public string GetSetActor_Name1 { get => Actor_Name; set => Actor_Name = value; }
        public string GetSetActor_Surname1 { get => Actor_Surname; set => Actor_Surname = value; }
        public DateTime GetSetActor_Date_Of_Birth1 { get => Actor_Date_Of_Birth; set => Actor_Date_Of_Birth = value; }
        public bool GetSetActor_Oscar1 { get => Actor_Oscar; set => Actor_Oscar = value; }
    }
}
