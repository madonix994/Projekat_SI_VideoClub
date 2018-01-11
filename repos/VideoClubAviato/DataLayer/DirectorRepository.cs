using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DirectorRepository : IDirectorRepository
    {

        //KREIRANJE UPITA ZA UNOS REZISERA U BAZU!
        public int InsertDirector(Director d)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO Directors VALUES('" + d.GetSetDirector_Name1 + "', '" + d.GetSetDirector_Surname1 + "', '" + d.GetSetDirector_Date_Of_Birth1 + "', '" + d.GetSetDirector_Oscar1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }


        //KREIRANJE UPITA ZA ISPIS REZISERA!!!
        public List<Director> SelectAllDirectors()
        {
            List<Director> listDirectors = new List<Director>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM Directors";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Director d = new Director();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                d.GetSetId_Director1 = dataReader.GetInt32(0);
                d.GetSetDirector_Name1 = dataReader.GetString(1);
                d.GetSetDirector_Surname1 = dataReader.GetString(2);
                d.GetSetDirector_Date_Of_Birth1 = dataReader.GetDateTime(3);
                d.GetSetDirector_Oscar1 = dataReader.GetBoolean(4);

                listDirectors.Add(d); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return listDirectors;
        }


        //UPDATE METODA ZA AZURIRANJE REZISERA
        public int UpdateDirector(Director d)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Directors SET Director_Name = '" + d.GetSetDirector_Name1 + "', Director_Surname = '" + d.GetSetDirector_Surname1 + "', Director_Date_Of_Birth = '" + d.GetSetDirector_Date_Of_Birth1 + "', Director_Oscar = '" + d.GetSetDirector_Oscar1 + "' WHERE Id_Director = '" + d.GetSetId_Director1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();

        }


        // KREIRANJE METODE ZA BRISANJE REZISERA
        public int DeleteDirector(Director d)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM Directors WHERE Directors.Id_Director = '" + d.GetSetId_Director1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();
        }
        
    }
}
