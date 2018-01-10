using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDirectorRepository
    {
        int InsertDirector(Director d);
        List<Director> SelectAllDirectors();
        int UpdateDirector(Director d);
        int DeleteDirector(Director d);



    }
}
