using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class RentalStorageRepository : IRentalStorageRepository
    {

        //KREIRANJE UPITA ZA UNOS PODATAKA O REZERVACIJI U BAZU!

        public int InsertRentalStorage(RentalStorage rs)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "INSERT INTO RentalStorage VALUES('" + rs.GetSetMovie_Name1 + "', '" + rs.GetSetTotal_Price1 + "', '" + rs.GetSetRental_Date_Of_Take1 + "', '" + rs.GetSetRental_Date_Of_Return1 + "', '" + rs.GetSetUserCard_Name1 + "', '" + rs.GetSetUserCard_Surname1 + "', '" + rs.GetSetUserCard_Address1 + "', '" + rs.GetSetUserCard_Phone_Number1 + "')"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();
        }

        //METODA KOJU KORISTIMO ZA PRETRAGU i ZA ISPIS
        public List<RentalStorage> SelectAllRentalStorages()
        {
            List<RentalStorage> listRentalStorages = new List<RentalStorage>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT UserCard_Name, UserCard_Surname, COUNT(Movie_Name), SUM(Total_Price), Rental_Date_Of_Take, UserCard_Address, UserCard_Phone_Number FROM RentalStorage GROUP BY UserCard_Name, UserCard_Surname, Rental_Date_Of_Take, UserCard_Address, UserCard_Phone_Number ORDER BY Rental_Date_Of_Take DESC";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                RentalStorage rs = new RentalStorage();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)

                rs.GetSetUserCard_Name1 = dataReader.GetString(0);
                rs.GetSetUserCard_Surname1 = dataReader.GetString(1);
                rs.GetSetMovie_Name1 = Convert.ToString(dataReader.GetInt32(2));
                rs.GetSetTotal_Price1 = dataReader.GetDouble(3);
                rs.GetSetRental_Date_Of_Take1 = dataReader.GetDateTime(4);
                rs.GetSetUserCard_Address1 = dataReader.GetString(5);
                rs.GetSetUserCard_Phone_Number1 = dataReader.GetInt32(6);

                listRentalStorages.Add(rs);
            }

            dataConnection.Close();
            return listRentalStorages;
        }


        public List<RentalStorage> SelectAllRentalDetails()
        {
            List<RentalStorage> listRentalStorages = new List<RentalStorage>();

            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "SELECT * FROM RentalStorage";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                RentalStorage rs = new RentalStorage();
                // za svaki red se uzima vrednost određene kolone (0 - prva kolona)

                rs.GetSetId_Rental_Storage1 = dataReader.GetInt32(0);
                rs.GetSetMovie_Name1 = dataReader.GetString(1);
                rs.GetSetTotal_Price1 = dataReader.GetDouble(2);
                rs.GetSetRental_Date_Of_Take1 = dataReader.GetDateTime(3);
                rs.GetSetRental_Date_Of_Return1 = dataReader.GetString(4);
                rs.GetSetUserCard_Name1 = dataReader.GetString(5);
                rs.GetSetUserCard_Surname1 = dataReader.GetString(6);
                rs.GetSetUserCard_Address1 = dataReader.GetString(7);
                rs.GetSetUserCard_Phone_Number1 = dataReader.GetInt32(8);

                listRentalStorages.Add(rs);
            }

            dataConnection.Close();
            return listRentalStorages;
        }

        // KREIRANJE METODE ZA UPDATE DATUMA VRACANJA U BAZI
        public int UpdateRentalStorageDateOfReturn(RentalStorage rse)
        {
            SqlConnection dataConnection = new SqlConnection();

            dataConnection.ConnectionString = GlobalVariables.connString;
            dataConnection.Open();

            SqlCommand command = new SqlCommand(); // kreiranje komande
            command.Connection = dataConnection; //setovanje konekcije komande
            command.CommandText = "UPDATE RentalStorage SET Rental_Date_Of_Return = '" + rse.GetSetRental_Date_Of_Return1 + "' WHERE Movie_Name = '" + rse.GetSetMovie_Name1+"'"; // setovanje SQL upita koji će se izvršiti nad bazom podataka

            return command.ExecuteNonQuery();

        }
        
    }
}
