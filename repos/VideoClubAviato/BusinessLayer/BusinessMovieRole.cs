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
        public MovieRoleRepository movieRoleRepository = new MovieRoleRepository();

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

        /* LOGICKA PROVERA ZA POMOCNU METODU ZA TABELU FILMOVI --> KREIRANJE METODE ZA UNOS NOVE ULOGE SA NAZIVOM "Nije Uneto"  
        i OPISOM "Nije Uneto" GDE SETUJEMO I GLUMCA NA "Nije Uneto", POTREBNA PRILIKOM UNOSA NOVOG FILMA
        KAKO BI FILM KOJI SE UNOSI DOBIO U ISPISU ULOGU I GLUMCA "Nije Uneto" I GDE MOZEMO KASNIJE AZURIRATI TAJ FILM
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
