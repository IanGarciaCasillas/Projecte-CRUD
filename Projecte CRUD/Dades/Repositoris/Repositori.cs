using Firebase.Database;
using Firebase.Database.Query;
using Projecte_CRUD.Dades.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Dades.Repositoris
{
    public class Repositori : IRepositori
    {

        public FirebaseClient Firebase { get; set; }

        public Repositori()
        {
            Firebase = FireBaseClient.GetFireBaseClient();
        }
        #region PERSONA OBJECT
        public async Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirPersona()
        {
            return await Firebase.Child("PersonasObject").OrderByKey().OnceAsync<PersonaObj>();
        }

        public async Task AfegirPersona(PersonaObj persona, string nom)
        {
            await Firebase.Child("PersonasObject").Child(nom).PutAsync(persona);
        }

        public async Task EliminarPersona(string nomPersona)
        {
            await Firebase.Child("PersonasObject").Child(nomPersona).DeleteAsync();
        }

        public async Task<IReadOnlyCollection<FirebaseObject<PersonaObj>>> ObtenirUnaPersona(string keyNom)
        {
            return await Firebase.Child("PersonasObject").OrderByKey().StartAt(keyNom).LimitToFirst(1).OnceAsync<PersonaObj>();
        }
        #endregion

        public async Task<IReadOnlyCollection<FirebaseObject<PersonaArray>>> ObtenirPersonesArray()
        {
            return await Firebase.Child("PersonasArray").OrderByKey().OnceAsListAsync<PersonaArray>();
        }
        public async Task AfegirPersonaArray(PersonaArray persona,string idx)
        {
            await Firebase.Child("PersonasArray").Child(idx).PutAsync(persona);
        }
        public async Task EliminarPersonaArray(string idxPersona)
        {
            await Firebase.Child("PersonasArray").Child(idxPersona).DeleteAsync();
        }
    }
}
