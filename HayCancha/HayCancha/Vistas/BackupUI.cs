using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HayCancha.BE.Enumerables;
using HayCancha.BE.Interfaces;
using HayCancha.Servicios;
using Microsoft.VisualBasic;

namespace HayCancha.Vistas
{
    public partial class BackupUI : Form, Idiomable
    {
        public BackupUI()
        {
            InitializeComponent();
            SessionService.Session.Suscribir(this);
            if (IdiomaControl != SessionService.Session.Idioma) Update();
        }
        public int IdiomaControl { get; set; }

        private const string RutaBackups = @"C:\temp";

        public void ActualizarControles(IEnumerable Coleccion)
        {
            foreach (var oComponente in Coleccion)
            {
                ((Control)oComponente).Text = TraductorService.RetornaTraduccion(((Control)oComponente).Text) ?? ((Control)oComponente).Text;
            }
        }

        public new void Update()
        {
            ActualizarControles(this.Controls);
        }

        private void BackupUI_Load(object sender, System.EventArgs e)
        {
            CargarBackups();
        }

        private void CargarBackups()
        {
            dgvBackup.Rows.Clear();

            if (!Directory.Exists(RutaBackups))
            {
                Directory.CreateDirectory(RutaBackups);
            }

            Directory.GetFiles(RutaBackups, "*.bak").ToList().ForEach(x=> dgvBackup.Rows.Add(x.Remove(0,8).Replace(".bak", "").ToUpper(), x));
        }

        private void btnBackup_Click(object sender, System.EventArgs e)
        {
            BitacoraService.Escribir(TipoEventoBitacoraEnum.SISTEMA, "Se realizó backup de la base de datos.");
            BackupRestoreService.HacerBackUp();
            CargarBackups();
            MessageBox.Show("El backup se realizó correctamente!", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            if(Interaction.MsgBox("Luego de ejecutar el restore se cerrará la sesión. ¿Desea continuar?", MsgBoxStyle.OkCancel ,"Restore") == MsgBoxResult.Cancel) return;

            BitacoraService.EscribirArchivo();

            BackupRestoreService.HacerRestore(dgvBackup.SelectedRows[0].Cells[1].Value.ToString());

            BitacoraService.EscribirRestore();

            ((MenuUI) Parent.Parent).CerrarSesion();
            Close();
        }
    }
}
