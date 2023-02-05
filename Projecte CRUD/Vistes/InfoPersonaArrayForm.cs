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
    public partial class InfoPersonaArrayForm : Form
    {
        public PersonaArray Persona { get; set; }
        public string IdxPersona { get; set; }
        IDomini Domini { get; set; }
        public InfoPersonaArrayForm(PersonaArray person, string keyPerson, IDomini domini)
        {
            Persona = person;
            IdxPersona = keyPerson;
            Domini = domini;
            InitializeComponent();

            this.txbNom.Text = Persona.Nombre;
            this.txbEdat.Text = Persona.Edad.ToString();
            this.txbProfesion.Text = Persona.Profesion.ToString();
            this.txbAnsExperiencia.Text = Persona.RangoProfesional.AniosDeExperiencia.ToString();
            this.txbNivell.Text = Persona.RangoProfesional.Nivel;
            this.chbDisponViatjar.Checked = Persona.DisponibilidadParaViajar;

            foreach(var leng in Persona.Lenguajes)
            {
                lsbLlenguatge.Items.Add(leng);
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

        private async void btnUpdatePerson_Click(object sender, EventArgs e)
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

            if(Persona.Nombre != nom)
            {
                var result = await Domini.ExistPersonaArray(nom);
                if (result.Item1)
                {
                    var resultUser = MessageBox.Show($"Ja exiteix la persona {nom}\n Segur que vols confirmar els canvis?", "Persona existent", MessageBoxButtons.OKCancel);
                    if(resultUser == DialogResult.OK)
                    {
                        await Domini.EliminarPersonaArray(IdxPersona);
                        await Domini.AfegirPersonaArray(newPerson, IdxPersona);
                        MessageBox.Show($"Informacio de la persona {nom} actualitzada");
                    }
                }
                else
                {
                    await Domini.EliminarPersonaArray(IdxPersona);
                    await Domini.AfegirPersonaArray(newPerson, IdxPersona);
                    MessageBox.Show($"Informacio de la persona {nom} actualitzada");
                }
            }
            else
            {
                await Domini.AfegirPersonaArray(newPerson, IdxPersona);
                MessageBox.Show($"Informacio de la persona {nom} actualitzada");
            }
        }
    }
}
