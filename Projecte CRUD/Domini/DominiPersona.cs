using Firebase.Database;
using Firebase.Database.Query;
using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Dades.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public async Task AfegirPersona(PersonaObj persona,string nom)
        {
            await Repositori.AfegirPersona(persona, nom);
        }

        public async Task EliminarPersona(string nomPersona)
        {
            await Repositori.EliminarPersona(nomPersona);
        }

        public Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirUnaPersona(string keyNom)
        {
            return Repositori.ObtenirUnaPersona(keyNom);
        }

        public async Task<bool> ExistPersona(string nom)
        {
            bool trobat = false;
            var lstPersones = await ObtenirPersona();
            
            foreach(var person in lstPersones)
            {
                if (person.Key == nom)
                {
                    trobat = true;
                    break;
                }
            }


            return trobat;
        }
    }
}
