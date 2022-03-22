using System;
namespace Composition
{

    public class Program
    {
        static void Main(String[] args)
        {
            Engine e9 = new Engine();
            Car c1 = new Car("BMW" , "Black" , 4 , e9 );
            e9.Type = "Kassem";
            Console.WriteLine(c1.Engine.Type);







        }
    
    
    }



}