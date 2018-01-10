using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRentalStorageRepository
    {
        int InsertRentalStorage(RentalStorage rs);
        List<RentalStorage> SelectAllRentalStorages();
        List<RentalStorage> SelectAllRentalDetails();
        int UpdateRentalStorageDateOfReturn(RentalStorage rse);


    }
}
