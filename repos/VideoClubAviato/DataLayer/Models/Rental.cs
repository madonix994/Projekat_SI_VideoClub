using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Rental
    {
        private int Id_Rental;
        private DateTime Rental_Date_Of_Take;
        private DateTime Rental_Date_Of_Return;
        private int Id_UserCard_UserCards;

        public Rental() { }

        public Rental(int id_Rental, DateTime rental_Date_Of_Take, DateTime rental_Date_Of_Return, double rental_Total_Cost, int id_UserCard_UserCards)
        {
            Id_Rental = id_Rental;
            Rental_Date_Of_Take = rental_Date_Of_Take;
            Rental_Date_Of_Return = rental_Date_Of_Return;
            Id_UserCard_UserCards = id_UserCard_UserCards;
        }

        public int GetSetId_Rental1 { get => Id_Rental; set => Id_Rental = value; }
        public DateTime GetSetRental_Date_Of_Take1 { get => Rental_Date_Of_Take; set => Rental_Date_Of_Take = value; }
        public DateTime GetSetRental_Date_Of_Return1 { get => Rental_Date_Of_Return; set => Rental_Date_Of_Return = value; }
        public int GetSetId_UserCard_UserCards1 { get => Id_UserCard_UserCards; set => Id_UserCard_UserCards = value; }
    }
}
