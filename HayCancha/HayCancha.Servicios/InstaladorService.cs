using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace HayCancha.Servicios
{
    public static class InstaladorService
    {
        public static void ComprobarInstalacion()
        {
            switch (VerificarConexion())
            {
                case "OK": return;

                case "Sin BD":
                    CreaBD();
                    CargarDatos();
                    break;

                case "Sin SQL":
                    DescomprimirZip();
                    CreaArchivo();
                    InstalaSQL();
                    CreaBD();
                    CargarDatos();
                    break;
            }
        }

        private static string RetornaNombrePC() => WindowsIdentity.GetCurrent().Name.Split('\\')[0];

        private static string RetornaNombreUsuarioPC()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c whoami";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd().Replace("\r\n", "").Replace(RetornaNombrePC().ToLower(), "").Replace("\\", "");
        }

        private static void InstalaSQL()
        {
            var process = new Process();
            process.StartInfo.WorkingDirectory = $"{Environment.CurrentDirectory}\\SQL";
            process.StartInfo.FileName = "SETUP.EXE";
            process.StartInfo.Arguments = "/ConfigurationFile=ConfigurationFile.ini";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = true;
            process.Start();
            process.WaitForExit();
        }


        private static void DescomprimirZip()
        {
            if (File.Exists($"{Environment.CurrentDirectory}\\SQL\\SETUP.EXE")) return;
            ZipFile.ExtractToDirectory($"{Environment.CurrentDirectory}\\SQL.zip", $"{Environment.CurrentDirectory}");
        }
        

        private static void CreaArchivo()
        {
            var textoArchivo = $";SQL Server 2019 Configuration File\r\n[OPTIONS]\r\n\r\nIACCEPTSQLSERVERLICENSETERMS=\"True\"\r\n\r\n; By specifying this parameter and accepting Microsoft Python Open and Microsoft Python Server terms, you acknowledge that you have read and understood the terms of use. \r\n\r\nIACCEPTPYTHONLICENSETERMS=\"False\"\r\n\r\n; Specifies a Setup work flow, like INSTALL, UNINSTALL, or UPGRADE. This is a required parameter. \r\n\r\nACTION=\"Install\"\r\n\r\n; Setup roles install SQL Server in a predetermined configuration. \r\n\r\nROLE=\"AllFeatures_WithDefaults\"\r\n\r\n; By specifying this parameter and accepting Microsoft R Open and Microsoft R Server terms, you acknowledge that you have read and understood the terms of use. \r\n\r\nIACCEPTROPENLICENSETERMS=\"False\"\r\n\r\n; Specifies that SQL Server Setup should not display the privacy statement when ran from the command line. \r\n\r\nSUPPRESSPRIVACYSTATEMENTNOTICE=\"False\"\r\n\r\n; Use the /ENU parameter to install the English version of SQL Server on your localized Windows operating system. \r\n\r\nENU=\"True\"\r\n\r\n; Setup will not display any user interface. \r\n\r\nQUIET=\"True\"\r\n\r\n; Setup will display progress only, without any user interaction. \r\n\r\nQUIETSIMPLE=\"False\"\r\n\r\n; Parameter that controls the user interface behavior. Valid values are Normal for the full UI,AutoAdvance for a simplied UI, and EnableUIOnServerCore for bypassing Server Core setup GUI block. \r\n\r\n;UIMODE=\"Normal\"\r\n\r\n; Specify whether SQL Server Setup should discover and include product updates. The valid values are True and False or 1 and 0. By default SQL Server Setup will include updates that are found. \r\n\r\nUpdateEnabled=\"False\"\r\n\r\n; If this parameter is provided, then this computer will use Microsoft Update to check for updates. \r\n\r\nUSEMICROSOFTUPDATE=\"False\"\r\n\r\n; Specifies that SQL Server Setup should not display the paid edition notice when ran from the command line. \r\n\r\nSUPPRESSPAIDEDITIONNOTICE=\"False\"\r\n\r\n; Specify the location where SQL Server Setup will obtain product updates. The valid values are \"MU\" to search Microsoft Update, a valid folder path, a relative path such as .\\MyUpdates or a UNC share. By default SQL Server Setup will search Microsoft Update or a Windows Update service through the Window Server Update Services. \r\n\r\nUpdateSource=\"MU\"\r\n\r\n; Specifies features to install, uninstall, or upgrade. The list of top-level features include SQL, AS, IS, MDS, and Tools. The SQL feature will install the Database Engine, Replication, Full-Text, and Data Quality Services (DQS) server. The Tools feature will install shared components. \r\n\r\nFEATURES=SQLENGINE,REPLICATION\r\n\r\n; Displays the command line parameters usage. \r\n\r\nHELP=\"False\"\r\n\r\n; Specifies that the detailed Setup log should be piped to the console. \r\n\r\nINDICATEPROGRESS=\"False\"\r\n\r\n; Specifies that Setup should install into WOW64. This command line argument is not supported on an IA64 or a 32-bit system. \r\n\r\nX86=\"False\"\r\n\r\n; Specify a default or named instance. MSSQLSERVER is the default instance for non-Express editions and SQLExpress for Express editions. This parameter is required when installing the SQL Server Database Engine (SQL), or Analysis Services (AS). \r\n\r\nINSTANCENAME=\"SQLEXPRESS\"\r\n\r\n; Specify the root installation directory for shared components.  This directory remains unchanged after shared components are already installed. \r\n\r\nINSTALLSHAREDDIR=\"C:\\Program Files\\Microsoft SQL Server\"\r\n\r\n; Specify the root installation directory for the WOW64 shared components.  This directory remains unchanged after WOW64 shared components are already installed. \r\n\r\nINSTALLSHAREDWOWDIR=\"C:\\Program Files (x86)\\Microsoft SQL Server\"\r\n\r\n; Specify the Instance ID for the SQL Server features you have specified. SQL Server directory structure, registry structure, and service names will incorporate the instance ID of the SQL Server instance. \r\n\r\nINSTANCEID=\"SQLEXPRESS\"\r\n\r\n; Account for SQL Server CEIP service: Domain\\User or system account. \r\n\r\nSQLTELSVCACCT=\"NT Service\\SQLTELEMETRY$SQLEXPRESS\"\r\n\r\n; Startup type for the SQL Server CEIP service. \r\n\r\nSQLTELSVCSTARTUPTYPE=\"Automatic\"\r\n\r\n; Specify the installation directory. \r\n\r\nINSTANCEDIR=\"C:\\Program Files\\Microsoft SQL Server\"\r\n\r\n; Agent account name \r\n\r\nAGTSVCACCOUNT=\"NT AUTHORITY\\NETWORK SERVICE\"\r\n\r\n; Auto-start service after installation.  \r\n\r\nAGTSVCSTARTUPTYPE=\"Disabled\"\r\n\r\n; CM brick TCP communication port \r\n\r\nCOMMFABRICPORT=\"0\"\r\n\r\n; How matrix will use private networks \r\n\r\nCOMMFABRICNETWORKLEVEL=\"0\"\r\n\r\n; How inter brick communication will be protected \r\n\r\nCOMMFABRICENCRYPTION=\"0\"\r\n\r\n; TCP port used by the CM brick \r\n\r\nMATRIXCMBRICKCOMMPORT=\"0\"\r\n\r\n; Startup type for the SQL Server service. \r\n\r\nSQLSVCSTARTUPTYPE=\"Automatic\"\r\n\r\n; Level to enable FILESTREAM feature at (0, 1, 2 or 3). \r\n\r\nFILESTREAMLEVEL=\"0\"\r\n\r\n; The max degree of parallelism (MAXDOP) server configuration option. \r\n\r\nSQLMAXDOP=\"0\"\r\n\r\n; Set to \"1\" to enable RANU for SQL Server Express. \r\n\r\nENABLERANU=\"True\"\r\n\r\n; Specifies a Windows collation or an SQL collation to use for the Database Engine. \r\n\r\nSQLCOLLATION=\"Modern_Spanish_CI_AS\"\r\n\r\n; Account for SQL Server service: Domain\\User or system account. \r\n\r\nSQLSVCACCOUNT=\"NT Service\\MSSQL$SQLEXPRESS\"\r\n\r\n; Set to \"True\" to enable instant file initialization for SQL Server service. If enabled, Setup will grant Perform Volume Maintenance Task privilege to the Database Engine Service SID. This may lead to information disclosure as it could allow deleted content to be accessed by an unauthorized principal. \r\n\r\nSQLSVCINSTANTFILEINIT=\"False\"\r\n\r\n; Windows account(s) to provision as SQL Server system administrators. \r\n\r\nSQLSYSADMINACCOUNTS=\"{ RetornaNombrePC() }\\{ RetornaNombreUsuarioPC() }\"\r\n\r\n; The number of Database Engine TempDB files. \r\n\r\nSQLTEMPDBFILECOUNT=\"1\"\r\n\r\n; Specifies the initial size of a Database Engine TempDB data file in MB. \r\n\r\nSQLTEMPDBFILESIZE=\"8\"\r\n\r\n; Specifies the automatic growth increment of each Database Engine TempDB data file in MB. \r\n\r\nSQLTEMPDBFILEGROWTH=\"64\"\r\n\r\n; Specifies the initial size of the Database Engine TempDB log file in MB. \r\n\r\nSQLTEMPDBLOGFILESIZE=\"8\"\r\n\r\n; Specifies the automatic growth increment of the Database Engine TempDB log file in MB. \r\n\r\nSQLTEMPDBLOGFILEGROWTH=\"64\"\r\n\r\n; Provision current user as a Database Engine system administrator for SQL Server 2019 Express. \r\n\r\nADDCURRENTUSERASSQLADMIN=\"True\"\r\n\r\n; Specify 0 to disable or 1 to enable the TCP/IP protocol. \r\n\r\nTCPENABLED=\"0\"\r\n\r\n; Specify 0 to disable or 1 to enable the Named Pipes protocol. \r\n\r\nNPENABLED=\"0\"\r\n\r\n; Startup type for Browser Service. \r\n\r\nBROWSERSVCSTARTUPTYPE=\"Automatic\"\r\n\r\n; Use SQLMAXMEMORY to minimize the risk of the OS experiencing detrimental memory pressure. \r\n\r\nSQLMAXMEMORY=\"2147483647\"\r\n\r\n; Use SQLMINMEMORY to reserve a minimum amount of memory available to the SQL Server Memory Manager. \r\n\r\nSQLMINMEMORY=\"0\"";
            var archivo = File.CreateText($"{Environment.CurrentDirectory}\\SQL\\ConfigurationFile.ini");
            archivo.WriteLine(textoArchivo);
            archivo.Flush();
            archivo.Close();
        }

        private static void CreaBD()
        {
            var process = new Process();
            process.StartInfo.FileName = "sqlcmd";
            process.StartInfo.Arguments = $"-S { RetornaNombrePC() }\\SQLEXPRESS -i \"{Environment.CurrentDirectory}\\SQL\\base.sql\" -o \"{Environment.CurrentDirectory}\\SQL\\output.txt\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            Thread.Sleep(2000);
        }

        private static void CargarDatos()
        {
            var process = new Process();
            process.StartInfo.FileName = "sqlcmd";
            process.StartInfo.Arguments = $"-S { RetornaNombrePC() }\\SQLEXPRESS -i \"{Environment.CurrentDirectory}\\SQL\\data.sql\" -o \"{Environment.CurrentDirectory}\\SQL\\outputdata.txt\"";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            Thread.Sleep(3000);
        }

        private static string VerificarConexion()
        {
            try
            {
                var sqlConnection = new SqlConnection($"Data Source={ RetornaNombrePC() }\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;");

                var ejecutaQuery = new SqlCommand("IF DB_ID('HayCancha') IS NOT NULL select 1,2 ELSE select 0", sqlConnection);

                sqlConnection.Open();

                if (ejecutaQuery.ExecuteReader().FieldCount == 1)
                {
                    return "Sin BD";
                }

                sqlConnection.Close();

                return "OK";
            }
            catch (Exception)
            {
                return "Sin SQL";
            }
        }
    }
}
