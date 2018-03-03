using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class FortuneTeller
    {

        private string firstName, lastName, vacation, transportation, bankMoney;
        private string HELP = "help";
        private int RETIREAGE = 60;
        private bool quit = false;

        public bool Quit
        {
            get { return quit; }
        }

        public FortuneTeller()
        {
            //default constructor
        }

        public FortuneTeller(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string GetName(string first, string last)
        {
            return "Greetings, " + first + " " + last + ". I will tell you your fortune!";

        }

        public int yearToRetire(int age)
        {
            int yearsToRetire;
            if (age % 2 == 0)
            {
                yearsToRetire = RETIREAGE - age;
            }
            else
            {
                yearsToRetire = RETIREAGE - age;
            }
            return yearsToRetire;
        }

        public string GetVacationHome(int sibs)
        {


            //if statement that assigns different vacation values to vacation based on conditions
            if (sibs == 0)
            {

                vacation = "The Virgin islands";
            }

            else if (sibs == 1)
            {
                vacation = "Hawaii";

            }
            else if (sibs == 2)
            {

                vacation = "Cancun Mexico";
            }

            else if (sibs == 3)
            {
                vacation = "Canada";
            }

            else if (sibs > 3)
            {
                vacation = "Sunny California";

            }
            else
                vacation = "your home town";

            return vacation;
        }

        public string GetTransportation(string color)
        {
            //switch statement that assigns transportation types to transportation based on conditions
            switch (color)
            {
                case "red":
                    transportation = "Plane";
                    break;

                case "orange":
                    transportation = "Private Jet";
                    break;

                case "yellow":
                    transportation = "School Bus";
                    break;

                case "green":
                    transportation = "Pruis";
                    break;

                case "blue":
                    transportation = "Plane";
                    break;

                case "indigo":
                    transportation = "Helicopter";
                    break;

                case "violet":
                    transportation = "Train";
                    break;

                default:
                    transportation = "Car";
                    break;
            }
            return transportation;
        }

        public string GetRetireMoney(int birthMonth)
        {
            //if statement that checks expressions to determine the amount of my that gets assigned to bankMoney
            if ((birthMonth >= 1) && (birthMonth <= 4))
            {
                bankMoney = "$10000.00";

            }
            else if ((birthMonth >= 5) && (birthMonth <= 8))
            {
                bankMoney = "$9000.00";
            }
            else if ((birthMonth >= 9) && (birthMonth <= 12))
            {
                bankMoney = "$8000.00";
            }
            else
                bankMoney = "$0.00";

            return bankMoney;
        }

        public void GetFortuneQuality()
        {
            Console.WriteLine("ohh I think that is a good fortune");
        }

       public void Help(string color)
        {
            //if statement that displays help menu when user types help
            if (color == HELP)
            {
                Console.WriteLine("\nROYGBIV represents the colors:\nRed \nOrange \nYellow \nGreen \nBlue \nIndigo \nViolet");
                Console.WriteLine("\nPlease select your favorite color from the menu!");
                color = Console.ReadLine().ToLower();
            }
        }
    }
           
        }

   
