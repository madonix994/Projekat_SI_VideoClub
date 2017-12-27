using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessUserCard
    {
        // POVEZIVANJE SA DATA LAYER-OM
        public UserCardRepository userCardRepository = new UserCardRepository();

        //LOGICKA PROVERA ZA UNOS GLUMCA
        public bool InsertUser(UserCard u)
        {
            if (userCardRepository.InsertUser(u) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metoda za ispis svih Korisnika
        public List<UserCard> SelectAllUsers()
        {
            return userCardRepository.SelectAllUsers();
        }

        //LOGICKA PROVERA ZA PRETRAGU KORISNIKA
        public List<UserCard> SearchUserCard(string UserCardPom)
        {
            return userCardRepository.SelectAllUsers().Where(
            u => u.GetSetUserCard_Name_Of_User1.Contains(UserCardPom) ||
            u.GetSetUserCard_Name_Of_User1.ToLower().Contains(UserCardPom) ||
            u.GetSetUserCard_Name_Of_User1.ToUpper().Contains(UserCardPom) ||
            u.GetSetUserCard_Name_Of_User1.StartsWith(UserCardPom) ||
            u.GetSetUserCard_Surname_Of_User1.Contains(UserCardPom) ||
            u.GetSetUserCard_Surname_Of_User1.ToLower().Contains(UserCardPom) ||
            u.GetSetUserCard_Surname_Of_User1.ToUpper().Contains(UserCardPom) ||
            u.GetSetUserCard_Surname_Of_User1.StartsWith(UserCardPom) ||
            u.GetSetUserCard_Address_Of_User1.Contains(UserCardPom) ||
            u.GetSetUserCard_Address_Of_User1.ToLower().Contains(UserCardPom) ||
            u.GetSetUserCard_Address_Of_User1.ToUpper().Contains(UserCardPom) ||
            u.GetSetUserCard_Address_Of_User1.StartsWith(UserCardPom) ||
            (u.GetSetUserCard_Name_Of_User1 + " " + u.GetSetUserCard_Surname_Of_User1).Contains(UserCardPom) ||
            (u.GetSetUserCard_Name_Of_User1 + " " + u.GetSetUserCard_Surname_Of_User1).ToLower().Contains(UserCardPom) ||
            (u.GetSetUserCard_Name_Of_User1 + " " + u.GetSetUserCard_Surname_Of_User1).ToUpper().Contains(UserCardPom)).ToList();
        }

        //LOGICKA PROVERA ZA AZURIRANJE KORISNIKA
        public bool UpdateUserCard(UserCard u)
        {
            if (userCardRepository.UpdateUserCard(u) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA BRISANJE KORISNIKA
        public bool DeleteUserCard(UserCard u)
        {
            if (userCardRepository.DeleteUserCard(u) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
