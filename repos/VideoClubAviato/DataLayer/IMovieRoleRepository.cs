using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IMovieRoleRepository
    {

        int InsertMovieRole(MovieRole mr);
        List<MovieRole_Actor_Movie> SelectAllMovieRoles();
        int UpdateMovieRole(MovieRole mr);
        int DeleteMovieRole(MovieRole mr);
        int UpdateActorOnMovieRole(MovieRole mr);
        int DeleteMovieRoleOnMovies(Movie m);


    }
}
