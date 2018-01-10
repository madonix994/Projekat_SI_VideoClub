using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IMovieRepository
    {

        int InsertMovie(Movie m);
        List<Movie_Genre_Director> SelectAllMovies();
        List<Movie_Genre_Director_MovieRole_Actor> SearchByAll();
        int UpdateMovie(Movie m);
        int DeleteMovie(Movie m);
        int UpdateGenreOnMovie(Movie m);
        int UpdateDirectorOnMovie(Movie m);
        List<Movie> SelectAllMoviesIdAndName();
        List<Movie> SelectAllMoviesIdAndNameAndAmount();
        int UpdateMovieAmount(Movie m);
        int UpdateMovieAmountMinus(Movie m);
        int UpdateMovieStatus(Movie m);
        int UpdateMovieStatus2(Movie m);


    }
}
