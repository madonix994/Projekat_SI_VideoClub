using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class MovieRole
    {
        private int Id_Role;
        private string Role_Name;
        private string Role_Description;
        private int Id_Actor_Actors;
        private int Id_Movie_Movies;

        public MovieRole() { }

        public MovieRole(int id_Role, string role_Name, string role_Description, int id_Actor_Actors, int id_Movie_Movies)
        {
            Id_Role = id_Role;
            Role_Name = role_Name;
            Role_Description = role_Description;
            Id_Actor_Actors = id_Actor_Actors;
            Id_Movie_Movies = id_Movie_Movies;
        }

        public int GetSetId_Role1 { get => Id_Role; set => Id_Role = value; }
        public string GetSetRole_Name1 { get => Role_Name; set => Role_Name = value; }
        public string GetSetRole_Description1 { get => Role_Description; set => Role_Description = value; }
        public int GetSetId_Actor_Actors1 { get => Id_Actor_Actors; set => Id_Actor_Actors = value; }
        public int GetSetId_Movie_Movies1 { get => Id_Movie_Movies; set => Id_Movie_Movies = value; }
    }
}
