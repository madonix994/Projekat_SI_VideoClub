using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieRepository
    {
        //KREIRANJE UPITA ZA UNOS FILMA U BAZU!

        public int InsertMovie(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO Movies VALUES('" + m.GetSetMovie_Name1 + "', '" + m.GetSetMovie_Year1 + "', '" + m.GetSetMovie_Duration1 + "', '" + m.GetSetMovie_Oskar1 + "', '" + m.GetSetMovie_IMDB_Rating1 + "', '" + m.GetSetMovie_Status1 + "', '" + m.GetSetMovie_Amount1 + "', '" + m.GetSetMovie_Rental_Price1 + "', '" + m.GetSetId_Genre_Genres1 + "', '" + m.GetSetId_Director_Directors1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();
        }

        //KREIRANJE UPITA ZA ISPIS FILMOVA TREBA PRILIKOM UNOSA FILMA!!!

        public List<Movie_Genre_Director> SelectAllMovies()
        {
            List<Movie_Genre_Director> lista = new List<Movie_Genre_Director>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT Movies.Id_Movie, Movies.Movie_Name, Movies.Movie_Year, Movies.Movie_Duration, Movies.Movie_Status, Movies.Movie_Amount, Movies.Movie_Rental_Price, Genres.Genre_Name, Directors.Director_Name, Directors.Director_Surname, Directors.Id_Director FROM Movies JOIN Genres ON Movies.Id_Genre_Genres = Genres.Id_Genre JOIN Directors ON Movies.Id_Director_Directors = Directors.Id_Director";
            
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Movie_Genre_Director m = new Movie_Genre_Director();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                m.GetSetId_Movie1 = dataReader.GetInt32(0);
                m.GetSetMovie_Name1 = dataReader.GetString(1);
                m.GetSetMovie_Year1 = dataReader.GetInt32(2);
                m.GetSetMovie_Duration1 = dataReader.GetDouble(3);
                m.GetSetMovie_Status1 = dataReader.GetString(4);
                m.GetSetMovie_Amount1 = dataReader.GetInt32(5);
                m.GetSetMovie_Rental_Price1 = dataReader.GetDouble(6);
                m.GetSetGenre_Name1 = dataReader.GetString(7);
                m.GetSetDirector_Name1 = dataReader.GetString(8);
                m.GetSetDirector_Surname1 = dataReader.GetString(9);
                m.GetSetId_Director1 = dataReader.GetInt32(10);

                lista.Add(m);
            }

            dataConnection.Close();
            return lista;
        }

        //METODA KOJU KORISTIMO ZA PRETRAGU i ZA ISPIS
        public List<Movie_Genre_Director_MovieRole_Actor> SearchByAll()
        {
            List<Movie_Genre_Director_MovieRole_Actor> lista = new List<Movie_Genre_Director_MovieRole_Actor>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT Movies.Id_Movie, Movies.Movie_Name, Movies.Movie_Year, Movies.Movie_Duration, Movies.Movie_Status, Movies.Movie_Amount, Movies.Movie_Rental_Price, Movies.Movie_IMDB_Rating, Movies.Movie_Oskar, Movies.Id_Director_Directors, Movies.Id_Genre_Genres, Genres.Genre_Name, Directors.Director_Name, Directors.Director_Surname, MovieRoles.Role_Name, Actors.Actor_Name, Actors.Actor_Surname FROM Movies JOIN Genres ON Movies.Id_Genre_Genres = Genres.Id_Genre JOIN Directors ON Movies.Id_Director_Directors = Directors.Id_Director  JOIN MovieRoles ON Movies.Id_Movie = MovieRoles.Id_Movie_Movies JOIN Actors ON Actors.Id_Actor = MovieRoles.Id_Actor_Actors";
            
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Movie_Genre_Director_MovieRole_Actor m = new Movie_Genre_Director_MovieRole_Actor();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                m.GetSetId_Movie1 = dataReader.GetInt32(0);
                m.GetSetMovie_Name1 = dataReader.GetString(1);
                m.GetSetMovie_Year1 = dataReader.GetInt32(2);
                m.GetSetMovie_Duration1 = dataReader.GetDouble(3);
                m.GetSetMovie_Status1 = dataReader.GetString(4);
                m.GetSetMovie_Amount1 = dataReader.GetInt32(5);
                m.GetSetMovie_Rental_Price1 = dataReader.GetDouble(6);
                m.GetSetMovie_IMDB_Rating1 = dataReader.GetDouble(7);
                m.GetSetMovie_Oskar1 = dataReader.GetBoolean(8);
                m.GetSetId_Director_Directors1 = dataReader.GetInt32(9);
                m.GetSetId_Genre_Genres1 = dataReader.GetInt32(10);
                m.GetSetGenre_Name1 = dataReader.GetString(11);
                m.GetSetDirector_Name1 = dataReader.GetString(12);
                m.GetSetDirector_Surname1 = dataReader.GetString(13);
                m.GetSetRole_Name1 = dataReader.GetString(14);
                m.GetSetActor_Name1 = dataReader.GetString(15);
                m.GetSetActor_Surname1 = dataReader.GetString(16);

                lista.Add(m);
            }

            dataConnection.Close();
            return lista;
        }

        // KREIRANJE METODE ZA UPDATE FILMA U BAZI
        public int UpdateMovie(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Movies SET Movie_Name = '" + m.GetSetMovie_Name1 + "', Movie_Year = '" + m.GetSetMovie_Year1 + "', Movie_Duration = '" + m.GetSetMovie_Duration1 + "', Movie_Oskar = '" + m.GetSetMovie_Oskar1 + "', [Movie_IMDB_Rating] = '" + m.GetSetMovie_IMDB_Rating1 + "', Movie_Status = '" + m.GetSetMovie_Status1 + "', Movie_Amount = '" + m.GetSetMovie_Amount1 + "', Movie_Rental_Price = '" + m.GetSetMovie_Rental_Price1 + "', Id_Genre_Genres = '" + m.GetSetId_Genre_Genres1 + "', Id_Director_Directors = '" + m.GetSetId_Director_Directors1 + "' WHERE Id_Movie = '" + m.GetSetId_Movie1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();

        }

        // KREIRANJE METODE ZA BRISANJE FILMA IZ BAZE
        public int DeleteMovie(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM Movies WHERE Movies.Id_Movie = '" + m.GetSetId_Movie1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();
        }

        /*POMOCNA METODA ZA TABELU ZANROVI --> KREIRANJE METODE ZA UPDATE GDE VRSIMO AZURIRANJE MOVIE TABELE ODNOSNO SETUJEMO ZANR ZA ODREDJENI FILM
          NA "Nije Uneto" U OKVIRU MOVIE TABELE NAKON BRISANJA TOG ZANRA IZ TABELE ZANROVI
         (potrebno radi lancane reakcije nesto kao triger)    */
        public int UpdateGenreOnMovie(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Movies SET Id_Genre_Genres = '" + Convert.ToInt32("1004") + "' WHERE Id_Genre_Genres = '" + m.GetSetId_Genre_Genres1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();
        }

        /* POMOCNA METODA ZA TABELU ZANROVI --> KREIRANJE UPITA ZA UPDATE REZISERA
           ODREDJENOG FILMA NAKON BRISANJA TOG ODREDJENOG REZISERA */
        public int UpdateDirectorOnMovie(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Movies SET Id_Director_Directors = '" + Convert.ToInt32("1004") + "' WHERE Id_Director_Directors = '" + m.GetSetId_Director_Directors1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();

        }



        //SELECT SVIH IMENA I ID-a FILMOVA ZA POPUNJAVANJE COMBOBOX-a ZA FILMOVE!
        public List<Movie> SelectAllMoviesIdAndName()
        {
            List<Movie> lista = new List<Movie>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT Id_Movie, Movie_Name FROM Movies";


            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Movie m = new Movie();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                m.GetSetId_Movie1 = dataReader.GetInt32(0);
                m.GetSetMovie_Name1 = dataReader.GetString(1);

                lista.Add(m);
            }

            dataConnection.Close();
            return lista;
        }


    }
}
