using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUserCardRepository
    {

        int InsertUser(UserCard u);
        List<UserCard> SelectAllUsers();
        int UpdateUserCard(UserCard u);
        int DeleteUserCard(UserCard u);


    }
}
