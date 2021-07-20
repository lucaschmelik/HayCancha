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
            dgvIdiomas.DataSource = TraductorService.ObtenerTextosTraduciblesPorDefecto().Select(x => new { x.Id, x.Descripcion }).ToArray();
            dgvIdiomas.Columns.Add("Traduccion", "Traducción");
            dgvIdiomas.Columns[0].Width = 50;
            CargarDdIdiomasPersonalizados();
            VistaService.DisableControl(btnActualizarIdioma);
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
                if (TraductorService.ObtenerIdiomas().AsEnumerable().Any(x=>x["Descripcion"].ToString().ToUpper() == txtIngresarIdioma.Text.ToUpper())) throw new Exception("El idioma ingresado ya existe");
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
            try
            {
                VistaService.EnableControl(btnActualizarIdioma);

                var oDtGrilla = VistaService.GetDatatableFromDatagridView(dgvIdiomas);

                var oDtTextosTraducibles = TraductorService.ObtenerTraduccionesPorIdioma(TraductorService.ObtenerIdIdiomaPorDescripcion(ddIdiomasPersonalizados.selectedValue));

                foreach (var textos in oDtTextosTraducibles.AsEnumerable())
                {
                    oDtGrilla.AsEnumerable().FirstOrDefault(x => int.Parse(x["Id"].ToString()) == int.Parse(textos["Texto"].ToString()))["Traduccion"] = textos["Descripcion"];
                }

                dgvIdiomas.Columns.Remove("Traduccion");

                oDtGrilla.Columns["Id"].SetOrdinal(0);
                oDtGrilla.Columns["Descripcion"].SetOrdinal(1);
                oDtGrilla.Columns["Traduccion"].SetOrdinal(2);

                VistaService.LoadDatagripView(dgvIdiomas, oDtGrilla);

                dgvIdiomas.Columns[0].Width = 50;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarDdIdiomasPersonalizados()
        {
            foreach (var sIdioma in TraductorService.ObtenerIdiomas().AsEnumerable())
            {
                ddIdiomasPersonalizados.AddItem(sIdioma["Descripcion"].ToString());
            }
        }

        private void btnActualizarIdioma_Click(object sender, EventArgs e)
        {
            var iIdiomaSeleccionado = TraductorService.ObtenerIdIdiomaPorDescripcion(ddIdiomasPersonalizados.selectedValue);
            TraductorService.ActualizarIdioma(iIdiomaSeleccionado, VistaService.GetDatatableFromDatagridView(dgvIdiomas));

            var sMensaje = SessionService.Session.Idioma != iIdiomaSeleccionado ? 
                $@"El idioma {ddIdiomasPersonalizados.selectedValue.ToUpper()} se actualizó correctamente."
                : $@"El idioma {ddIdiomasPersonalizados.selectedValue.ToUpper()} se actualizó correctamente. Deberá reiniciar cerrar la aplicación para visualizar las modificaciones";

            MessageBox.Show(sMensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imgOk_Click(object sender, EventArgs e)
        {
            SessionService.Session.Idioma = TraductorService.ObtenerIdIdiomaPorDescripcion(ddIdiomasPersonalizados.selectedValue);
        }
    }
}
