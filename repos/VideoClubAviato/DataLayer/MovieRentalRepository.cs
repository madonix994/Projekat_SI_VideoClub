using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MovieRentalRepository
    {

        //KREIRANJE UPITA ZA UNOS U TABELU KOJA NAM OMOGUCAVA VISE FILMOVA NA JEDNOM RACUNU U BAZU!

        public int InsertMovieRental(MovieRental movieRental)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO MovieRentals VALUES('" + movieRental.Id_Movie_Movies1 + "', '" + movieRental.Id_Rental_Rentals1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }
    }
}
