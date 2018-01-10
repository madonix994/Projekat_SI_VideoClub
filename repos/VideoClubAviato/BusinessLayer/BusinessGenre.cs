using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessGenre
    {

        //POVEZIVANJE SA DATA LAYER-OM
       
        private IGenreRepository genreRepository;

        public BusinessGenre(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }


        public bool InsertGenre(Genre g)
        {
            if (genreRepository.InsertGenre(g) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA ISPIS ZANRA
        public List<Genre> SelectAllGenres()
        {
            return genreRepository.SelectAllGenres();

        }


        //LOGICKA PROVERA ZA AZURIRANJE ZANRA
        public bool UpdateGenre(Genre g)
        {
            if (genreRepository.UpdateGenre(g) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA PRETRAGU ZANRA
        public List<Genre> SearchbyGenre(string GenrePom)
        {
            return genreRepository.SelectAllGenres().Where(
            g => g.GetSetGenre_Name1.Contains(GenrePom) || g.GetSetGenre_Name1.ToLower().Contains(GenrePom) ||
            g.GetSetGenre_Name1.ToUpper().Contains(GenrePom) || g.GetSetGenre_Name1.StartsWith(GenrePom)
            ).ToList();

        }

        //LOGICKA PROVERA ZA BRISANJE ZANRA
        public bool DeleteGenre(Genre g)
        {
            if (genreRepository.DeleteGenre(g) > 0)
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
