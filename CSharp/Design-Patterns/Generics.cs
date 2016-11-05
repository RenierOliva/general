/*
Example of Generics
*/

using System;

class Compare<T> {
	public bool Check(T p1, T p2) {
		if (p1.Equals(p2)) {
			return true;
		}
		return false;
	}
}

class MainClass {
	public static void Main (string[] args) {

		Compare<int> obj1 = new Compare<int>();
		Console.WriteLine(String.Format("is {0} equal to {1}? {2}", 1, 2, obj1.Check(1, 2)) );
		Console.WriteLine(String.Format("is {0} equal to {1}? {2}", 3, 3, obj1.Check(3, 3)) );

		Compare<string> obj2 = new Compare<string>();
		Console.WriteLine(String.Format("is '{0}' equal to '{1}'? {2}", "hello", "world", obj2.Check("hello", "world") ));
		Console.WriteLine(String.Format("is '{0}' equal to '{1}'? {2}", "hi", "hi", obj2.Check("hi", "hi")) );
	}
}
