using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tests
{
  class ExampleCode
  {
    static void Main(string[] args)
		 { //print function cause console.writeline is fucking aids
      void print(object arg)
      {
        Console.WriteLine(arg);
        //Console.ReadLine(); only use if outputting to cmd/console window
      }
      //Dictionary type
      Dictionary<string, string> thing = new Dictionary<string, string>
        {["name"] = "Malphie", ["weight"] = "1", ["color"] = "brown"};

      foreach (KeyValuePair<string, string> attr in thing){ 
        print(attr.Key + " " + attr.Value + " " + attr); } 
       print(thing["name"]);
      
      // Arrays and lists
      List<string> lst = new List<string> {"item1","item2","item3" };
      foreach (string i in lst){
        print(i);
      }
      // Array with ints and strings - not good practice

      

      
    }
  }
}
