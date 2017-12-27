using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessDirector
    {

        // POVEZIVANJE SA DATA LAYER-OM
        public DirectorRepository directorRepository = new DirectorRepository();


        //LOGICKA PROVERA ZA UNOS GLUMCA
        public bool InsertDirector(Director d)
        {
            if (directorRepository.InsertDirector(d) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA ISPIS GLUMCA
        public List<Director> SelectAllDirectors()
        {
            return directorRepository.SelectAllDirectors();
        }

        //LOGICKA PROVERA ZA PRETRAGU REZISERA BEZ OSKARA
        public List<Director> SearchDirector(string DirectorPom)
        {
            return directorRepository.SelectAllDirectors().Where(
            d => d.GetSetDirector_Name1.Contains(DirectorPom) ||
            d.GetSetDirector_Name1.ToLower().Contains(DirectorPom) ||
            d.GetSetDirector_Name1.ToUpper().Contains(DirectorPom) ||
            d.GetSetDirector_Name1.StartsWith(DirectorPom) ||
            d.GetSetDirector_Surname1.Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.ToLower().Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.ToUpper().Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.StartsWith(DirectorPom) ||
            Convert.ToString(d.GetSetDirector_Date_Of_Birth1).Contains(DirectorPom) ||
            Convert.ToString(d.GetSetDirector_Date_Of_Birth1).StartsWith(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).Contains(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).ToLower().Contains(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).ToUpper().Contains(DirectorPom)).ToList();
        }

        //LOGICKA PROVERA ZA PRETRAGU REZISERA SA OSKAROM
        public List<Director> SearchDirectorByOscar(string DirectorPom)
        {
            return directorRepository.SelectAllDirectors().Where(
            d => (d.GetSetDirector_Name1.Contains(DirectorPom) ||
            d.GetSetDirector_Name1.ToLower().Contains(DirectorPom) ||
            d.GetSetDirector_Name1.ToUpper().Contains(DirectorPom) ||
            d.GetSetDirector_Name1.StartsWith(DirectorPom) ||
            d.GetSetDirector_Surname1.Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.ToLower().Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.ToUpper().Contains(DirectorPom) ||
            d.GetSetDirector_Surname1.StartsWith(DirectorPom) ||
            Convert.ToString(d.GetSetDirector_Date_Of_Birth1).Contains(DirectorPom) ||
            Convert.ToString(d.GetSetDirector_Date_Of_Birth1).StartsWith(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).Contains(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).ToLower().Contains(DirectorPom) ||
            (d.GetSetDirector_Name1 + " " + d.GetSetDirector_Surname1).ToUpper().Contains(DirectorPom)) && d.GetSetDirector_Oscar1 == true).ToList();
        }


        //LOGICKA PROVERA ZA AZURIRANJE REZISERA
        public bool UpdateDirector(Director d)
        {
            if (directorRepository.UpdateDirector(d) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //LOGICKA PROVERA ZA BRISANJE REZISERA
        public bool DeleteDirector(Director d)
        {
            if (directorRepository.DeleteDirector(d) > 0)
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
