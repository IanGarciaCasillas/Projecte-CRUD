using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Domini;

namespace Projecte_CRUD
{
    public partial class Form1 : Form
    {
        public IDomini Domini { get; set; }

        public Form1()
        {
            InitializeComponent();
            Domini = new DominiPersona();

            CarregarPersones();
        }

       public async void CarregarPersones()
       {

            lstPersones.Items.Clear();

            var persones = await Domini.ObtenirPersona();

            foreach (var pers in persones)
            {
                lstPersones.Items.Add($"{pers.Key}:\n\t{pers.Object.ToString()}");
            }
       }
    }
}