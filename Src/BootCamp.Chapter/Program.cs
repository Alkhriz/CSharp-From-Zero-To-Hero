using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Print all the info based on the example message below
             * Read name, surename, age, weight (in kg) and height (in cm) from console.  
             * Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
             * Calculate and print body - mass index(BMI)
             * Do 1 and 2 for another person.*/

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter your weight in kg: ");
            float weight = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter your height in cm: ");
            float height = int.Parse (Console.ReadLine());
            Console.WriteLine(name +" " + lastName + " " + "is " + age + " " + "years old, their weight is " + weight + "kg  and their height is " + height + "cm.");
            Console.WriteLine("Their body mass index is: " + (weight / ((height / 100) * (height / 100))));

            string otherName = "Sam";
            string otherLastName = "Johnson";
            int otherAge = 21;
            float otherWeight = 49f;
            float otherHeight = 152f;
            Console.WriteLine(otherName + " " + otherLastName + " " + "is " + otherAge + " " + "years old, her weight is " + otherWeight + "kg and her height is " + otherHeight + "cm.");
            Console.WriteLine("Sam's BMI is " + otherWeight / ((otherHeight / 100) * (otherHeight / 100)));


        }
    }
}
