using System.Formats.Asn1;
using System.Runtime.ExceptionServices;

internal class Program
{
    private static void Main(string[] args)
    {
        // SayHelloWorld();
        // SayHelloWorld();
        // SayHelloWorld();
        // string newFirstName = "Nodirkhan";
        // string newLastName = "Abdumurotov";

        // SayMyName("Asrorbek", "Abdurashidov");

        // Console.WriteLine(Subtract(a: 100, b: 10));
        // Console.WriteLine(Multiply(m: 87, n: 103));
        // Console.WriteLine(Divide(x: 81, y: 27));

        // double result = Add([5, 10, 15, 20, 25], "Mukhammad");
        // double nextResult = Add("Sevinch",1,2,3,4,5,6,7,8,9,10);

        // Console.WriteLine(result);
        // Console.WriteLine(nextResult);

        // int first = 99;
        // int second = 44;

        // Swap(a: ref first, b: ref second);
        // Console.WriteLine($"first = {first}, second = {second}");

        // int b = 10; // 001
        // int b = 10;
        // ChangeValue(out b);

        // Console.WriteLine(b);

        Console.WriteLine("Raqam kiriting");
        string text = Console.ReadLine();
        
        bool isValidNumber = int.TryParse(text, out int number);

        if(isValidNumber == true)
        {
            Console.WriteLine($"Ha, siz raqam kiritdingiz! {number}");
        }
        else
        {
            Console.WriteLine($"Raqam kiritishing kerak edikuuuuuuuuuuu, {number}");
        }


        // Hello git
    }

    static void ChangeValue(out int a) // 005
    {
        a = 5;
    }

    // static void Swap(ref int a, ref int b)
    // {
    //     int c = a;
    //     a = b;
    //     b = c;

    //     // Console.WriteLine($"a = {a}, b = {b}");
    // }


    // 1 With parameters,  1 reference 

    // static void SayHelloWorld()
    // {
    //     Console.WriteLine("Hello, World!");
    // } 

    // static void SayMyName(string firstName, string lastName, int age = 20)
    // {
    //     Console.WriteLine($"Your name is: {firstName} {lastName}, age = {age}");
    // }

    static double Add(int first, int second, int third) => first + second + third;

    // static double Add(double first, double second) => first + second;

    // static double Add(int[] numbers, string name)
    // {
    //     Console.WriteLine(name);

    //     return numbers.Sum();
    // }

    // static double Add(string name, params int[] numbers)
    // {
    //     Console.WriteLine(name);
    //     return numbers.Sum();
    // }
    
    // static double Subtract(int a, int b) => a - b;

    // static double Multiply(int m, int n) => m * n;

    // static double Divide(int x, int y) => x / y;
}