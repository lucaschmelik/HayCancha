using System;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using System.Data;
using System.Linq;
using HayCancha.BE.Interfaces;
using System.Collections;
using HayCancha.Servicios;
using System.Collections.Generic;
using HayCancha.BLL;

namespace HayCancha
{
    public partial class AlquilerEtapaUnoUI : Form, Idiomable
    {
        public AlquilerEtapaUnoUI()
        {
            InitializeComponent();
            _oReserva = new Reserva();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }

        private Reserva _oReserva;
        public int IdiomaControl { get; set; }

        public event EventHandler EventoEnviar;

        private void AlquilerUI_Load(object sender, EventArgs e)
        {
            CargarDropDownList();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCancha.Rows.Count == 0) throw new Exception("Tiene que seleccionar una cancha!");

                var CanchaSeleccionada = ((DataRowView)dgvCancha.SelectedRows[0].DataBoundItem).Row;

                _oReserva.Estadio.Id = int.Parse(CanchaSeleccionada["Id"].ToString());
                _oReserva.Estadio.Nombre = CanchaSeleccionada["ESTADIO"].ToString();
                
                EventoEnviar?.Invoke(_oReserva, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public new void Update()
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

        private void imgBuscarCancha_Click(object sender, EventArgs e)
        {
            _oReserva.FechaInicio = dtpFecha.Value.AddHours(int.Parse(ddHora.selectedValue.Split(' ')[0].Replace("hs", "")));

            _oReserva.Estadio = new Cancha()
            {
                TipoCancha = (TipoCanchaEnum) int.Parse(ddTipoCancha.selectedValue.Last().ToString())
            };

            var lstCanchas = AlquilerBLL.ObtenerCanchasDisponibles(_oReserva.FechaInicio, _oReserva.Estadio.TipoCancha);

            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));
            oDt.Columns.Add("ESTADIO", typeof(string));

            foreach (var cancha in lstCanchas)
            {
                oDt.Rows.Add(cancha.Id, cancha.Nombre.ToUpper());
            }

            VistaService.LoadDatagripView(dgvCancha, oDt);

            dgvCancha.Columns["Id"].Visible = false;
        }

        private void CargarDropDownList()
        {
            foreach (var TipoCancha in Enum.GetValues(typeof(TipoCanchaEnum)))
            {
                ddTipoCancha.AddItem($"Cancha de {(int)TipoCancha}");
            }

            var iHora = 15;
            for (var i = 0; i < 8; i++)
            {
                ddHora.AddItem($"{iHora}hs - {iHora + 1}hs");
                iHora++;
            }

            ddTipoCancha.selectedIndex = 0;
            ddHora.selectedIndex = 0;
        }
    }
}
