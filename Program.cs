namespace csharp

{
 class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello world");
        int primeno = primeNumber();
        Console.WriteLine(primeno);

        string myname = printMyName();
        Console.WriteLine(myname);

        sum105();
	}
    
	//  Access modifier, return type, nameofmethod, (){},
	/*
	 return type:
	*/

    static void sum105() {
        Console.WriteLine("The sum of 10 and 15 is " + (10 + 15));
    }
    static int primeNumber() {
        return 3;
    }
	static string printMyName()
	{
		return "My name is majesty";
	}
	
}
}

