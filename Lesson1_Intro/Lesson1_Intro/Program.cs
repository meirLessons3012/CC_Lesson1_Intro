using System;

namespace Lesson1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch-case

            //int hour = DateTime.Now.Hour;//19
             //const int hour7 = 7;
             //switch(hour)
             //{
             //    case 0:
             //        Console.WriteLine("24");
             //        break;
             //    case 1:
             //        Console.WriteLine("1");
             //        break;
             //    case 2:
             //        Console.WriteLine("2");
             //        break;
             //    case 3:
             //        Console.WriteLine("3");
             //        break;
             //    case hour7:
             //    case 8:
             //    case 9:
             //    case 10:
             //        Console.WriteLine("morning");
             //        break;
             //    default:
             //    Console.WriteLine("another hour");
             //        break;
             //}
             //if (hour == 0)
             //    Console.WriteLine("24");
             //else if (hour == 1)
             //    Console.WriteLine("1");
             //else if (hour == 2)
             //    Console.WriteLine("2");
             //else if (hour == 3)
             //    Console.WriteLine("3");
             //else if(hour == 7 || hour == 8 || hour == 9)
             //    Console.WriteLine("morning");
             //else
             //    Console.WriteLine("another hour");

            //    Console.WriteLine("after switch...");
            #endregion

            #region Loops

            //while - ביצוע פעולה עד שעומדים בתנאי שהתבקש
            //do-while - חייב לבצע את הפעולה "לפחות" פעם אחת
            //for - מספרריצות מוגדר

            //while
            //int myNum = 0;
            //while (myNum > 0)
            //{
            //    Console.WriteLine("from while: " + myNum);
            //    myNum--;
            //}

            ////do-while
            //int myNum2 = 0;
            //do
            //{
            //    Console.WriteLine("from do-while:" + myNum2);
            //    myNum2--;
            //} while (myNum2 > 0);

            ////for loop
            //for(int i = 0;i < 10;i++)
            //{
            //    Console.WriteLine(i * 2);
            //}

            //for(int myX = 3;myX > 0;myX--)
            //{
            //    Console.WriteLine(myX);
            //}

            //Console.WriteLine("end");
            #endregion

            #region Array
            //type name = value/s 
            //string car = "toyota";
            //int ss = 2;
            //string[] cars = new string[2];
            //string[] cars2 = new string[2] {"mazda", car };
            //string[] cars3 =  {"mazda", car };
            //string[] cars4;
            //cars[0] = "totyta";
            //cars[1] = "suzuki";
            //string firstCar = cars[0];
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //int size = int.Parse(Console.ReadLine());///////  5
            //cars4 = new string[size];
            
            //for(int i = 0; i < cars4.Length;i++)
            //{
            //    string carName = Console.ReadLine();
            //    cars4[i] = carName;
            //    Console.WriteLine(cars[i]);
            //}

            int[] myInts = { 12, 3, 24, 100, 15, 50, 2 };
            Console.WriteLine("before sort: ");
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }
            int indexOf100 = Array.IndexOf(myInts, 100);
            Console.WriteLine($"index of 100: {indexOf100}");
            Console.WriteLine();
            Console.WriteLine();
            Array.Sort(myInts);
            
            Console.WriteLine("after sort: ");
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine(myInts[i]);
            }
            indexOf100 = Array.IndexOf(myInts, 1000);
            Console.WriteLine($"index of 100: {indexOf100}");

            #endregion

            #region Debug

            //לחיצה על מקש פ9 או לחיצה על הקו האפור מימין יוצרת נקודת עצירה באותה שורה
            //לחיצה על מקש פ5 או לחיצה על "המשך" מקפיצה את הקומפיילר לנקודה הבאה או לסיום התכנית
            //לחיצה על מקש פ10\פ11 מתקדמת שורה אחת

            #endregion

            string[,] superArray = new string[3,4];
            superArray[2, 1] = "moshe";
        }
    }
}
