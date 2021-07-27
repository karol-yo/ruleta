using System;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApp1
{
    public static class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w kasynie!");
            if (User.NumberOfProfiles() == 0)
            {
                Console.WriteLine("nie znaleziono zadnego profilu, musisz stworzyc nowy");
                User.CreateProfile();
            }

            /*if (User.FirstOpen() == "1st")
            {
                Console.WriteLine("zapraszamy po raz pierwszy, " + User.GetName());
            }
            else if (User.FirstOpen() == "not1st")
            {
                Console.WriteLine("zapraszamy ponownie, " + User.GetName());
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("liczba profili wynosi " + User.NumberOfProfiles());*/
        }
    }
}
