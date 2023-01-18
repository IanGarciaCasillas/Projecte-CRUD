using Firebase.Database;
using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Dades.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Domini
{
    public class DominiPersona : IDomini
    {
        public IRepositori Repositori { get; set; }

        public DominiPersona()
        {
            Repositori = new Repositori();
        }

        public Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirPersona()
        {
            return Repositori.ObtenirPersona();
        }
    }
}
