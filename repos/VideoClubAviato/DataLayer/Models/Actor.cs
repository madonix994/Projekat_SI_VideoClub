using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Actor
    {
        private int Id_Actor;
        private string Actor_Name;
        private string Actor_Surname;
        private DateTime Actor_Date_Of_Birth;
        private bool Actor_Oscar;

        public Actor() { }

        public Actor(int id_Actor, string actor_Name, string actor_Surname, DateTime actor_Date_Of_Birth, bool actor_Oscar)
        {
            Id_Actor = id_Actor;
            Actor_Name = actor_Name;
            Actor_Surname = actor_Surname;
            Actor_Date_Of_Birth = actor_Date_Of_Birth;
            Actor_Oscar = actor_Oscar;
        }

        public int GetSetId_Actor1 { get => Id_Actor; set => Id_Actor = value; }
        public string GetSetActor_Name1 { get => Actor_Name; set => Actor_Name = value; }
        public string GetSetActor_Surname1 { get => Actor_Surname; set => Actor_Surname = value; }
        public DateTime GetSetActor_Date_Of_Birth1 { get => Actor_Date_Of_Birth; set => Actor_Date_Of_Birth = value; }
        public bool GetSetActor_Oscar1 { get => Actor_Oscar; set => Actor_Oscar = value; }
    }
}
