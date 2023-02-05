using Firebase.Database;
using Projecte_CRUD.Dades.Model;
using Projecte_CRUD.Domini;
using Projecte_CRUD.Vistes;

namespace Projecte_CRUD
{
    public partial class Form1 : Form
    {
        public IDomini Domini { get; set; }
        
        public Form1()
        {
            InitializeComponent();
            Domini = new DominiPersona();
            this.btnActualitzar.Visible = false;
            CarregarPersones();
            CarregarPersonesArray();
        }
        #region PERSONES OBJECT
        private void btnNovaPersona_Click(object sender, EventArgs e)
        {
            NovaPersonaForm window = new NovaPersonaForm(Domini);
            window.ShowDialog();
            CarregarPersones();
        }
        private async void btnLlegir_Click(object sender, EventArgs e)
        {
            var idx = lstPersones.SelectedIndex;
            string dadesPersona = lstPersones.Items[idx].ToString();
            //UnaPersona(dadesPersona);
            var result = await Domini.ObtenirUnaPersona(dadesPersona);
            var person = result.First();
            InfoPersonaForm window = new InfoPersonaForm(person, Domini);
            window.ShowDialog();
            CarregarPersones();
        }
        private void btnElimina_Click(object sender, EventArgs e)
        {
            foreach(var idx in lstPersones.SelectedIndices)
            {
                string dadesPersona = lstPersones.Items[Convert.ToInt32(idx.ToString())].ToString();
                var resultUser = MessageBox.Show($"Segur que vols eliminar la persona {dadesPersona}", "Eliminar persona", MessageBoxButtons.OKCancel);
                if (resultUser == DialogResult.OK)
                {
                    Domini.EliminarPersona(dadesPersona);
                    MessageBox.Show($"S'ha eliminat la persona {dadesPersona}");
                }
                //var nada = $"Eliminara el item {dadesPersona}";
            }
            /*
            var idx = lstPersones.SelectedIndex;
            string dadesPersona = lstPersones.Items[idx].ToString();
            Domini.EliminarPersona(dadesPersona);
            */
            System.Threading.Thread.Sleep(1000);
            CarregarPersones();
        }
        private void lstPersones_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idxsSelects = lstPersones.SelectedIndices;

            if (idxsSelects.Count > 1)
            {
                btnElimina.Visible = true;
                btnLlegir.Visible = false;
            }
            if (idxsSelects.Count == 1)
            {
                btnElimina.Visible = true;
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
        #endregion

        #region PERSONES ARRAY
        private async void CarregarPersonesArray()
        {
            lstPersonesArray.Items.Clear();
            var personesArray = await Domini.ObtenirPersonesArray();

            var listOrder = personesArray.OrderBy(l=>l.Object.Nombre).ToList();

            foreach(var persArray in listOrder)
            {
                lstPersonesArray.Items.Add(persArray.Object.Nombre);
            }
        }
        private void lstPersonesArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idxsSelects = lstPersonesArray.SelectedIndices;
            
            if (idxsSelects.Count > 1)
            {
                btnEliminarPersonaArray.Visible = true;
                btnLlegirPersonaArray.Visible = false;
            }
            if (idxsSelects.Count == 1)
            {
                btnEliminarPersonaArray.Visible = true;
                btnLlegirPersonaArray.Visible = true;
            }            
        }
        private async void btnEliminarPersonaArray_Click(object sender, EventArgs e)
        {
            foreach(var idx in lstPersonesArray.SelectedIndices)
            {
                string dadesPersones = lstPersonesArray.Items[Convert.ToInt32(idx.ToString())].ToString();
                var resultUser = MessageBox.Show($"Segur que vols eliminar la persona {dadesPersones}","Eliminar persona",MessageBoxButtons.OKCancel);
                if(resultUser == DialogResult.OK)
                {
                    string result = await Domini.ObtenirIdxPersona(dadesPersones);
                    await Domini.EliminarPersonaArray(result);
                    MessageBox.Show($"S'ha eliminat la persona {dadesPersones}");
                    //System.Threading.Thread.Sleep(1000);
                    CarregarPersonesArray();
                }
            }
        }

        private async void btnLlegirPersonaArray_Click(object sender, EventArgs e)
        {
            var idx = lstPersonesArray.SelectedIndex;
            string dadesPersona = lstPersonesArray.Items[idx].ToString();
            string idxArray = await Domini.ObtenirIdxPersona(dadesPersona);
            PersonaArray personaSelect = await Domini.ObtenirUnaPersonaArray(idxArray);

            InfoPersonaArrayForm window = new InfoPersonaArrayForm(personaSelect,idxArray,Domini);
            window.ShowDialog();
            CarregarPersonesArray();
        }

        private void btnCrearPersonaArray_Click(object sender, EventArgs e)
        {
            NovaPersonaArrayForm window = new NovaPersonaArrayForm(Domini);
            window.ShowDialog();
            CarregarPersonesArray();
        }
        #endregion
    }
}