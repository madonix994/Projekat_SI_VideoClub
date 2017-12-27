using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessMovieRole
    {
        //POVEZIVANJE SA DATA LAYER-OM
        public MovieRoleRepository movieRoleRepository = new MovieRoleRepository();
        public MovieRepository movieRepository = new MovieRepository();



        /* LOGICKA PROVERA ZA POMOCNU METODU ZA TABELU FILMOVI --> KREIRANJE METODE ZA UNOS NOVE ULOGE SA NAZIVOM "Nije Uneto"  
        i OPISOM "Nije Uneto" GDE SETUJEMO I GLUMCA NA "Nije Uneto", POTREBNA PRILIKOM UNOSA NOVOG FILMA
        KAKO BI FILM KOJI SE UNOSI DOBIO U ISPISU ULOGU I GLUMCA "Nije Uneto" I GDE MOZEMO KASNIJE AZURIRATI TAJ FILM

        TAKODJE OVA METODA VRSI I OBICAN INSERT U BAZU
        (potrebno radi lancane reakcije nesto kao triger)*/
        public bool InsertMovieRole(MovieRole mr)
        {
            if (movieRoleRepository.InsertMovieRole(mr) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA ISPIS ULOGA
        public List<MovieRole_Actor_Movie> SelectAllMovieRoles()
        {
            return movieRoleRepository.SelectAllMovieRoles();
        }

        //LOGICKA PROVERA ZA PRETRAGU ULOGE PO NAZIVU
        public List<MovieRole_Actor_Movie> SearchMovieRole(string MovieRolePom)
        {
            return movieRoleRepository.SelectAllMovieRoles().Where(
            mr => mr.GetSetRole_Name1.Contains(MovieRolePom) ||
            mr.GetSetRole_Name1.ToLower().Contains(MovieRolePom) ||
            mr.GetSetRole_Name1.ToUpper().Contains(MovieRolePom) ||
            mr.GetSetRole_Name1.StartsWith(MovieRolePom) ||
            mr.GetSetMovie_Name1.Contains(MovieRolePom) ||
            mr.GetSetMovie_Name1.ToLower().Contains(MovieRolePom) ||
            mr.GetSetMovie_Name1.ToUpper().Contains(MovieRolePom) ||
            mr.GetSetMovie_Name1.StartsWith(MovieRolePom) ||
            mr.GetSetActor_Name1.Contains(MovieRolePom) ||
            mr.GetSetActor_Name1.ToLower().Contains(MovieRolePom) ||
            mr.GetSetActor_Name1.ToUpper().Contains(MovieRolePom) ||
            mr.GetSetActor_Name1.StartsWith(MovieRolePom) ||
            mr.GetSetActor_Surname1.Contains(MovieRolePom) ||
            mr.GetSetActor_Surname1.ToLower().Contains(MovieRolePom) ||
            mr.GetSetActor_Surname1.ToUpper().Contains(MovieRolePom) ||
            mr.GetSetActor_Surname1.StartsWith(MovieRolePom) ||

            (mr.GetSetActor_Name1 + " " + mr.GetSetActor_Surname1).Contains(MovieRolePom) ||
            (mr.GetSetActor_Name1 + " " + mr.GetSetActor_Surname1).ToLower().Contains(MovieRolePom) ||
           (mr.GetSetActor_Name1 + " " + mr.GetSetActor_Surname1).ToUpper().Contains(MovieRolePom)).ToList();
        }

        //Logicka provera za azuriranje Uloge
        public bool UpdateMovieRole(MovieRole mr)
        {
            if (movieRoleRepository.UpdateMovieRole(mr) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Logicka provera za brisanje Uloge
        public bool DeleteMovieRole(MovieRole mr)
        {
            if (movieRoleRepository.DeleteMovieRole(mr) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* LOGICKA PROVERA ZA POMOCNU METODU ZA TABELU FILMOVI --> KREIRANJE METODE ZA BRISANJE ULOGE POTREBNA ZBOG FK, 
        GDE BRISEMO ULOGU KOJA JE POVEZANA SA TIM ODREDJENIM FILMOM KOJEG BRISEMO IZ TABELE FILMOVI 
        (potrebno radi lancane reakcije nesto kao triger) */
        public bool DeleteMovieRoleOnMovies(Movie m)
        {
            if (movieRoleRepository.DeleteMovieRoleOnMovies(m) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        /*LOGICKA PROVERA ZA TRIGER (VRSIMO AZURIRANJE TABELE MOVIE ROLE GDE SETUJEMO IME I OPIS ULOGE NA "Nije Uneto" A NAJVAZNIJE
        SETUJEMO ID GLUMCA KOJI JE POVEZAN SA TOM ULOGOM NA GLUMCA"Nije Uneto" KOJI SE NALAZI U BAZI
        (potrebno radi lancane reakcije nesto kao triger)) */
        public bool UpdateActorOnMovieRole(MovieRole mr)
        {
            if (movieRoleRepository.UpdateActorOnMovieRole(mr) > 0)
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
