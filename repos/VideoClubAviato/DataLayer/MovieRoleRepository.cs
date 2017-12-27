using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieRoleRepository
    {

        /* POMOCNA METODA ZA TABELU FILMOVI --> KREIRANJE METODE ZA UNOS NOVE ULOGE SA NAZIVOM "Nije Uneto"  
         i OPISOM "Nije Uneto" GDE SETUJEMO I GLUMCA NA "Nije Uneto", POTREBNA PRILIKOM UNOSA NOVOG FILMA
         KAKO BI FILM KOJI SE UNOSI DOBIO U ISPISU ULOGU I GLUMCA "Nije Uneto" I GDE MOZEMO KASNIJE AZURIRATI TAJ FILM
        PORED OVOGA, OVA METODA TAKODJE SLUZI I ZA NORMALAN INSERT U BAZU! 
        */
        public int InsertMovieRole(MovieRole mr)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO MovieRoles VALUES('" + mr.GetSetRole_Name1 + "', '" + mr.GetSetRole_Description1 + "', '" + mr.GetSetId_Actor_Actors1 + "', '" + mr.GetSetId_Movie_Movies1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();
        }


        //KREIRANJE UPITA ZA ISPIS ULOGA!!!
        public List<MovieRole_Actor_Movie> SelectAllMovieRoles()
        {
            List<MovieRole_Actor_Movie> lista = new List<MovieRole_Actor_Movie>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT MovieRoles.Id_Role, MovieRoles.Role_Name, Actors.Actor_Name, Actors.Actor_Surname, Movies.Movie_Name, Movies.Movie_Year, Movies.[Movie_IMDB_Rating], Movies.Movie_Duration, MovieRoles.Role_Description, MovieRoles.Id_Movie_Movies, MovieRoles.Id_Actor_Actors FROM MovieRoles JOIN Actors ON MovieRoles.Id_Actor_Actors = Actors.Id_Actor JOIN Movies ON MovieRoles.Id_Movie_Movies = Movies.Id_Movie";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                MovieRole_Actor_Movie mr = new MovieRole_Actor_Movie();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                mr.GetSetId_Role1 = dataReader.GetInt32(0);
                mr.GetSetRole_Name1 = dataReader.GetString(1);
                mr.GetSetActor_Name1 = dataReader.GetString(2);
                mr.GetSetActor_Surname1 = dataReader.GetString(3);
                mr.GetSetMovie_Name1 = dataReader.GetString(4);
                mr.GetSetMovie_Year1 = dataReader.GetInt32(5);
                mr.GetSetMovie_IMDB_Rating1 = dataReader.GetDouble(6);
                mr.GetSetMovie_Duration1 = dataReader.GetDouble(7);
                mr.GetSetRole_Description1 = dataReader.GetString(8);
                mr.GetSetId_Movie_Movies1 = dataReader.GetInt32(9);
                mr.GetSetId_Actor_Actors1 = dataReader.GetInt32(10);

                lista.Add(mr);
            }

            dataConnection.Close();
            return lista;
        }

        // KREIRANJE METODE ZA UPDATE ULOGE
        public int UpdateMovieRole(MovieRole mr)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE MovieRoles SET Role_Name = '" + mr.GetSetRole_Name1 + "', Role_Description = '" + mr.GetSetRole_Description1 + "', Id_Actor_Actors = '" + mr.GetSetId_Actor_Actors1 + "', Id_Movie_Movies = '" + mr.GetSetId_Movie_Movies1 + "' WHERE Id_Role = '" + mr.GetSetId_Role1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();

        }

        // KREIRANJE METODE ZA BRISANJE ULOGE
        public int DeleteMovieRole(MovieRole mr)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM MovieRoles WHERE MovieRoles.Id_Role = '" + mr.GetSetId_Role1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();
        }


        /*POMOCNA METODA ZA TABELU GLMCI --> VRSIMO AZURIRANJE TABELE MOVIE ROLE GDE SETUJEMO IME I OPIS ULOGE NA "Nije Uneto" A NAJVAZNIJE
        SETUJEMO ID GLUMCA KOJI JE POVEZAN SA TOM ULOGOM NA GLUMCA"Nije Uneto" KOJI SE NALAZI U BAZI.
        KORISTI SE PRILIKOM BRISANJA GLUMCA IZ TABELE GLUMCI
        (potrebno radi lancane reakcije nesto kao triger)*/
        public int UpdateActorOnMovieRole(MovieRole mr)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE MovieRoles SET Role_Name = 'Nije Uneto', Role_Description = 'Nije Uneto', Id_Actor_Actors = '" + Convert.ToInt32("2003") + "' WHERE Id_Actor_Actors = '" + mr.GetSetId_Actor_Actors1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();

        }

        /* POMOCNA METODA ZA TABELU FILMOVI --> KREIRANJE METODE ZA BRISANJE ULOGE POTREBNA ZBOG FK, 
        GDE BRISEMO ULOGU KOJA JE POVEZANA SA TIM ODREDJENIM FILMOM KOJEG BRISEMO IZ TABELE FILMOVI  */
        public int DeleteMovieRoleOnMovies(Movie m)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM MovieRoles WHERE MovieRoles.Id_Movie_Movies = '" + m.GetSetId_Movie1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();
        }
    }
}
