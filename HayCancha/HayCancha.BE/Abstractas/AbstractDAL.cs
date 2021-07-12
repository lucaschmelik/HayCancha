using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HayCancha.BE
{
    public abstract class AbstractDAL
    {
        protected DataTable EjecutaStp(string sNombreSTP, Dictionary<string, object> dicParametros, DataTable oDt)
        {
            var Connection = new SqlConnection("Data Source=.;Initial Catalog=HayCancha;Integrated Security=True");

            Connection.Open();

            SqlCommand Command = new SqlCommand(sNombreSTP, Connection);

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

            Connection.Close();

            return oDt;
        }

        protected DataTable RetornaDatatableId()
        {
            var oDt = new DataTable();

            oDt.Columns.Add("Id", typeof(int));

            return oDt;
        }
    }
}
