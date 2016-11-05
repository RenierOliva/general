/*
Adapter 
*/
using System;

class Target {
	public virtual void Request() {
		Console.WriteLine("Target Request.");
	}
}

class Adapter : Target {
	private Adaptee _adaptee = new Adaptee();
	
	public override void Request() {
		_adaptee.SpecificRequest();
	}
}

class Adaptee {
	public void SpecificRequest() {
		Console.WriteLine("Specific Request.");
	}
}

class MainClass {
  public static void Main (string[] args) {
  	
      Target obj = new Adapter();
      obj.Request();

  }
}
