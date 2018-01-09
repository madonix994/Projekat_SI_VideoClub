using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class MovieRental
    {

        private int Id_Movie_Rental;
        private int Id_Movie_Movies;
        private int Id_Rental_Rentals;

        public MovieRental(int id_Movie_Rental, int id_Movie_Movies, int id_Rental_Rentals)
        {
            Id_Movie_Rental1 = id_Movie_Rental;
            Id_Movie_Movies1 = id_Movie_Movies;
            Id_Rental_Rentals1 = id_Rental_Rentals;
        }

        public MovieRental() { }

        public int Id_Movie_Rental1 { get => Id_Movie_Rental; set => Id_Movie_Rental = value; }
        public int Id_Movie_Movies1 { get => Id_Movie_Movies; set => Id_Movie_Movies = value; }
        public int Id_Rental_Rentals1 { get => Id_Rental_Rentals; set => Id_Rental_Rentals = value; }
    }
}
