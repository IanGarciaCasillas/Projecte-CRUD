using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Dades.Repositoris;
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
    public partial class NovaPersonaForm : Form
    {
        IDomini Domini { get; set; }

        public NovaPersonaForm(IDomini domini)
        {
            InitializeComponent();
            Domini = domini;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            Domini.AfegirPersona(newPerson, nom);

        }

        private void btnAddLlenguatge_Click(object sender, EventArgs e)
        {
            string llenguatge = this.txbLlenguatge.Text.ToString();

            this.lsbLlenguatge.Items.Add(llenguatge);
            this.txbLlenguatge.Text = "";

        }

    }
}
