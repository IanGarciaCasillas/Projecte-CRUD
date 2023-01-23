using Firebase.Database;
using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Domini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_CRUD.Vistes
{
    public partial class InfoPersonaForm : Form
    {
        FirebaseObject<PersonaObj> Person { get; set; }
        IDomini Domini { get; set; }
        public InfoPersonaForm(FirebaseObject<PersonaObj> person, IDomini domini)
        {
            InitializeComponent();
            Person = person;
            Domini = domini;
            this.txbNom.Text = Person.Key;
            this.txbEdat.Text = Person.Object.Edad.ToString();
            this.txbProfesion.Text = Person.Object.Profesion;
            this.txbAnsExperiencia.Text = Person.Object.RangoProfesional.AniosDeExperiencia.ToString();
            this.txbNivell.Text = Person.Object.RangoProfesional.Nivel;
            this.chbDisponViatjar.Checked = Person.Object.DisponibilidadParaViajar;
            this.txbNom.Enabled = false;
            foreach(var item in Person.Object.Lenguajes)
            {
                lsbLlenguatge.Items.Add(item);
            }
        }

        private void btnAddLlenguatge_Click(object sender, EventArgs e)
        {
            string llenguatge = this.txbLlenguatge.Text.ToString();

            this.lsbLlenguatge.Items.Add(llenguatge);
            this.txbLlenguatge.Text = "";
        }

        private void btnEliminarLeng_Click(object sender, EventArgs e)
        {
            var idx = lsbLlenguatge.SelectedIndex;
            var nomLeng = lsbLlenguatge.Items[idx].ToString();
            List<string> list = new List<string>();
            foreach(var item in Person.Object.Lenguajes)
            {
                if(item != nomLeng)
                {

                    list.Add(item);
                }

            }
            var newArray = list.ToArray();
            Person.Object.Lenguajes = newArray;
            lsbLlenguatge.Items.Remove(nomLeng);
        }

        private void btnUpdatePerson_Click(object sender, EventArgs e)
        {

            RangoProfesional rangProfesional = new RangoProfesional();
            PersonaObj newPerson = new PersonaObj();

            string nom = this.txbNom.Text.ToString();
            string edat = this.txbEdat.Text.ToString();
            string profesion = this.txbProfesion.Text.ToString();
            bool disponViatjar = this.chbDisponViatjar.Checked;
            string nivell = this.txbNivell.Text.ToString();
            var llenguatges = this.lsbLlenguatge.Items;
            string ansExperiencia = this.txbAnsExperiencia.Text.ToString();

            rangProfesional.AniosDeExperiencia = Convert.ToInt32(ansExperiencia);
            rangProfesional.Nivel = nivell;

            newPerson.DisponibilidadParaViajar = disponViatjar;
            newPerson.Edad = Convert.ToInt32(edat);

            newPerson.Profesion = profesion;
            newPerson.RangoProfesional = rangProfesional;


            var count = llenguatges.Count;
            string[] llenguatgesList = new string[count];
            for (int i = 0; i < count; i++)
            {
                llenguatgesList[i] = (string)llenguatges[i];
            }


            newPerson.Lenguajes = llenguatgesList;
            

            Domini.AfegirPersona(newPerson, Person.Key);
        }
    }
}
