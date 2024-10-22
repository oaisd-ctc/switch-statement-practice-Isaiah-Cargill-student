using System;
public class Program

{
     public static void Main(string[] args)
     {
         Console.WriteLine("enter a number from 1 to 10");
         
         int number = int.Parse  (Console.ReadLine());
         switch (number)
         {
            case 0:

            Console.WriteLine("number is zero");
            break;

            case 1:
            Console.WriteLine("number is one");
            break;
            
              case 2:
            Console.WriteLine("number is two");
            break;

              case 3:
            Console.WriteLine("number is three");
            break;

              case 4:
            Console.WriteLine("number is four");
            break;

              case 5:
            Console.WriteLine("number is five");
            break;
              
              case 6:
            Console.WriteLine("number is six");
            break;

              case 7:
            Console.WriteLine("number is seven");
            break;

              case 8:
            Console.WriteLine("number is eight");
            break;

              case 9:
            Console.WriteLine("number is nine");
            break;

              case 10:
            Console.WriteLine("number is ten");
            break;

            default:
                Console.WriteLine("That number is not in the range");
                break;
         }
     }
}