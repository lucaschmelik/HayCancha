using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using HayCancha.BE.Abstractas;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.BLL;
using HayCancha.Servicios;
using Microsoft.VisualBasic;

namespace HayCancha
{
    public partial class PermisosUI : Form, Idiomable
    {
        public PermisosUI()
        {
            InitializeComponent();
            CargarControles();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
            _lstPermisos = new List<AbstractComponent>();
        }

        public int IdiomaControl { get; set; }

        private IList<AbstractComponent> _lstPermisos;

        private bool _bEstaCreando;

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

        private void EliminarPermiso(AbstractComponent oPermiso, string sNombrePermisoSeleccionado)
        {
            if (oPermiso.GetType() != typeof(Familia)) return;

            oPermiso.lstHijos.Remove(oPermiso.lstHijos.FirstOrDefault(x => x.Nombre == sNombrePermisoSeleccionado));

            foreach (var permiso in oPermiso.lstHijos)
            {
                EliminarPermiso(permiso, sNombrePermisoSeleccionado);
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

                var oPatente = new Patente()
                {
                    Permiso = int.Parse(oDrSeleccionada["Permiso"].ToString()),
                    Nombre = oDrSeleccionada["PATENTES"].ToString()
                };

                if (PermisoService.TienePermiso(oPatente.Nombre, _lstPermisos)) throw new Exception($"La patente { oPatente.Nombre } ya se encuentra asignada");

                VistaService.DisableControl(btnAsignarPermiso);
                if (!_bEstaCreando) VistaService.EnableControl(btnActualizarPermisos);
                VistaService.EnableControl(btnSacar);

                if (trvPermisos.SelectedNode != null)
                {
                    trvPermisos.SelectedNode.Nodes.Add(oDrSeleccionada["PATENTES"].ToString());
                }
                else
                {
                    trvPermisos.Nodes[0].Nodes.Add(oDrSeleccionada["PATENTES"].ToString());
                }
                
                _lstPermisos.Add(oPatente);
                
                MessageBox.Show($"La patente { oPatente.Nombre } fue asignada exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                var oDrSeleccionada= ((DataRowView) dgvFamilias.SelectedRows[0].DataBoundItem).Row;

                var oFamilia = new Familia()
                {
                    Nombre = oDrSeleccionada["FAMILIAS"].ToString(),
                    Permiso = int.Parse(oDrSeleccionada["Permiso"].ToString())
                };

                if (PermisoService.TienePermiso(oFamilia.Nombre, _lstPermisos)) throw new Exception($"La familia { oFamilia.Nombre } ya se encuentra asignada");

                VistaService.DisableControl(btnAsignarPermiso);
                if(!_bEstaCreando) VistaService.EnableControl(btnActualizarPermisos);
                VistaService.EnableControl(btnSacar);

                PermisoService.ListarPermisos(oFamilia);

                if (trvPermisos.SelectedNode != null)
                {
                    trvPermisos.SelectedNode.Nodes.Add(oFamilia.Nombre);
                    CargarTreedView(oFamilia, trvPermisos.SelectedNode.LastNode);
                }
                else
                {
                    trvPermisos.Nodes[0].Nodes.Add(oFamilia.Nombre);
                    CargarTreedView(oFamilia, trvPermisos.Nodes[0].LastNode);
                }
                
                _lstPermisos.Add(oFamilia);

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
                VistaService.DisableControl(btnAsignarPermiso);
                if (!_bEstaCreando) VistaService.EnableControl(btnActualizarPermisos);

                if (trvPermisos.Nodes.Count == 0) { VistaService.DisableControl(btnSacar); return; }

                if(trvPermisos.SelectedNode == null) throw new Exception("Debe seleccionar un nodo!");
                
                EliminarPermiso(new Familia { lstHijos = _lstPermisos }, trvPermisos.SelectedNode.Text);

                trvPermisos.SelectedNode.Remove();

                if (_lstPermisos.Count == 0) VistaService.DisableControl(btnSacar);
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
                VistaService.EnableControl(btnAsignarPermiso);
                
                PermisoService.ActualizarFamilia(trvPermisos.Nodes[0].Text, PermisoService.FiltrarPermisosRepetidos(_lstPermisos));

                MessageBox.Show($"Los permisos fueron actualizados exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (!_bEstaCreando)
                {
                    _lstPermisos = new List<AbstractComponent>();

                    trvPermisos.Nodes.Clear();

                    trvPermisos.Nodes.Add("Nuevo");

                    btnCrearFamilia.Text = "GUARDAR";

                    _bEstaCreando = true;

                    VistaService.DisableControl(btnActualizarPermisos);
                    VistaService.DisableControl(btnMostrarFamilia);
                    VistaService.DisableControl(btnAsignarPermiso);
                    VistaService.DisableControl(btnActualizarPermisos);
                    VistaService.EnableControl(btnAgregarFamilia);
                    VistaService.EnableControl(btnAgregarPatente);

                    Update();
                }
                else
                {
                    var sNombreFamilia = Interaction.InputBox("Ingrese el nombre de la familia", "NUEVA FAMILIA");

                    btnCrearFamilia.Text = "CREAR";

                    _bEstaCreando = false;

                    VistaService.DisableControl(btnSacar);
                    VistaService.DisableControl(btnAgregarFamilia);
                    VistaService.DisableControl(btnAgregarPatente);
                    VistaService.EnableControl(btnMostrarFamilia);

                    Update();

                    PermisoService.CrearFamilia(sNombreFamilia, _lstPermisos);

                    MessageBox.Show($"La familia {sNombreFamilia} fue creada exitosamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    trvPermisos.Nodes.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMostrarFamilia_Click(object sender, EventArgs e)
        {
            VistaService.DisableControl(btnActualizarPermisos);
            VistaService.EnableControl(btnAgregarPatente);
            VistaService.EnableControl(btnAgregarFamilia);
            VistaService.EnableControl(btnSacar);
            VistaService.EnableControl(btnAsignarPermiso);

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

            foreach (var permisos in _lstPermisos)
            {
                trvPermisos.Nodes[0].Nodes.Add(permisos.Nombre);

                if (permisos.lstHijos != null)
                {
                    CargarTreedView(permisos, trvPermisos.Nodes[0].LastNode);
                }
            }
        }
        
        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                var nombreFamilia = trvPermisos.Nodes[0].Text;

                var nombreUsuario = ddIUsuarios.selectedValue;

                var familiaSeleccionada = VistaService.GetDatatableFromDatagridView(dgvFamilias).AsEnumerable().Where(familia => familia["FAMILIAS"].ToString() == nombreFamilia).FirstOrDefault();

                if (familiaSeleccionada == null) throw new Exception("No se encontró la familia para asignar, fijesé si no se eliminó o modifico desde que puso mostrar");

                PermisoService.AsignarPermisoUsuario(nombreUsuario, int.Parse(familiaSeleccionada["Permiso"].ToString()));

                BitacoraService.Escribir(TipoEventoBitacoraEnum.SISTEMA, $"Se asignó la familia { nombreFamilia } al usuario { nombreUsuario }.");

                MessageBox.Show($"Se asignó la familia { nombreFamilia } al usuario { nombreUsuario } !", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPermisoUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El usuario {ddIUsuarios.selectedValue.ToUpper()} tiene asignada la familia {PermisoService.ObtenerNombreFamiliaPorNombreUsuario(ddIUsuarios.selectedValue).ToUpper()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
