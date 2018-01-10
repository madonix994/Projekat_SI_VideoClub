using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessActor
    {
        // POVEZIVANJE SA DATA LAYER-OM
        private IActorRepository actorRepository;


        public BusinessActor(IActorRepository actorRepository)
        {
            this.actorRepository = actorRepository;
        }

        //LOGICKA PROVERA ZA UNOS GLUMCA
        public bool InsertActor(Actor a)
        {
            if (actorRepository.InsertActor(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //LOGICKA PROVERA ZA ISPIS GLUMCA
        public List<Actor> SelectAllActors()
        {
            return actorRepository.SelectAllActors();

        }

        ////LOGICKA PROVERA ZA AZURIRANJE GLUMCA
        public bool UpdateActor(Actor a)
        {
            if (actorRepository.UpdateActor(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////LOGICKA PROVERA ZA BRISANJE GLUMCA
        public bool DeleteActor(Actor a)
        {
            if (actorRepository.DeleteActor(a) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        ////LOGICKA PROVERA ZA PRETRAGU GLUMCA
        public List<Actor> SearchActors(string ActorPom)
        {
            return actorRepository.SelectAllActors().Where(
            a => a.GetSetActor_Name1.Contains(ActorPom) || a.GetSetActor_Name1.ToLower().Contains(ActorPom) ||
            a.GetSetActor_Name1.ToUpper().Contains(ActorPom) || a.GetSetActor_Name1.StartsWith(ActorPom) ||
            a.GetSetActor_Surname1.Contains(ActorPom) || a.GetSetActor_Surname1.ToLower().Contains(ActorPom) ||
            a.GetSetActor_Surname1.ToUpper().Contains(ActorPom) || a.GetSetActor_Surname1.StartsWith(ActorPom) ||
            Convert.ToString(a.GetSetActor_Date_Of_Birth1).Contains(ActorPom) || Convert.ToString(a.GetSetActor_Date_Of_Birth1).StartsWith(ActorPom) ||
            (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).Contains(ActorPom) || (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).ToLower().Contains(ActorPom) ||
            (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).ToUpper().Contains(ActorPom) || (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).StartsWith(ActorPom)

            ).ToList();
        }

        ////LOGICKA PROVERA ZA PRETRAGU GLUMCA UKOLIKO GLUMAC IMA OSKARA
        public List<Actor> SearchActorsbyOscar(string ActorPom)
        {
            return actorRepository.SelectAllActors().Where(
            a => (a.GetSetActor_Name1.Contains(ActorPom) || a.GetSetActor_Name1.ToLower().Contains(ActorPom) ||
            a.GetSetActor_Name1.ToUpper().Contains(ActorPom) || a.GetSetActor_Name1.StartsWith(ActorPom) ||
            a.GetSetActor_Surname1.Contains(ActorPom) || a.GetSetActor_Surname1.ToLower().Contains(ActorPom) ||
            a.GetSetActor_Surname1.ToUpper().Contains(ActorPom) || a.GetSetActor_Surname1.StartsWith(ActorPom) ||
            Convert.ToString(a.GetSetActor_Date_Of_Birth1).Contains(ActorPom) || Convert.ToString(a.GetSetActor_Date_Of_Birth1).StartsWith(ActorPom) ||
            (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).Contains(ActorPom) || (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).ToLower().Contains(ActorPom) ||
            (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).ToUpper().Contains(ActorPom) || (a.GetSetActor_Name1 + " " + a.GetSetActor_Surname1).StartsWith(ActorPom)) &&
            a.GetSetActor_Oscar1 == true
            ).ToList();
        }

    }
}
