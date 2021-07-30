﻿using System;
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
using HayCancha.BE.Abstractas;
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
            _lstPermisos = new List<AbstractComponent>();
        }
        
        public int IdiomaControl { get; set; }

        private IList<AbstractComponent> _lstPermisos;

        private void CargarControles()
        {
            //DrowDawm
            ddIUsuarios.Items = UsuarioBLL.ObtenerUsuariosNoAdmin().Select(x => x.Nombre).ToArray();
            ddIUsuarios.selectedIndex = 0;

            //Grillas
            VistaService.LoadDatagripView(dgvFamilias, PermisoService.ObtenerFamilias());
            VistaService.LoadDatagripView(dgvPatentes, PermisoService.ObtenerPatentes());
            dgvPatentes.Columns["Permiso"].Visible = dgvFamilias.Columns["Permiso"].Visible = false;

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

        private void CargarTreedView(AbstractComponent oComponent, TreeNode trnNodo)
        {
            var iPosicionNodo = 0;

            foreach (var hijoComponent in oComponent.lstHijos)
            {
                trnNodo.Nodes.Add(hijoComponent.Nombre);

                if (hijoComponent.GetType() == typeof(Familia)) { CargarTreedView(hijoComponent, trnNodo.Nodes[iPosicionNodo]);}

                iPosicionNodo++;
            }
        }

        private void ddIUsuarios_onItemSelected(object sender, EventArgs e)
        {
            var oDtSeleccionadas = PermisoService.ObtenerPatentesPorNombreUsuario(ddIUsuarios.selectedValue);
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                var oDrSeleccionada = ((DataRowView) dgvPatentes.SelectedRows[0].DataBoundItem).Row;

                if (PermisoService.TienePermiso(oDrSeleccionada["PATENTES"].ToString(), _lstPermisos)) throw new Exception($"La patente { oDrSeleccionada["PATENTES"] } ya se encuentra asignada");

                if (trvPermisos.SelectedNode != null)
                {
                    trvPermisos.SelectedNode.Nodes.Add(oDrSeleccionada["PATENTES"].ToString());
                }
                else
                {
                    trvPermisos.Nodes[0].Nodes.Add(oDrSeleccionada["PATENTES"].ToString());
                }
                _lstPermisos.FirstOrDefault().lstHijos.Add(new Patente() { Permiso = int.Parse(oDrSeleccionada["Permiso"].ToString()), Nombre = oDrSeleccionada["PATENTES"].ToString() });
                MessageBox.Show($"La patente {oDrSeleccionada["PATENTES"]} fue asignada exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                var oDrSeleccionada= ((DataRowView) dgvPatentes.SelectedRows[0].DataBoundItem).Row;

                var oFamilia = new Familia()
                {
                    Nombre = oDrSeleccionada["PATENTES"].ToString(),
                    Permiso = int.Parse(oDrSeleccionada["Permiso"].ToString())
                };

                if (PermisoService.TienePermiso(oFamilia.Nombre, _lstPermisos)) throw new Exception($"La familia { oFamilia.Nombre } ya se encuentra asignada");

                if (trvPermisos.SelectedNode != null)
                {
                    trvPermisos.SelectedNode.Nodes.Add(oFamilia.Nombre);
                }
                else
                {
                    trvPermisos.Nodes[0].Nodes.Add(oFamilia.Nombre);
                }
                
                _lstPermisos.FirstOrDefault(x => x.Nombre == trvPermisos.SelectedNode.Text)?.lstHijos.Add(oFamilia);

                MessageBox.Show($"La familia { oFamilia.Nombre } fue asignada exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //if (dgvSeleccionadas.RowCount == 1) throw new Exception("No puede eliminar todos los accesos del usuario!!");

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
                //PermisoService.ActualizarFamilia(ddIUsuarios.selectedValue, VistaService.GetDatatableFromDatagridView(dgvSeleccionadas));

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

                //var iIdNuevaFamilia = PermisoService.CrearFamilia(sNombreFamilia, VistaService.GetDatatableFromDatagridView(dgvSeleccionadas));

                //PermisoService.AsignarPermisoUsuario(ddIUsuarios.selectedValue, iIdNuevaFamilia);
                
                MessageBox.Show($"La familia {sNombreFamilia} fue creada y asignada a {ddIUsuarios.selectedValue} exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMostrarFamilia_Click(object sender, EventArgs e)
        {
            VistaService.EnableControl(btnAgregarPatente);

            var oDrSeleccionada = ((DataRowView)dgvFamilias.SelectedRows[0].DataBoundItem).Row;

            var oFamiliaSeleccioanda = new Familia() { Permiso = int.Parse(oDrSeleccionada["Permiso"].ToString()), Nombre = (oDrSeleccionada["FAMILIAS"].ToString()) };

            PermisoService.ListarPermisos(oFamiliaSeleccioanda);

            _lstPermisos = oFamiliaSeleccioanda.lstHijos;

            AgregarNodoTreedView(oFamiliaSeleccioanda.Nombre);
        }

        private void AgregarNodoTreedView(string nodo)
        {
            trvPermisos.Nodes.Clear();

            trvPermisos.Nodes.Add(nodo);

            CargarTreedView(_lstPermisos.FirstOrDefault(), trvPermisos.Nodes[0]);
        }
    }
}
