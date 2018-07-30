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
		{//print function cause console.writeline is fucking aids
      void print(object arg)
      {
        Console.WriteLine(arg);
        //Console.ReadLine(); only use if outputting to cmd/console window
      }
      //Create a dictionary
      Dictionary<string, string> thing = new Dictionary<string, string>
        {["name"] = "Malphie", ["weight"] = "1", ["color"] = "brown"};

      foreach (KeyValuePair<string, string> attr in thing){ 
        print(attr.Key + " " + attr.Value + " " + attr); } 
       print(thing["name"]);
      print("------------------------------------");


      // Arrays/lists
      List<string> lst = new List<string> {"item1","item2","item3"};
      foreach (string i in lst){
        print(i);
      }
      print(lst[2]);
      print(lst.GetType());


      print("------------------------------------");
      // Array with ints and strings and array inside - not good practice but it is possible
      // also makes retrieving data more annoying - see down below
      List<object> sht = new List<object> { 1, "fudge", lst };
      foreach (object i in sht){
        print(i);
      }


      print("------------------------------------");
      print(sht[2].GetType());
      // accessing the array in the array - 3 methods use are methods to convert the generic object to a list
      // method 1
      List<string> method1 = new List<string>((IEnumerable<string>)sht[2]);
      // method 2
      List<string> method2 = ((IList<string>)sht[2]).Cast<string>().ToList();
      // method 3 - shorter version of method 1 - cast it inside the loop declaration
      IList<string> method3 = sht[2] as IList<string>;
      //method 4 - foreach (string i in (IEnumerable<string>)sht[2])

      foreach (string i in method3){
        print(i);
          }
      print((int)sht[0] + 1);  // even though the actual item is an int, when referring to the lsit, its considered an <object>
     

      print("------------------------------------");
      // much easier if list contains all same item types
      List<List<string>> lst2 = new List<List<string>> {lst, lst, lst};
      foreach (List<string> i in lst2) {
        foreach(string word in i){
          print(word);
        }

      }
    }
  }
}
