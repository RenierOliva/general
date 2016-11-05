/*
Singleton
Ensure a class has only one instance and provide a global point of access to it.
*/
using System;
 
/// <summary>
/// The 'Singleton' class
/// </summary>
class Singleton
{
	private static Singleton _instance;
	
	// Constructor is 'protected'
	protected Singleton()
	{
	}
	
	public static Singleton Instance()
	{
	  // Uses lazy initialization.
	  // Note: this is not thread safe.
	  if (_instance == null)
	  {
	    _instance = new Singleton();
	  }
	
	  return _instance;
	}
}

class MainClass {
  public static void Main (string[] args) {
  	
      // Constructor is protected -- cannot use new
      Singleton s1 = Singleton.Instance();
      Singleton s2 = Singleton.Instance();
 
      // Test for same instance
      if (s1 == s2)
      {
        Console.WriteLine("Objects are the same instance");
      }
 
      // Wait for user
      Console.ReadKey();
  }
}
