using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tests
{

  public class Riot
  {
    public string assets { get; set; }
    public string employees { get; set; }

    void json()
    {
      string response;
      response = System.IO.File.ReadAllText(@"C:\Users\kbui\Desktop\JsonRune.txt");
      Dictionary<string, Object> jsonObj = JsonConvert.DeserializeObject<Dictionary<string, Object>>(response.ToString());
      foreach (KeyValuePair<string, Object> item in jsonObj)
      {
        if (item.Key == "matches")
        {
          List<Dictionary<string, Object>> jsonObj2 = JsonConvert.DeserializeObject<List<Dictionary<string, Object>>>(item.Value.ToString());
          foreach (Dictionary<string, Object> ite in jsonObj2)
          {
            foreach (KeyValuePair<string, Object> it in ite)
              Console.WriteLine(it.Key + "    " + it.Value);
          }
        }
      }
    }
  }
}

