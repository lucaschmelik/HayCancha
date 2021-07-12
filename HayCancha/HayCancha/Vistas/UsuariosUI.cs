using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;
using Microsoft.VisualBasic;

namespace HayCancha
{
    public partial class UsuariosUI : Form, Idiomable
    {
        public UsuariosUI()
        {
            InitializeComponent();
            CargarControles();
            VistaService.DisableControl(btnAgregarPatente);
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }
        
        public int IdiomaControl { get; set; }

        private void CargarControles()
        {
            //DrowDawm
            ddIUsuarios.Items = UsuarioBLL.ObtenerUsuariosNoAdmin().Select(x => x.Nombre).ToArray();
            ddIUsuarios.selectedIndex = 0;

            //Grillas
            var oDtFamilias = PermisoService.ObtenerFamilias();
            var oDtSeleccionadas = PermisoService.ObtenerPatentesPorNombreUsuario(ddIUsuarios.selectedValue);
            VistaService.LoadDatagripView(dgvFamilias, oDtFamilias);
            VistaService.LoadDatagripView(dgvSeleccionadas, oDtSeleccionadas);
            dgvFamilias.Columns["Permiso"].Visible = false;
            dgvSeleccionadas.Columns["Permiso"].Visible = false;
        }

        public void Update()
        {
            ActualizarControles(this.Controls);
        }

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        private void ddIUsuarios_onItemSelected(object sender, EventArgs e)
        {
            var oDtSeleccionadas = PermisoService.ObtenerPatentesPorNombreUsuario(ddIUsuarios.selectedValue);
            
            VistaService.LoadDatagripView(dgvSeleccionadas, oDtSeleccionadas);

            dgvSeleccionadas.Columns["Permiso"].Visible = false;
        }

        private void dgvFamilias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VistaService.EnableControl(btnAgregarPatente);

            var FamiliaSeleccionada = new Familia()
            {
                Nombre = dgvFamilias.SelectedRows[0].Cells[1].Value.ToString(),
                Permiso = int.Parse(dgvFamilias.SelectedRows[0].Cells[0].Value.ToString())
            };

            VistaService.LoadDatagripView(dgvPatentes, PermisoService.ObtenerPatentesPorFamilia(FamiliaSeleccionada));

            dgvPatentes.Columns["Permiso"].Visible = false;
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                var oDrSeleccionada = ((DataRowView) dgvPatentes.SelectedRows[0].DataBoundItem).Row;

                if (VistaService.GetDatatableFromDatagridView(dgvSeleccionadas).AsEnumerable().Any(x => x["Permiso"].ToString() == oDrSeleccionada["Permiso"].ToString())) throw new Exception($"La patente {oDrSeleccionada["PATENTES"]} ya se encuentra asignada a {ddIUsuarios.selectedValue}!!");

                VistaService.AddRowInDataGridView(dgvSeleccionadas, oDrSeleccionada);

                dgvSeleccionadas.Columns["Permiso"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                var oDrSeleccionada = ((DataRowView)dgvFamilias.SelectedRows[0].DataBoundItem).Row;

                if (VistaService.GetDatatableFromDatagridView(dgvSeleccionadas).AsEnumerable().Any(x => x["Permiso"].ToString() == oDrSeleccionada["Permiso"].ToString())) throw new Exception($"La familia {oDrSeleccionada["FAMILIAS"]} ya se encuentra asignada a {ddIUsuarios.selectedValue}!!");

                VistaService.AddRowInDataGridView(dgvSeleccionadas, oDrSeleccionada);

                dgvSeleccionadas.Columns["Permiso"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeleccionadas.RowCount == 1) throw new Exception("No puede eliminar todos los accesos del usuario!!");

                var oDrSeleccionada = ((DataRowView)dgvSeleccionadas.SelectedRows[0].DataBoundItem).Row;

                VistaService.DeleteRowInDataGridView(dgvSeleccionadas, oDrSeleccionada, "Permiso");

                dgvSeleccionadas.Columns["Permiso"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActualizarPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                PermisoService.ActualizarFamilia(ddIUsuarios.selectedValue, VistaService.GetDatatableFromDatagridView(dgvSeleccionadas));

                MessageBox.Show($"Los accesos de {ddIUsuarios.selectedValue} y los usuarios con esta familia fueron actualizados exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                var sNombreFamilia = Interaction.InputBox("Ingrese el nombre de la familia", "NUEVA FAMILIA");

                if(sNombreFamilia == string.Empty) return;

                var iIdNuevaFamilia = PermisoService.CrearFamilia(sNombreFamilia, VistaService.GetDatatableFromDatagridView(dgvSeleccionadas));

                PermisoService.AsignarPermisoUsuario(ddIUsuarios.selectedValue, iIdNuevaFamilia);
                
                MessageBox.Show($"La familia {sNombreFamilia} fue creada y asignada a {ddIUsuarios.selectedValue} exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            VistaService.EnableControl(btnAgregarPatente);
            var oDtPatentes = PermisoService.ObtenerPatentes();
            VistaService.LoadDatagripView(dgvPatentes, oDtPatentes);
            dgvPatentes.Columns["Permiso"].Visible = false;
        }
    }
}
