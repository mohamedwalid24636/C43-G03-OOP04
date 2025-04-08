using C__OOP_Assignment_04;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Q4
        //Employee e1 = new Employee();
        //e1.method();

        //Employee e2 = new Manager();
        //e2.method();
        #endregion
        #region Q5
        //baseclass b1 = new baseclass();
        //b1.DisplayMessage();
        //baseclass b2 = new DerivedClass1();
        //b2.DisplayMessage();
        //baseclass b3 = new DerivedClass2();
        //b3.DisplayMessage();

        //DerivedClass2 b4 = new DerivedClass2();
        //b4.DisplayMessage();
        #endregion

        // PART 02 
        Console.WriteLine("hello");

        TIME T1 = new TIME(2,50,60);
        Console.WriteLine(T1);
        TIME T2 = new TIME(666); // h = 0 ,  m = 11 , s = 6 ;
        Console.WriteLine(T2);

        Console.WriteLine(T1 + T2);


        Console.WriteLine(T1>T2);

    }
}