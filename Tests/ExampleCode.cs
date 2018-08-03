using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Tests
{
  class ExampleCode //quick reminders of syntax and commonly used methods
  {
    static void Main(string[] args)
    {
      Test tst = new Test();
      tst.exampleCode();
      string sql = "USE OgIFM SELECT *FROM Invoicelineitem";
      string connectionString = "Data Source=FSPHX069;User ID=Noctsol;Password=100Sqltest!";
      SqlConnection cnn = new SqlConnection(connectionString);
      try
      {
        cnn.Open();
        SqlCommand command = new SqlCommand(sql, cnn);
        SqlDataReader dataReader = command.ExecuteReader();
        int n = dataReader.FieldCount;
        while (dataReader.Read())
        {
          string output = "";
          for (int i = 0; i < n; i++)
          {
            string word = Convert.ToString(dataReader[i]);
            if ( word == ""){ word = "NULL"; }
            output += word + "  ";
          }
          Console.WriteLine(output);
        }
        dataReader.Close();
        command.Dispose();
        cnn.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine("Can not open connection ! ");
      }

    }
  }
}       
          


  

