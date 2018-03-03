using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller myFortune = new FortuneTeller();

            string firstName, lastName, color, vacation, transportation, bankMoney;
            string HELP = "help";
            int age, birthMonth, sibs, yearsToRetire;





            //Writes to console, Getting user input, convert to uppercase
            Console.WriteLine("Hi, What's your first name?");
            //myFortune.QuitProgram();
            firstName = Console.ReadLine().ToUpper();


            //Writes to console, Get user input convert to all upper case
            Console.WriteLine("\nok!, What's your last name?");
            lastName = Console.ReadLine().ToUpper();

            Console.WriteLine("\n" + myFortune.GetName(firstName, lastName));

            //Writes to console, Get user input, convert to an integer, assign to age
            Console.WriteLine("\nCan you tell me your age?");
            age = int.Parse(Console.ReadLine());


            //Writes to console, Gets user input, converts to interger, assigns to birthMonth
            Console.WriteLine("\nok, what month were you born?");
            birthMonth = int.Parse(Console.ReadLine());


            //Writes to the console, gets user input, assign input to color
            Console.WriteLine("\nWhat's your favorite ROYGBIV color?, or type Help to display menu");
            color = Console.ReadLine().ToLower();
            myFortune.Help(color);


            //Writes to the console, gets user input, converts input to integer, assign input to sibs
            Console.WriteLine("\nHow many siblings do you have?");
            sibs = int.Parse(Console.ReadLine());

            yearsToRetire = myFortune.yearToRetire(age);

            vacation = myFortune.GetVacationHome(sibs);

            transportation = myFortune.GetTransportation(color);

            bankMoney = myFortune.GetRetireMoney(birthMonth);




            //Writes to the console followed by a new line
            Console.WriteLine("Processing your fortune now>>>> \n");


            //writes to console, tells user their future using stored user input values
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsToRetire + "yrs with " + bankMoney + " in the bank, \na vaction home in "
                + vacation + " , and a " + transportation + "\n");

            myFortune.GetFortuneQuality();


        }
    }
}
