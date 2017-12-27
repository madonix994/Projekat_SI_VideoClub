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

        public DirectorRepository directorRepository = new DirectorRepository();

        public List<Director> SelectAllDirectors()
        {
            return directorRepository.SelectAllDirectors();

        }
    }
}
