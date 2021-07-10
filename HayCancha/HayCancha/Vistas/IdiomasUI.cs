using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.Servicios;

namespace HayCancha.Vistas
{
    public partial class IdiomasUI : Form, Idiomable
    {
        public IdiomasUI()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }

        private void IdiomasUI_Load(object sender, EventArgs e)
        {
            dgvIdiomas.DataSource = TraductorService.RetornaTextosTraduciblesPorDefecto().Select(x => new { x.Id, x.Descripcion }).ToArray();
            dgvIdiomas.Columns.Add("Traduccion", "Traducción");
            dgvIdiomas.Columns[0].Width = 50;
            CargarDdIdiomasPersonalizados();
        }

        public int IdiomaControl { get; set; }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        private void lblIngresarIdioma_Click(object sender, EventArgs e)
        {
            lblIngresarIdioma.Visible = false;
            txtIngresarIdioma.Focus();
        }

        public new void Update()
        {
            ActualizarControles(this.Controls);
        }

        private void txtIngresarIdioma_TextChanged(object sender, EventArgs e)
        {
            if (txtIngresarIdioma.Text != "") lblIngresarIdioma.Visible = false;
        }
        
        private void btnRegistrarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                TraductorService.GuardarIdioma(txtIngresarIdioma.Text, VistaService.GetDatatableFromDatagridView(dgvIdiomas));
                ddIdiomasPersonalizados.AddItem(txtIngresarIdioma.Text);
                MessageBox.Show($@"El idioma {txtIngresarIdioma.Text.ToUpper()} se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ddlIdiomasPersonalizados_onItemSelected(object sender, EventArgs e)
        {
            SessionService.Session.Idioma = TraductorService.ObtenerIdIdiomaPorDescripcion(ddIdiomasPersonalizados.selectedValue);
        }

        private void CargarDdIdiomasPersonalizados()
        {
            foreach (var sIdioma in TraductorService.ObtenerIdiomas().AsEnumerable())
            {
                ddIdiomasPersonalizados.AddItem(sIdioma["Descripcion"].ToString());
            }
        }
    }
}
