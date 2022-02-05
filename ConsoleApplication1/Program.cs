using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var datTimeNow = DateTime.Now.TimeOfDay;
            ////DateTime datTimeNow = DateTime.Now.TimeOfDay;
            //Console.WriteLine(datTimeNow);
            //Console.ReadLine();

            //var a = 5;
            //var b = 1;
            //Debug.Assert(b != 0, "b cannot be equal to zero.");
            //var result = a / b;
            //Console.WriteLine(result);
            //Console.ReadLine();

            //var someNumber = 333.5;
            //someNumber = Math.Log(3);
            //someNumber *= Math.PI;

            //// string
            //var strString = "string";
            //var strStringNumber = "12345";

            ////character
            //var chrCharacter = 'c';

            ////decimal
            //var decDecimal = 33.55m;

            ////double
            //var dblDouble = 4d;

            ////float
            //var fltFloat = 5f;

            ////integet
            //var intInteger = 3;

            ////long Integer
            //var lngLong = 12345678901234567890;

            //var strStringDate = "Feb 28, 1968";

            //Console.WriteLine(lngLong.ToString());
            //int.Parse(strStringNumber);
            //DateTime.Parse(strStringDate);

            //var num1 = Console.ReadLine();
            //var num2 = Console.ReadLine();
            //var default1 = 0;
            //var default2 = 0;
            //var number1 = int.TryParse(num1, out default1);
            //var number2 = int.TryParse(num2, out default2);

            //if (number1 && number2)
            //{
            //    Console.WriteLine(num1 + " + " + num2 + " = " + num1 + num2);
            //    Console.ReadLine();
            //}
            //else {
            //    Console.Write("Not numbers.");
            //    Console.ReadLine();
            //}

            //Console.WriteLine("Enter a date: ");
            //var strDate = Console.ReadLine();
            //var datDate = DateTime.Parse(strDate);
            ////var strLongDate = datDate.ToLongDateString();

            //var strLongDate = datDate.ToString("D");

            //Console.WriteLine("Here it is in long date format: " + strLongDate);
            //Console.ReadLine();

            //string strEmail;
            //string strEmailRegEx = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
            //Console.Write("Please enter your email address:");
            //strEmail = Console.ReadLine();

            //// Validate the email address
            //if (!Regex.IsMatch(strEmail, strEmailRegEx))
            //{
            //    Console.WriteLine("Invalid email address!");
            //}
            //else {
            //    Console.WriteLine("Good email address!");
            //}

            //Console.ReadLine();

            //var aryDisasterHeadlines = new string[3];
            //aryDisasterHeadlines[0] = "Moon explodes!!!";
            //aryDisasterHeadlines[1] = "California falls into the sea!!!";
            //aryDisasterHeadlines[2] = "Hillary wins!!!";

            //Random rndRandom = new Random();
            //int intRandomNumber = rndRandom.Next(0, 3);
            //Console.Write(aryDisasterHeadlines[intRandomNumber]);
            //Console.ReadLine();

            //// ask question
            //Console.WriteLine("Is it morning?");
            //var response = Console.ReadLine();

            //// write response
            //var message = response.ToLower().Trim() == "yes" ? "Good morning!" : "Good day!";
            //Console.WriteLine(message);
            //Console.ReadLine();

            //var dayOfWeek = DateTime.Now.DayOfWeek;

            //var dinner = "";
            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        dinner = "Steak";
            //        break;
            //    case DayOfWeek.Tuesday:
            //        dinner = "Chicken";
            //        break;
            //    case DayOfWeek.Wednesday:
            //        dinner = "Soup";
            //        break;
            //    default:
            //        dinner = "Ramon";
            //        break;
            //}

            //Console.WriteLine("Today we are eating " + dinner);
            //Console.ReadLine();

            //public doSomething()
            //{

            //}

            //var aryDisasterHeadlines = new string[3];
            //    aryDisasterHeadlines[0] = "Moon explodes!!!";
            //    aryDisasterHeadlines[1] = "California falls into the sea!!!";
            //    aryDisasterHeadlines[2] = "Hillary wins!!!";

            //    Random rndRandom = new Random();
            //    int intRandomNumber = rndRandom.Next(0, 2);

            //    switch (intRandomNumber) {
            //        case 0:
            //            Console.Write(aryDisasterHeadlines[0]);
            //            break;
            //        case 1:
            //            Console.Write(aryDisasterHeadlines[1]);
            //            break;
            //        case 2:
            //            Console.Write(aryDisasterHeadlines[2]);
            //            break;
            //        default:
            //            Console.Write("Houston, we have a problem.");
            //            break;

            //    }

            //var aryColors = new string[3];
            //aryColors[0] = "Red";
            //aryColors[1] = "Green";
            //aryColors[2] = "Blue";

            //foreach (var color in aryColors)
            //{
            //    Console.WriteLine(color);
            //}

            //for (var v = 0; v < aryColors.Length; v++)
            //{
            //    Console.WriteLine(aryColors[v]);
            //}

            //var i = 0;
            //while (i < aryColors.Length)
            //{
            //    Console.WriteLine(aryColors[i]);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("Do you want some nachos.");
            //} while (Console.ReadLine().ToLower().Trim() == "yes");

            for (var v = 0; v < 100; v++)
            {
                if (v % 7 == 0) {
                    Console.WriteLine(v);
                }
                
            }

            Console.ReadLine();

            //string strGoAgain;
            //Console.WriteLine("Go again (y/n) ?");
            //strGoAgain = Console.ReadLine();

            //if (strGoAgain == "y") {
            //    Main();
            //}

        }

        /// <summary>
        /// Yippee this words!!
        /// </summary>
        public static void doSomething()
        {

        }


    }
}
