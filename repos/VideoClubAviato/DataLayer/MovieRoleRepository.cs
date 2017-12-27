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

        /* POMOCNA METODA ZA TABELU FILMOVI --> KREIRANJE METODE ZA UNOS NOVE ULOGE SA NAZIVOM "Nije Uneto"  
         i OPISOM "Nije Uneto" GDE SETUJEMO I GLUMCA NA "Nije Uneto", POTREBNA PRILIKOM UNOSA NOVOG FILMA
         KAKO BI FILM KOJI SE UNOSI DOBIO U ISPISU ULOGU I GLUMCA "Nije Uneto" I GDE MOZEMO KASNIJE AZURIRATI TAJ FILM*/
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

    }
}
