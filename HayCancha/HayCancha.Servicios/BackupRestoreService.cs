using HayCancha.DAL;

namespace HayCancha.Servicios
{
    public class BackupRestoreService
    {
        public static void HacerBackUp()
        {
            BackupRestoreDAL.Instancia.HacerBackup();
        }
        public static void HacerRestore(string sRuta)
        {
            BackupRestoreDAL.Instancia.HacerRestore(sRuta);
        }
    }
}
