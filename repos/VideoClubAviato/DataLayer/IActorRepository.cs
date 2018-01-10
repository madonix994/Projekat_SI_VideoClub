using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IActorRepository
    {

        int InsertActor(Actor a);
        List<Actor> SelectAllActors();
        int UpdateActor(Actor a);
        int DeleteActor(Actor a);


    }
}
