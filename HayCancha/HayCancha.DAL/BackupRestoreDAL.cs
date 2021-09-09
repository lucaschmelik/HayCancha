using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HayCancha.BE;

namespace HayCancha.DAL
{
    public class BackupRestoreDAL : AbstractDAL
    {
        private static BackupRestoreDAL instancia;
        public static BackupRestoreDAL Instancia => instancia ?? new BackupRestoreDAL();

        public void HacerBackup()
        {
            EjecutaStp("stpDBBackup", new Dictionary<string, object>(), new DataTable());
        }

        public void HacerRestore(string sRuta)
        {
            Restore(sRuta);
        }
    }
}
