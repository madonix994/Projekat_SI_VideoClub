using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ActorRepository : IActorRepository
    {

        //KREIRANJE UPITA ZA UNOS GLUMCA U BAZU!

        public int InsertActor(Actor a)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO Actors VALUES('" + a.GetSetActor_Name1 + "', '" + a.GetSetActor_Surname1 + "', '" + a.GetSetActor_Date_Of_Birth1 + "', '" + a.GetSetActor_Oscar1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }

        //KREIRANJE UPITA ZA ISPIS GLUMACA!!!

        public List<Actor> SelectAllActors()
        {
            List<Actor> lista = new List<Actor>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM Actors";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Actor a = new Actor();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                a.GetSetId_Actor1 = dataReader.GetInt32(0);
                a.GetSetActor_Name1 = dataReader.GetString(1);
                a.GetSetActor_Surname1 = dataReader.GetString(2);
                a.GetSetActor_Date_Of_Birth1 = dataReader.GetDateTime(3);
                a.GetSetActor_Oscar1 = dataReader.GetBoolean(4);

                lista.Add(a); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return lista;
        }

        //UPDATE METODA ZA AZURIRANJE GLUMCA
        public int UpdateActor(Actor a)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE Actors SET Actor_Name = '" + a.GetSetActor_Name1 + "', Actor_Surname = '" + a.GetSetActor_Surname1 + "', Actor_Date_Of_Birth = '" + a.GetSetActor_Date_Of_Birth1 + "', Actor_Oscar = '" + a.GetSetActor_Oscar1 + "' WHERE Id_Actor = '" + a.GetSetId_Actor1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
            dataConnection.Close();
        }

        //DELETE METODA ZA BRISANJE GLUMCA
        public int DeleteActor(Actor a)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM Actors WHERE Actors.Id_Actor = '" + a.GetSetId_Actor1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();
        }

    }
}
