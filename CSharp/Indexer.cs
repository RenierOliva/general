using System;
using System.Collections.Generic;

class Indexer
{
  private Dictionary<string, int> _colors =
    new Dictionary<string, int>();

  // Indexer
  public int this[string key]
  {
    get { return _colors.ContainsKey(key) ? _colors[key] : 0; }
    set { _colors.Add(key, value); }
  }
}
  
class MainClass {
  public static void Main (string[] args) {
  	Indexer obj = new Indexer();
  	
  	obj["Hello"] = 1;
  	obj["World"] = 2;
  	
  	Console.WriteLine(obj["Hello"]);
  	Console.WriteLine(obj["World"]);
  }
}
