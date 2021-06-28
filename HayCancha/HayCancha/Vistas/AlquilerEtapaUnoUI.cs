using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HayCancha.BE.Clases;
using HayCancha.BE.Enumerables;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace HayCancha
{
    public partial class AlquilerEtapaUnoUI : Form
    {
        public AlquilerEtapaUnoUI()
        {
            InitializeComponent();
            _oReserva = new Reserva();
        }

        private Reserva _oReserva;
        public IdiomaEnum IdiomaControl { get; set; }

        public event EventHandler EventoEnviar;

        private void AlquilerUI_Load(object sender, EventArgs e)
        {
            foreach (var TipoCancha in Enum.GetValues(typeof(TipoCanchaEnum)))
            {
                ddTipoCancha.AddItem($"Cancha de {(int)TipoCancha}");
            }

            var dt = new DataTable();

            dt.Columns.Add("CANCHA", typeof(string));
            dt.Columns.Add("HORA", typeof(DateTime));

            var rows = new object[]
            {
                "Monumental",
                DateTime.Now
            };

            var rows2 = new object[]
            {
                "Bombonera",
                DateTime.Now
            };

            var rows3 = new object[]
            {
                "Gasometro",
                DateTime.Now
            };

            dt.Rows.Add(rows);
            dt.Rows.Add(rows2);
            dt.Rows.Add(rows3);

            dgvCancha.DataSource = dt;

            ddTipoCancha.selectedIndex = 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            var CanchaSeleccionada = ((DataRowView)dgvCancha.SelectedRows[0].DataBoundItem).Row ;

            _oReserva.Estadio = new Cancha()
            {
                Nombre = CanchaSeleccionada["CANCHA"].ToString(),
            };

            foreach (TipoCanchaEnum item in Enum.GetValues(typeof(TipoCanchaEnum)))
            {
                if ((int) item == int.Parse(ddTipoCancha.selectedValue.Last().ToString())) _oReserva.Estadio.TipoCancha = item;
                break;
            }

            EventoEnviar?.Invoke(_oReserva, e);
        }
    }
}
