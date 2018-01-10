using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IGenreRepository
    {

        int InsertGenre(Genre g);
        List<Genre> SelectAllGenres();
        int UpdateGenre(Genre g);
        int DeleteGenre(Genre g);

    }
}
