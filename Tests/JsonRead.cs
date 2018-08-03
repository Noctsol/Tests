using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tests
{
  class JsonRead
  {
    void findData(Dictionary<string, Object> dict)
    {

      foreach (KeyValuePair<string, Object> item in dict)
      {
        //Console.WriteLine(item.Value.GetType().ToString() +"   "+item.Key+ "      "+ dict[item.Key]);

        if (item.Value.GetType() != typeof(Newtonsoft.Json.Linq.JObject))
        {
          continue;
        }
        Console.WriteLine(item.Value.GetType().ToString() + "   " + item.Key + "      " + dict[item.Key]);
        Dictionary<string, Object> list = JsonConvert.DeserializeObject<Dictionary<string, Object>>(item.Value.ToString());
        Console.WriteLine("--------------------");
        findData(list);
      }
    }
  }
}
