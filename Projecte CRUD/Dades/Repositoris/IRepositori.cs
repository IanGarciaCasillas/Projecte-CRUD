using Firebase.Database;
using Firebase.Database.Query;
using Projecte_CRUD.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Dades.Repositoris
{
    public interface IRepositori
    {
        Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirPersona();
        void AfegirPersona(PersonaObj persona, string nom);
        void EliminarPersona(string nomPersona);
        Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirUnaPersona(string keyNom);


        
    }
}
