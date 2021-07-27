using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace ConsoleApp1
{
    public class User
    {
        public int Balance  { get; set; }
        public string Name  { get; set; }
        public static int NumberOfProfiles()
        {
            string path = Directory.GetCurrentDirectory();
            int amountPlusOne = 1;
            while (true)
            {
                if (File.Exists(path + @"user"+ amountPlusOne + ".json") == true)
                {
                    amountPlusOne += 1;
                }
                else
                {
                    break;
                }
            }
            return amountPlusOne - 1;
        }
        public static void CreateProfile()
        {
            Console.WriteLine("podaj nazwe profilu ");
            string nickName = Console.ReadLine();
            User user = new()
            {
                Name = nickName,
                Balance = 1000
            };
            string userSerialized = JsonConvert.SerializeObject(user);
            string path = Directory.GetCurrentDirectory();
            File.WriteAllText(path + @"user" + NumberOfProfiles() + ".json", userSerialized);
        }
        /*public static string FirstOpen()
        {
            string path = Directory.GetCurrentDirectory();
            if (File.Exists(path + @"user1.json") == true)
            {
                return "not1st";
            }
            else
            {
                Console.WriteLine("podaj nazwe ");                                             PROTOTYP KREACJI PROFILU
                string nickName = Console.ReadLine();
                User user = new()
                {
                    Name = nickName,
                    Balance = 1000
                };
                string userSerialized = JsonConvert.SerializeObject(user);
                File.WriteAllText(path + @"user1.json", userSerialized);
                return "1st";
            }
        }*/
        public static string GetName(int whichOne)
        {
            string path = Directory.GetCurrentDirectory();
            string userSerialized = File.ReadAllText(path + @"user" + whichOne + ".json");
            User userDeserialized = JsonConvert.DeserializeObject<User>(userSerialized);
            return userDeserialized.Name;
        }
        public static int GetBalance(int whichOne)
        {
            string path = Directory.GetCurrentDirectory();
            string userSerialized = File.ReadAllText(path + @"user" + whichOne + ".json");
            User userDeserialized = JsonConvert.DeserializeObject<User>(userSerialized);
            return userDeserialized.Balance;
        }
        public static string ListOfProfiles()                   //TO WLASNIE TERAZ PISZE
        {

        }
        /*public static int Choice()                                                TUTAJ JAKIS SYF CO GO NIE POWINNO BYC W TEJ KLASIE
        {                                                                              TEZ PROTOTYPY CHYBA JAKIES W MIARE TAKIE
            var choice = Console.ReadLine();
            bool intTest = int.TryParse(choice, out int number);
            if (intTest == true & number > 0 & number < 37)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }
        public static string TypeOfBet()
        {
            Console.WriteLine("[1] zero \n[2] parzyste\n[3] nieparzyste\n[4] konkretny numer\n[5] pierwsza polowa\n[6] druga polowa");
            var choice = Console.ReadLine();
            bool intTest = int.TryParse(choice, out int number);
            if (intTest == true)
            {
                switch (Convert.ToInt32(choice))
                {
                    case 1:
                        return "zero";
                    case 2:
                        return "parzyste";
                    case 3:
                        return "nieparzyste";
                    case 4:
                        return "konk";
                    case 5:
                        return "1sthalf";
                    case 6:
                        return "2ndhalf";
                    default:
                        return "error";

                }
            }
            else
            {
                return "error";
            }
        }
        public static string ChoiceOfBet2()
        {
            TypeOfBet();
        }
        */
    }
}
