using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lee fecha y devuelve los dias que ha pasado desde esta fecha

            Console.Write("Date: ");
            string previousDateString = Console.ReadLine();

            DateTime previousDate = DateTime.ParseExact(previousDateString, "d/M/yyyy", null);

            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            if (fromPreviousDate.Ticks < 0)
            {
                Console.WriteLine($"{ previousDateString } is { -fromPreviousDate.Days } in the future");
            }
            else
            {
                Console.WriteLine($"It has been { fromPreviousDate.Days } since { previousDateString }");
            }

            
            Console.ReadLine();

            /////////////////////////////////////////////////////

            //Pide hora y devuevle cuanto ha pasado

            Console.WriteLine("Time: ");
            string previousTimeString = Console.ReadLine();

            DateTime previousTime = DateTime.ParseExact(previousTimeString, "H:mm", null);

            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            if (fromPreviousTime.Ticks < 0)
            {
                fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            }

            Console.WriteLine($"{ previousTimeString } era { fromPreviousTime.Hours }  horas y { fromPreviousTime.Minutes } minutos");

            Console.ReadLine();


        }
    }
}
