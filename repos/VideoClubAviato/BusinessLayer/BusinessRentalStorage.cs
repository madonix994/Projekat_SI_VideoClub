using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class BusinessRentalStorage
    {
        //POVEZIVANJE SA DATA LAYER-OM
        private IRentalStorageRepository rentalStorageRepository;

        public BusinessRentalStorage(IRentalStorageRepository rentalStorageRepository)
        {
            this.rentalStorageRepository = rentalStorageRepository;
        }


        //LOGICKA PROVERA ZA UNOS PODATAKA O REZERVACIJI
        public bool InsertRentalStorage(RentalStorage rs)
        {
            if (rentalStorageRepository.InsertRentalStorage(rs) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGIKA ZA ISPIS SKLADISTA
        public List<RentalStorage> SelectAllRentalStorages()
        {
            List<RentalStorage> lista = rentalStorageRepository.SelectAllRentalStorages();
            return lista;
        }


        //LOGIKA ZA ISPIS SKLADISTA DETALJI
        public List<RentalStorage> SelectAllRentalDetailsByNameAndSurname()
        {
            List<RentalStorage> lista = rentalStorageRepository.SelectAllRentalDetails();
            return lista;
        }


        //LOGICKA PROVERA ZA AZURIRANJE RENTALSTORAGE (Datum Vracanja)
        public bool UpdateRentalStorageDateOfReturn(RentalStorage rse)
        {
            if (rentalStorageRepository.UpdateRentalStorageDateOfReturn(rse) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //LOGIKA ZA PRETRAGU SKLADISTA
        public List<RentalStorage> SearchRentalStorage(string RentalStoragePom)
        {
            List<RentalStorage> lista = rentalStorageRepository.SelectAllRentalStorages().Where(
            rs => rs.GetSetUserCard_Name1.Contains(RentalStoragePom) || 
            rs.GetSetUserCard_Name1.ToLower().Contains(RentalStoragePom) ||
            rs.GetSetUserCard_Name1.ToUpper().Contains(RentalStoragePom) || 
            rs.GetSetUserCard_Name1.StartsWith(RentalStoragePom) ||
            rs.GetSetUserCard_Surname1.Contains(RentalStoragePom) || 
            rs.GetSetUserCard_Surname1.ToLower().Contains(RentalStoragePom) ||
            rs.GetSetUserCard_Surname1.ToUpper().Contains(RentalStoragePom) || 
            rs.GetSetUserCard_Surname1.StartsWith(RentalStoragePom) ||
           (rs.GetSetUserCard_Name1 + " " + rs.GetSetUserCard_Surname1).Contains(RentalStoragePom) ||
           (rs.GetSetUserCard_Name1 + " " + rs.GetSetUserCard_Surname1).ToLower().ToUpper().Contains(RentalStoragePom) ||
           (rs.GetSetUserCard_Name1 + " " + rs.GetSetUserCard_Name1).ToUpper().ToLower().Contains(RentalStoragePom) || 
           (rs.GetSetUserCard_Name1 + " " + rs.GetSetUserCard_Surname1).StartsWith(RentalStoragePom)).ToList();

            return lista;
        }

    }
}
