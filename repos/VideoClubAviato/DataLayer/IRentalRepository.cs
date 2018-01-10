using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRentalRepository
    {

        int InsertRental(Rental r);
        List<Rental> SelectAllRentals();


    }
}
