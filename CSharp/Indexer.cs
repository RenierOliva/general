using System;
using System.Collections.Generic;

class Indexer
{
  private Dictionary<string, int> _colors =
    new Dictionary<string, int>();

  // Indexer
  public int this[string key]
  {
    get { return _colors.ContainsKey(key) ? _colors[key] : -1; }
    set { _colors.Add(key, value); }
  }
}
  
class MainClass {
  public static void Main (string[] args) {
  	Indexer obj = new Indexer();
  	
  	obj["white"] = 1;
  	obj["blue"] = 2;
  	
  	Console.WriteLine(obj["white"]); // 1
  	Console.WriteLine(obj["blue"]); // 2
    Console.WriteLine(obj["green"]); // -1
  }
}
