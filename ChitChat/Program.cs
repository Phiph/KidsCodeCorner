using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChitChat
{
    class Program
    {
        public static Person p = new Person();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello stranger, welcome to Phill's computer!");
            Console.WriteLine("You are new, whats your name?");
            p.Name = Checkline();
            Console.WriteLine($"Hi {p.Name}, what nice name");
            Console.WriteLine("How old are you?");
            p.Age = Checkline();

            Console.WriteLine($"Wow! Just {p.Age} thats cool.");

            Console.WriteLine("");
            Console.WriteLine("Do you like Lego?");
            Console.WriteLine(Checkline() == "yes"
                ? "Well I do too! Hope you have made some today!"
                : "Oh no, I want to go to legoland with you!");

           Checkline();

        }

        public static string Checkline()
        {
            var line = Console.ReadLine();
            if (line == "buzzbee")
            {
                Console.Clear();
                TypeLine("DANGER DANGER NOT FOR DAD");
                TypeLine("Secret agent access accepted");
                TypeLine("Paw Patrol computer connected");
                Console.WriteLine("");
                if (p.Name != null)
                {
                    TypeLine($"Hi {p.Name}");
                }
                Thread.Sleep(15000);
                Environment.Exit(0);
                return "";
            }
            else
            {
            return line;
            }
        }

        static void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(150); // Sleep for 150 milliseconds
            }
            Console.Write(Environment.NewLine);
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public bool LikeLego { get; set; }
    }
}
