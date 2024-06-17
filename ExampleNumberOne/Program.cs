using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleNumberOne
{
    enum ProgramState
    {
        NotLoading = 1,
        IsLoading = 2,
        Loaded = 3,
        None
    }
    enum DaysOfTheWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProgramState state = ProgramState.None;

            //switch (state)
            //{
            //    case ProgramState.NotLoading:
            //        Console.Write("Load a picture");
            //        break;
            //    case ProgramState.IsLoading:
            //        Console.Write("Picture is loading");
            //        break;
            //    case ProgramState.Loaded:
            //        Console.Write("Picture is loaded");
            //        break;
            //    default:
            //        Console.Write("Nothing was chosen");
            //        break;
            //}

            //DaysOfTheWeek currentDay = DaysOfTheWeek.Saturday;

            //switch (currentDay)
            //{
            //    case DaysOfTheWeek.Monday:
            //    case DaysOfTheWeek.Tuesday:
            //    case DaysOfTheWeek.Wednesday:
            //    case DaysOfTheWeek.Thursday:
            //    case DaysOfTheWeek.Friday:
            //        Console.WriteLine("Work");
            //        break;
            //    case DaysOfTheWeek.Saturday:
            //    case DaysOfTheWeek.Sunday:
            //        Console.WriteLine("Weekend");
            //        break;
            //}

            for (int i = 0; i < 6; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
