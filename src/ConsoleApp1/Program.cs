using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    public class Program
    {
        static int j=30;
        private static void Main(string[] args)
        {
            //System.Console.Write("Hello World!");
            //System.Console.Read();

            int x = 1, y = 23, c = 34;
            bool btype = false;//Create a variable that stores ture or false;
            int iTunes = 2;

            MyClass myClass= new MyClass();

            var name = "Bugs Bunny";
            Type nameType = name.GetType();
            Type xType = x.GetType();
            //var k;//必须初始化
            //k = iTunes;
            

            WriteLine($"x:{x},xType:{xType}");

            WriteLine($"name:{name};type:{nameType}");
            WriteLine("Hello World");
            WriteLine("Come on!Baby!");

            int j = 20;
            WriteLine($"j:{j},J:{ConsoleApp1.Program.j}");

            for (int i = 0; i < 10; i++)
            {
                WriteLine($"i:{i}");
            }
            

            while (ie.MoveNext())
            {

            }
            WriteGreeting(TimeOfDay.Morning);

            //foreach (var t in TimeOfDay)
            //{
            //    WriteGreeting(t);
            //}


            foreach (string i in GetInt())
            {
                Console.WriteLine($"{i}");
            }

            WriteLine($"{TimeOfDay.Evening.ToString()}");
            WriteLine(TimeOfDay.Afternoon.ToString());

            TimeOfDay time2 = (TimeOfDay)Enum.Parse(typeof(TimeOfDay), "AfternooN", true);
            WriteLine(time2.ToString());
            ReadKey();
            return;
        }

        public static IEnumerable<string> GetInt()
        {
            for (int i = 3; i >= 0; i--)
            {
               yield return i.ToString();
            }
        }

        static void WriteGreeting(TimeOfDay timeOfDay)
        {
            switch (timeOfDay)
            {
                case TimeOfDay.Morning:
                    WriteLine("Good Morning!");
                    break;
                case TimeOfDay.Afternoon:
                    WriteLine("Good Afternoon!");
                    break;
                case TimeOfDay.Evening:
                    WriteLine("Good Evening!");
                    break;
                default:
                    WriteLine("Hello!");
                    break;
            }
        }
    }

    public enum TimeOfDay
    {
        Morning=0,
        Afternoon=1,
        Evening=2,
    }
}

