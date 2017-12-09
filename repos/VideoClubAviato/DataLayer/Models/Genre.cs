using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class Genre
    {
        private int Id_Genre;
        private string Genre_Name;

        public Genre() { }

        public Genre(int id_Genre, string genre_Name)
        {
            Id_Genre = id_Genre;
            Genre_Name = genre_Name;
        }

        public int GetSetId_Genre1 { get => Id_Genre; set => Id_Genre = value; }
        public string GetSetGenre_Name1 { get => Genre_Name; set => Genre_Name = value; }
    }
}
