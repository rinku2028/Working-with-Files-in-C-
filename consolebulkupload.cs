using System;
using System.Data;
using System.Data.SqlClient;

namespace consolebulkupload
{
    class Program
    {
        String mystr = "Data Source=desktop-tb3r1mj;Initial Catalog=access;Integrated Security=True";
        SqlConnection dataconn = new SqlConnection(mystr);



        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("partnumber");
            dt.Columns.Add("tranparticular");
            dt.Columns.Add("quantity");
            dt.Columns.Add("unitprice");
            dt.Columns.Add("total");
            dt.Columns.Add("orderdate");
            dt.Rows.Add("001");
            dt.Rows.Add("001LABTOP");
            dt.Rows.Add("LABTOP");
            dt.Rows.Add("5");
            dt.Rows.Add("500");
            dt.Rows.Add("2500");
            dt.Rows.Add("12/12/2019");

            using (SqlBulkCopy sqlbulk = new SqlBulkCopy(mystr))
            {
                sqlbulk.DestinationTableName = "accesslog";
                sqlbulk.ColumnMappings.Add("partnumber", "partnumber");
                sqlbulk.ColumnMappings.Add("tranparticular", "tranparticular");
                sqlbulk.ColumnMappings.Add("quantity", "quantity");
                sqlbulk.ColumnMappings.Add("unitprice", "unitprice");
                sqlbulk.ColumnMappings.Add("total", "total");
                sqlbulk.ColumnMappings.Add("orderdate", "orderdate");
                sqlbulk.WriteToServer(dt);
                dataconn.Close();
                Console.WriteLine("Data inserted successfully");
            }
           


        }
    }
}
