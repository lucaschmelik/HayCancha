using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace HayCancha.Servicios
{
    public static class VistaService
    {
        public static void AbrirFormEnPanel(Control oPanel, object oFormhijo)
        {
            if (oPanel.Controls.Count > 0)
                oPanel.Controls.RemoveAt(0);
            var fmHijo = oFormhijo as Form;
            fmHijo.TopLevel = false;
            fmHijo.Dock = DockStyle.Fill;
            oPanel.Controls.Add(fmHijo);
            fmHijo.Show();
        }

        public static DataTable GetDatatableFromDatagridView(DataGridView dataGridView)
        {
            var oDt = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                oDt.Columns.Add(column.Name);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var dRow = oDt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                oDt.Rows.Add(dRow);
            }

            return oDt;
        }

        public static void AddRowInDataGridView(DataGridView dgv, DataRow oDr)
        {
            var oDt = GetDatatableFromDatagridView(dgv).Columns.Count != 0? GetDatatableFromDatagridView(dgv):  oDr.Table.Clone();

            oDt.Rows.Add(oDr.ItemArray.Clone() as object[] ?? throw new Exception("Ocurrió un error al intentar agregar un producto!!"));

            LoadDatagripView(dgv, oDt);
        }

        public static void DeleteRowInDataGridView(DataGridView dgv, DataRow oDr, string sNameColumn = "Id")
        {
            var oDt = GetDatatableFromDatagridView(dgv);

            oDt.AsEnumerable().Where(x => x[sNameColumn].ToString() == oDr[sNameColumn].ToString()).FirstOrDefault().Delete();

            LoadDatagripView(dgv, oDt);
        }

        public static void LoadDatagripView(DataGridView dgv, DataTable table)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DisableControl(Control control)
        {
            control.Enabled = false;
        }

        public static void EnableControl(Control control)
        {
            control.Enabled = true;
        }
    }
}
