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
      Dictionary<string, string> D = new Dictionary<string, string> { { "assets", "Hello" }, { "employees", "World" } };

      List<Riot> lRiot = new List<Riot>();
      Riot shit = new Riot();

      shit.assets = "hbfgigbb";
      shit.employees = "hello";
      Console.WriteLine(shit.assets);
      Console.WriteLine(D["assets"]);
      PropertyInfo[] properties = typeof(Riot).GetProperties();

      foreach (KeyValuePair<string, string> item in D)
      {
        Console.WriteLine(1);
        foreach (PropertyInfo c in properties)
        {
          Riot temp = new Riot();
          string nme = c.Name;
          Console.WriteLine(nme + "------------------");
          if (item.Key == nme)
          {
            Console.WriteLine(item.Key + "FOUND YOU COCKSUKE");
            var tempType = typeof(Riot);
            tempType.GetProperty(nme).SetValue(temp, item.Value);
            Console.WriteLine(temp.assets + "    heellloooooowdgui");
          }
          lRiot.Add(temp);
        }
      }

      foreach(Riot i in lRiot)
      {
        Console.WriteLine(i);
      }

    }
  }
}       
          


  

