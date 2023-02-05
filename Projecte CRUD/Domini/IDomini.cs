using Firebase.Database;
using Firebase.Database.Query;
using Projecte_CRUD.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Domini
{
    public interface IDomini
    {
        Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirPersona();
        Task<bool> ExistPersona(string nom);
        Task AfegirPersona(PersonaObj persona, string nom);
        Task EliminarPersona(string nomPersona);
        Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirUnaPersona(string keyNom);


        Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> ObtenirPersonesArray();
        Task<Tuple<bool, string>> ExistPersonaArray(string nom);
        Task AfegirPersonaArray(PersonaArray persona,string idx);
        Task EliminarPersonaArray(string idxPersona);
        Task<string> ObtenirIdxPersona(string dadesPersona);
        Task<PersonaArray> ObtenirUnaPersonaArray(string idxArray);
    }
}
