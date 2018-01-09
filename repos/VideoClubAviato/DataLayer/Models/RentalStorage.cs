using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class RentalStorage
    {
        private int Id_Rental_Storage, UserCard_Phone_Number;
        private string Movie_Name, UserCard_Name, UserCard_Surname, UserCard_Address, Rental_Date_Of_Return;
        private double Total_Price;
        private DateTime Rental_Date_Of_Take;

        public RentalStorage(int id_Rental_Storage, int userCard_Phone_Number, string movie_Name, string userCard_Name, string userCard_Surname, string userCard_Address, double total_Price, DateTime rental_Date_Of_Take, string rental_Date_Of_Return)
        {
            Id_Rental_Storage = id_Rental_Storage;
            UserCard_Phone_Number = userCard_Phone_Number;
            Movie_Name = movie_Name;
            UserCard_Name = userCard_Name;
            UserCard_Surname = userCard_Surname;
            UserCard_Address = userCard_Address;
            Total_Price = total_Price;
            Rental_Date_Of_Take = rental_Date_Of_Take;
            Rental_Date_Of_Return = rental_Date_Of_Return;
        }

        public RentalStorage() { }

        public int GetSetId_Rental_Storage1 { get => Id_Rental_Storage; set => Id_Rental_Storage = value; }
        public int GetSetUserCard_Phone_Number1 { get => UserCard_Phone_Number; set => UserCard_Phone_Number = value; }
        public string GetSetMovie_Name1 { get => Movie_Name; set => Movie_Name = value; }
        public string GetSetUserCard_Name1 { get => UserCard_Name; set => UserCard_Name = value; }
        public string GetSetUserCard_Surname1 { get => UserCard_Surname; set => UserCard_Surname = value; }
        public string GetSetUserCard_Address1 { get => UserCard_Address; set => UserCard_Address = value; }
        public double GetSetTotal_Price1 { get => Total_Price; set => Total_Price = value; }
        public DateTime GetSetRental_Date_Of_Take1 { get => Rental_Date_Of_Take; set => Rental_Date_Of_Take = value; }
        public string GetSetRental_Date_Of_Return1 { get => Rental_Date_Of_Return; set => Rental_Date_Of_Return = value; }
    }
}
