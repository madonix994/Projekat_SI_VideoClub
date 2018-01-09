using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessMovieRental
    {
        //POVEZIVANJE SA DATA LAYER-OM
        public MovieRentalRepository movieRentalRepository = new MovieRentalRepository();

        //LOGICKA PROVERA UNOSA U BAZU
        public bool InsertMovieRental(MovieRental movieRental)
        {
            if (movieRentalRepository.InsertMovieRental(movieRental) > 0)
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
