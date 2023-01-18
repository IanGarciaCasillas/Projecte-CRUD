using Firebase.Database;
using Projecte_CRUD.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Domini
{
    public interface IDomini
    {
        Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirPersona();
    }
}
