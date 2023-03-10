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
    public partial class NovaPersonaArrayForm : Form
    {
        IDomini Domini { get; set; }
        public NovaPersonaArrayForm(IDomini domini)
        {
            InitializeComponent();
            Domini = domini;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            RangoProfesional rangProfesional = new RangoProfesional();
            PersonaArray newPerson = new PersonaArray();
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
            newPerson.Nombre = nom;
            newPerson.Profesion = profesion;
            newPerson.RangoProfesional = rangProfesional;

            var count = llenguatges.Count;
            string[] llenguatgesList = new string[count];
            for (int i = 0; i < count; i++)
            {
                llenguatgesList[i] = (string)llenguatges[i];
            }
            newPerson.Lenguajes = llenguatgesList;
            var result = await Domini.ExistPersonaArray(nom);

            if (result.Item1)
                MessageBox.Show($"La persona {nom} ja existeix");
            else
            {
                await Domini.AfegirPersonaArray(newPerson,result.Item2);
                MessageBox.Show($"Persona {nom} afegida");
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
            lsbLlenguatge.Items.Remove(nomLeng);
        }
    }
}
