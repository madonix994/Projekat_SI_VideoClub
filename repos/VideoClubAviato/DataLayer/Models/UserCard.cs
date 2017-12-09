using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class UserCard
    {
        private int Id_UserCard;
        private string UserCard_Name_Of_User;
        private string UserCard_Surname_Of_User;
        private string UserCard_Address_Of_User;
        private int UserCard_PhoneNumber_Of_User;

        public UserCard() { }

        public UserCard(int id_UserCard, string userCard_Name_Of_User, string userCard_Surname_Of_User, string userCard_Address_Of_User, int userCard_PhoneNumber_Of_User)
        {
            Id_UserCard = id_UserCard;
            UserCard_Name_Of_User = userCard_Name_Of_User;
            UserCard_Surname_Of_User = userCard_Surname_Of_User;
            UserCard_Address_Of_User = userCard_Address_Of_User;
            UserCard_PhoneNumber_Of_User = userCard_PhoneNumber_Of_User;
        }

        public int GetSetId_UserCard1 { get => Id_UserCard; set => Id_UserCard = value; }
        public string GetSetUserCard_Name_Of_User1 { get => UserCard_Name_Of_User; set => UserCard_Name_Of_User = value; }
        public string GetSetUserCard_Surname_Of_User1 { get => UserCard_Surname_Of_User; set => UserCard_Surname_Of_User = value; }
        public string GetSetUserCard_Address_Of_User1 { get => UserCard_Address_Of_User; set => UserCard_Address_Of_User = value; }
        public int GetSetUserCard_PhoneNumber_Of_User1 { get => UserCard_PhoneNumber_Of_User; set => UserCard_PhoneNumber_Of_User = value; }
    }
}
