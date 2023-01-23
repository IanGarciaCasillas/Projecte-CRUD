using Firebase.Database;
using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Domini;
using Projecte_CRUD.Vistes;

namespace Projecte_CRUD
{
    public partial class Form1 : Form
    {
        public IDomini Domini { get; set; }
        bool esEditable = false;
        bool esEliminable = false;
        bool esLlegible = false;
        public Form1()
        {
            InitializeComponent();
            Domini = new DominiPersona();

            CarregarPersones();
        }


        private void btnNovaPersona_Click(object sender, EventArgs e)
        {
            NovaPersonaForm window = new NovaPersonaForm(Domini);
            window.ShowDialog();
            CarregarPersones();
        }

        private void btnLlegir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            var idx = lstPersones.SelectedIndex;

            string dadesPersona = lstPersones.Items[idx].ToString();

            Domini.EliminarPersona(dadesPersona);

            System.Threading.Thread.Sleep(1000);
            CarregarPersones();
            
        }

        private void lstPersones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var countSelectsList = lstPersones.SelectedItems.Count;

            var idxsSelects = lstPersones.SelectedIndices;

            if (idxsSelects.Count > 1)
            {
                btnElimina.Visible = true;
                btnEditar.Visible = false;
                btnLlegir.Visible = false;
            }
            if (idxsSelects.Count == 1)
            {
                btnElimina.Visible = true;
                btnEditar.Visible   = true;
                btnLlegir.Visible = true;
            }
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            CarregarPersones();
        }
       public async void CarregarPersones()
       {

            lstPersones.Items.Clear();

            var persones = await Domini.ObtenirPersona();

            foreach (var pers in persones)
            {
                //lstPersones.Items.Add($"{pers.Key}:\n\t{pers.Object.ToString()}");
                lstPersones.Items.Add($"{pers.Key}");
            }

       }
    }
}