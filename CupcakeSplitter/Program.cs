using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CupcakeSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How many cupcakes do you have?");
                int cupcakes = 0;
                if (int.TryParse(Console.ReadLine(), out cupcakes))
                {
                    int cupcake = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many people are sharing?");
                    int people = int.Parse(Console.ReadLine());

                    int cupcakesPerPerson = cupcake / people;

                    int remainingCupcakes = cupcake % people;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't split cupcakes with zero people!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number!");
            }
            finally
            {
                Console.WriteLine("Thanks for playing!");
            }   
                Console.WriteLine("Thanks for playing!");
        }
    }
}
          //  Console.WriteLine("Each person gets {0} cupcakes, and there are {1} left over.", cupcakesPerPerson, remainingCupcakes);

        
    //BEST PRACTICES OF EXCEPTION HANDLING
    //Dpn't ignore exceptions
    //If CATCH/FINALLY left empty will not run program correctly
    //Use exception handling in websites so not all information is seen by users
    //Avoid go/to...makes it too hard for other programmers to follow code - makes programs more confusing
    //stick to idioms (expressions that are common
    //Can use finally without a catch
    //inside an exception, we can rethrow...can say throw; after Writeline, send exception to the next level up
    //they work from lowest level in code to highest level in your code
    //construct an object (classes) and handle the error - they are actually classes
    //they all take a parameter(message that tells the user what they need to do in order for the program to run)
    //only use when you cant return something
    //can make exceptions out of classes in the program (Catch Cupcake Exception)
    
    
    //THROW NEW EXCEPTION
    //
    //

