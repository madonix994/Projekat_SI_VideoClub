using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class GenreRepository
    {
        //KREIRANJE UPITA ZA UNOS ZANRA U BAZU!

        public int InsertGenre(Genre g)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO Genres VALUES('" + g.GetSetGenre_Name1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }

        //KREIRANJE UPITA ZA ISPIS SVIH ZANROVA!!!

        public List<Genre> SelectAllGenres()
        {
            List<Genre> lista = new List<Genre>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM Genres";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Genre g = new Genre();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                g.GetSetId_Genre1 = dataReader.GetInt32(0);
                g.GetSetGenre_Name1 = dataReader.GetString(1);

                lista.Add(g); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return lista;
        }

        //METODA ZA AZURIRANJE ZANRA U BAZI

        public int UpdateGenre(Genre g)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Genres SET Genre_Name = '" + g.GetSetGenre_Name1 + "' WHERE Id_Genre = '" + g.GetSetId_Genre1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();

        }

        // METODA ZA BRISANJE ZANRA IZ BAZE
        public int DeleteGenre(Genre g)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM Genres WHERE Id_Genre = '" + g.GetSetId_Genre1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();
        }

    }
}
