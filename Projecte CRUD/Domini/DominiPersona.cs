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
        #region PERSONES OBJECT
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
        #endregion
        public Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> ObtenirPersonesArray()
        {
            return Repositori.ObtenirPersonesArray();
        }
        public async Task<Tuple<bool, string>> ExistPersonaArray(string nom)
        {
            Tuple<bool, string> result;
            bool trobat = false;
            var lstPersonesArray = await ObtenirPersonesArray();
            foreach(var persona in lstPersonesArray)
            {
                if(persona.Object.Nombre == nom)
                {
                    trobat = true;
                    break;
                }
            }
            if(trobat)
                result = new Tuple<bool, string>(trobat, "");
            else 
                result = new Tuple<bool, string>(trobat, Convert.ToString(lstPersonesArray.Count));
            
            return result;
        }
        public async Task AfegirPersonaArray(PersonaArray persona,string idx)
        {
            await Repositori.AfegirPersonaArray(persona,idx);
        }
        public async Task EliminarPersonaArray(string idxPersona)
        {
            await Repositori.EliminarPersonaArray(idxPersona);
        }
        public async Task<string> ObtenirIdxPersona(string nomPersona)
        {
            var lstPersonesArray = await ObtenirPersonesArray();
            string idxPersona="";
            foreach(var person in lstPersonesArray)
            {
                if(person.Object.Nombre == nomPersona)
                {
                    idxPersona = person.Key;
                    break;
                }
            }
            return idxPersona;
        }
        public async Task<PersonaArray> ObtenirUnaPersonaArray(string idxArray)
        {
            var lstPersonesArray = await ObtenirPersonesArray();
            PersonaArray personaSelect = new PersonaArray();
            foreach(var person in lstPersonesArray)
            {
                if(person.Key == idxArray)
                {
                    personaSelect = person.Object;
                    break;
                }
            }

            return personaSelect;
        }
    }
}
