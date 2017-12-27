using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessMovie
    {
        //POVEZIVANJE SA DATA LAYER-OM
        public MovieRepository movieRepository = new MovieRepository();

        //LOGICKA PROVERA ZA UNOS FILMA
        public bool InsertMovie(Movie m)
        {
            if (movieRepository.InsertMovie(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Movie> SelectAllMoviesIdAndName()
        {
            List<Movie> lista = movieRepository.SelectAllMoviesIdAndName();
            return lista;
        }

        //LOGICKA PROVERA ZA ISPIS FILMA POTREBNA PRI UNOSU!!!
        public List<Movie_Genre_Director> SelectAllMovies()
        {
            return movieRepository.SelectAllMovies();
        }

        //LOGICKA PROVERA ZA ISPIS FILMA
        public List<Movie_Genre_Director_MovieRole_Actor> SelectAllMoviesAllClasses()
        {
            return movieRepository.SearchByAll();
        }

        //LOGICKA PROVERA ZA PRETRAGU FILMA Po NAZIVU FILMA,GODINI IZDANJA FILMA, GLUMCU, REZISERU
        public List<Movie_Genre_Director_MovieRole_Actor> SearchMovie(string MoviePom)
        {
            return movieRepository.SearchByAll().Where(
            m => m.GetSetMovie_Name1.Contains(MoviePom) || m.GetSetMovie_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetMovie_Name1.ToUpper().Contains(MoviePom) || m.GetSetMovie_Name1.StartsWith(MoviePom) ||
            Convert.ToString(m.GetSetMovie_Year1).Contains(MoviePom) || Convert.ToString(m.GetSetMovie_Year1).StartsWith(MoviePom) ||
            m.GetSetActor_Name1.Contains(MoviePom) || m.GetSetActor_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetActor_Name1.ToUpper().Contains(MoviePom) || m.GetSetActor_Name1.StartsWith(MoviePom) ||
            m.GetSetActor_Surname1.Contains(MoviePom) || m.GetSetActor_Surname1.ToLower().Contains(MoviePom) ||
            m.GetSetActor_Surname1.ToUpper().Contains(MoviePom) || m.GetSetActor_Surname1.StartsWith(MoviePom) ||
            m.GetSetDirector_Name1.Contains(MoviePom) || m.GetSetDirector_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetDirector_Name1.ToUpper().Contains(MoviePom) || m.GetSetDirector_Name1.StartsWith(MoviePom) ||
            m.GetSetDirector_Surname1.Contains(MoviePom) || m.GetSetDirector_Surname1.ToLower().Contains(MoviePom) ||
            m.GetSetDirector_Surname1.ToUpper().Contains(MoviePom) || m.GetSetDirector_Surname1.StartsWith(MoviePom) ||
            m.GetSetRole_Name1.Contains(MoviePom) || m.GetSetRole_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetRole_Name1.ToUpper().Contains(MoviePom) || m.GetSetRole_Name1.StartsWith(MoviePom) ||
            (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).Contains(MoviePom) || (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).ToLower().Contains(MoviePom) ||
            (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).ToUpper().Contains(MoviePom) || (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).StartsWith(MoviePom) ||
            (m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1).Contains(MoviePom) || (m.GetSetGenre_Name1 + " " + m.GetSetDirector_Surname1).ToLower().Contains(MoviePom) ||
            (m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1).ToUpper().Contains(MoviePom) || (m.GetSetGenre_Name1 + " " + m.GetSetDirector_Surname1).StartsWith(MoviePom)
            ).ToList();

        }

        //LOGICKA PROVERA ZA PRETRAGU FILMA Po NAZIVU FILMA,GODINI IZDANJA FILMA, GLUMCU, REZISERU UKOLIKO FILM IMA OSKARA
        public List<Movie_Genre_Director_MovieRole_Actor> SearchMovieOscar(string MoviePom)
        {
            return movieRepository.SearchByAll().Where(
            m => (m.GetSetMovie_Name1.Contains(MoviePom) || m.GetSetMovie_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetMovie_Name1.ToUpper().Contains(MoviePom) || m.GetSetMovie_Name1.StartsWith(MoviePom) ||
            Convert.ToString(m.GetSetMovie_Year1).Contains(MoviePom) || Convert.ToString(m.GetSetMovie_Year1).StartsWith(MoviePom) ||
            m.GetSetActor_Name1.Contains(MoviePom) || m.GetSetActor_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetActor_Name1.ToUpper().Contains(MoviePom) || m.GetSetActor_Name1.StartsWith(MoviePom) ||
            m.GetSetActor_Surname1.Contains(MoviePom) || m.GetSetActor_Surname1.ToLower().Contains(MoviePom) ||
            m.GetSetActor_Surname1.ToUpper().Contains(MoviePom) || m.GetSetActor_Surname1.StartsWith(MoviePom) ||
            m.GetSetDirector_Name1.Contains(MoviePom) || m.GetSetDirector_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetDirector_Name1.ToUpper().Contains(MoviePom) || m.GetSetDirector_Name1.StartsWith(MoviePom) ||
            m.GetSetDirector_Surname1.Contains(MoviePom) || m.GetSetDirector_Surname1.ToLower().Contains(MoviePom) ||
            m.GetSetDirector_Surname1.ToUpper().Contains(MoviePom) || m.GetSetDirector_Surname1.StartsWith(MoviePom) ||
            m.GetSetRole_Name1.Contains(MoviePom) || m.GetSetRole_Name1.ToLower().Contains(MoviePom) ||
            m.GetSetRole_Name1.ToUpper().Contains(MoviePom) || m.GetSetRole_Name1.StartsWith(MoviePom) ||
            (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).Contains(MoviePom) || (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).ToLower().Contains(MoviePom) ||
            (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).ToUpper().Contains(MoviePom) || (m.GetSetActor_Name1 + " " + m.GetSetActor_Surname1).StartsWith(MoviePom) ||
            (m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1).Contains(MoviePom) || (m.GetSetGenre_Name1 + " " + m.GetSetDirector_Surname1).ToLower().Contains(MoviePom) ||
            (m.GetSetDirector_Name1 + " " + m.GetSetDirector_Surname1).ToUpper().Contains(MoviePom) || (m.GetSetGenre_Name1 + " " + m.GetSetDirector_Surname1).StartsWith(MoviePom)) &&
            m.GetSetMovie_Oskar1 == true
            ).ToList();

        }

        //LOGICKA PROVERA ZA AZURIRANJE FILMA
        public bool UpdateMovie(Movie m)
        {
            if (movieRepository.UpdateMovie(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA BRISANJE FILMA
        public bool DeleteMovie(Movie m)
        {
            if (movieRepository.DeleteMovie(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*POMOCNA METODA ZA TABELU ZANROVI --> LOGICKA PROVERA ZA TRIGER (GDE VRSIMO AZURIRANJE MOVIE TABELE ODNOSNO SETUJEMO ZANR ZA ODREDJENI FILM
          NA "Nije Uneto" U OKVIRU MOVIE TABELE NAKON BRISANJA TOG ZANRA IZ TABELE ZANROVI) */
        public bool UpdateGenreOnMovie(Movie m)
        {
            if (movieRepository.UpdateGenreOnMovie(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /* LOGICKA PROVERA ZA SETOVANJE ID-a REZISERA U TABELI Movies
           NAKON STO SE REZISER IZBRISE IZ TABELE Directors */
        public bool UpdateDirectorOnMovie(Movie m)
        {
            if (movieRepository.UpdateDirectorOnMovie(m) > 0)
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

