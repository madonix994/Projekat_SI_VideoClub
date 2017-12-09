using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Director
    {
        private int Id_Director;
        private string Director_Name;
        private string Director_Surname;
        private DateTime Director_Date_Of_Birth;
        private bool Director_Oscar;

        public Director() { }

        public Director(int id_Director, string director_Name, string director_Surname, DateTime director_Date_Of_Birth, bool director_Oscar)
        {
            Id_Director = id_Director;
            Director_Name = director_Name;
            Director_Surname = director_Surname;
            Director_Date_Of_Birth = director_Date_Of_Birth;
            Director_Oscar = director_Oscar;
        }

        public int GetSetId_Director1 { get => Id_Director; set => Id_Director = value; }
        public string GetSetDirector_Name1 { get => Director_Name; set => Director_Name = value; }
        public string GetSetDirector_Surname1 { get => Director_Surname; set => Director_Surname = value; }
        public DateTime GetSetDirector_Date_Of_Birth1 { get => Director_Date_Of_Birth; set => Director_Date_Of_Birth = value; }
        public bool GetSetDirector_Oscar1 { get => Director_Oscar; set => Director_Oscar = value; }

    }
}
