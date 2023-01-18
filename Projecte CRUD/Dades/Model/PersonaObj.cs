using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_CRUD.Dades.Model
{
    public class PersonaObj
    {
        public string DisponibilidadParaViajar { get; set; }
        public int Edad { get; set; }
        public string[] Lenguajes { get; set; }
        public string Profesion { get; set; }
        public RangoProfesional RangoProfesional { get; set; }



        public override string ToString()
        {
            string linia =$"Dispon:{DisponibilidadParaViajar}\n\t" +
                $"Edad: {Edad}\n\t" +
                $"Lenguajes: {Lenguajes.Length}\n\t" +
                $"Profesion: {Profesion}\n\t" +
                $"Rango: {RangoProfesional.Nivel}|{RangoProfesional.AniosDeExperiencia}";
            
            return linia;
        }
    }
}
