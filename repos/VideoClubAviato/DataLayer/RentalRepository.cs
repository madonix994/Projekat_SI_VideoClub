using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RentalRepository : IRentalRepository
    {

        //KREIRANJE UPITA ZA UNOS REZERVACIJE U BAZU!

        public int InsertRental(Rental r)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO Rentals VALUES('" + r.GetSetRental_Date_Of_Take1 + "', '" + r.GetSetId_UserCard_UserCards1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }

        //KREIRANJE UPITA ZA ISPIS SVIH KORISNIKA!!!
        public List<Rental> SelectAllRentals()
        {
            List<Rental> lista = new List<Rental>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT Id_Rental, Id_UserCard_UserCards FROM Rentals";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Rental rental = new Rental();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)
                rental.GetSetId_Rental1 = dataReader.GetInt32(0);
                rental.GetSetId_UserCard_UserCards1 = dataReader.GetInt32(1);

                lista.Add(rental); // svaki student se na kraju može ubaciti u neku listu
            }

            dataConnection.Close();
            return lista;
        }
    }
}
