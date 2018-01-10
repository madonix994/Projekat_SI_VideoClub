using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserCardRepository : IUserCardRepository
    {

        //KREIRANJE UPITA ZA UNOS KORISNIKA U BAZU!
        public int InsertUser(UserCard u)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO UserCards VALUES('" + u.GetSetUserCard_Name_Of_User1 + "', '" + u.GetSetUserCard_Surname_Of_User1 + "', '" + u.GetSetUserCard_Address_Of_User1 + "', '" + u.GetSetUserCard_PhoneNumber_Of_User1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }


        //KREIRANJE UPITA ZA ISPIS SVIH KORISNIKA!!!
        public List<UserCard> SelectAllUsers()
        {
            List<UserCard> lista = new List<UserCard>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM UserCards";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                UserCard u = new UserCard();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                u.GetSetId_UserCard1 = dataReader.GetInt32(0);
                u.GetSetUserCard_Name_Of_User1 = dataReader.GetString(1);
                u.GetSetUserCard_Surname_Of_User1 = dataReader.GetString(2);
                u.GetSetUserCard_Address_Of_User1 = dataReader.GetString(3);
                u.GetSetUserCard_PhoneNumber_Of_User1 = dataReader.GetInt32(4);

                lista.Add(u); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return lista;
        }


        // KREIRANJE METODE ZA UPDATE
        public int UpdateUserCard(UserCard u)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE UserCards SET UserCard_Name_Of_User = '" + u.GetSetUserCard_Name_Of_User1 + "', UserCard_Surname_Of_User = '" + u.GetSetUserCard_Surname_Of_User1 + "', UserCard_Address_Of_User = '" + u.GetSetUserCard_Address_Of_User1 + "', UserCard_PhoneNumber_Of_User = '" + u.GetSetUserCard_PhoneNumber_Of_User1 + "' WHERE Id_UserCard = '" + u.GetSetId_UserCard1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka


            return command.ExecuteNonQuery();

        }


        // KREIRANJE METODE ZA BRISANJE KORISNIKA
        public int DeleteUserCard(UserCard u)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "DELETE FROM UserCards WHERE Id_UserCard = '" + u.GetSetId_UserCard1 + "'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka
            
            return command.ExecuteNonQuery();
        }
        
    }
}
