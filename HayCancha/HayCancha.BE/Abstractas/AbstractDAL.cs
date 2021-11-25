using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;

namespace HayCancha.BE
{
    public abstract class AbstractDAL
    {
        protected DataTable EjecutaStp(string sNombreSTP, Dictionary<string, object> dicParametros, DataTable oDt)
        {
            try
            {
                var connection = new SqlConnection($"Data Source={ RetornaNombrePC() };Initial Catalog=HayCancha;Integrated Security=True");

                connection.Open();

                SqlCommand Command = new SqlCommand(sNombreSTP, connection);

                Command.CommandType = CommandType.StoredProcedure;

                foreach (var kpParametro in dicParametros)
                {
                    Command.Parameters.Add(new SqlParameter($"@{kpParametro.Key}", kpParametro.Value ?? DBNull.Value));
                }

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    var arrObjetos = new object[Reader.FieldCount];

                    Reader.GetValues(arrObjetos);

                    oDt.Rows.Add(arrObjetos);
                }

                connection.Close();

                return oDt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        protected DataTable RetornaDatatableId()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));

            return oDt;
        }

        protected void Restore(string sRuta)
        {
            var Connection = new SqlConnection($"Data Source={ RetornaNombrePC() }\\SQLEXPRESS;Initial Catalog=HayCancha;Integrated Security=True");

            Connection.Open();

            var command = new SqlCommand("ALTER DATABASE [HayCancha] SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE MASTER RESTORE DATABASE [HayCancha] FROM DISK = @ruta WITH REPLACE ALTER DATABASE [HayCancha] SET MULTI_USER", Connection);

            command.Parameters.AddWithValue("ruta", sRuta);

            command.ExecuteNonQuery();

            Connection.Close();
        }

        private string RetornaNombrePC() => WindowsIdentity.GetCurrent().Name.Split('\\')[0];
    }
}
