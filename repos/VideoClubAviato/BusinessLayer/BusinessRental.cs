using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessRental
    {

        //POVEZIVANJE SA DATA LAYER-OM
        private IRentalRepository rentalRepository;

        public BusinessRental(IRentalRepository rentalRepository)
        {
            this.rentalRepository = rentalRepository;
        }


        //LOGICKA PROVERA UNOSA U BAZU
        public bool InsertRental(Rental r)
        {
            if (rentalRepository.InsertRental(r) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metoda za ispis svih REZERVACIJA
        public List<Rental> SelectAllRentals()
        {
            return rentalRepository.SelectAllRentals();
        }

    }
}
