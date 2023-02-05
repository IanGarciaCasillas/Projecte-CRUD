using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Dades.Model
{
    public class PersonaArray
    {

        public bool DisponibilidadParaViajar { get; set; }
        public int Edad { get; set; }
        public string[] Lenguajes { get; set; }
        public string Nombre { get; set; }
        public string Profesion { get; set; }
        public RangoProfesional RangoProfesional { get; set; }


        public override string ToString()
        {
            return $"Nombre:{Nombre}\n\t" +
                $"Edad: {Edad}\n\t" +
                $"Dispon: {DisponibilidadParaViajar}\n\t" +
                $"Lenguajes: {Lenguajes.Length}\n\t" +
                $"Profesion: {Profesion}\n\t" +
                $"Rango: {RangoProfesional.Nivel}|{RangoProfesional.AniosDeExperiencia}";
        }

    }
}
