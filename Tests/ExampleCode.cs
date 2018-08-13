using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Reflection;

namespace Tests
{
  class ExampleCode //quick reminders of syntax and commonly used methods
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> D = new Dictionary<string, string> { { "assets", "Billion" }, { "employees", "World" },{ "location","California"} };
      PropertyInfo[] properties = typeof(Riot).GetProperties();

      Riot temp = new Riot();
      foreach (PropertyInfo c in properties)
      {
        string nme = c.Name;
        if (D.ContainsKey(nme))
        {
          var tempType = typeof(Riot);
          tempType.GetProperty(nme).SetValue(temp, D[nme]);
        }
      }
      Console.WriteLine(temp.assets);
      Console.WriteLine(temp.employees);
      Console.WriteLine(temp.location);





    }
  }
}       
          


  

