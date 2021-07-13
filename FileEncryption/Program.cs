using System;

namespace FileEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            startMenu();
            string input = Console.ReadLine();
            FileOption fileOption = new FileOption();
            do
            {
                switch (input)
                {
                    case "0":
                        startMenu();
                        input = Console.ReadLine();
                        break;
                    case "1":
                        fileOption.cipherFile();
                        message("Option");
                        input = Console.ReadLine();
                        break;
                    case "2":
                        fileOption.cipherFolder();
                        message("Option");
                        input = Console.ReadLine();
                        break;
                    case "3":
                        fileOption.decipherFile();
                        message("Option");
                        input = Console.ReadLine();
                        break;
                    case "4":
                        fileOption.decipherFolder();
                        message("Option");
                        input = Console.ReadLine();
                        break;
                }
            } while (input != "99");
        }
        private static void message(string msg)
        {
            Console.WriteLine(msg);
        }
   

        private static void startMenu()
        {
            Console.WriteLine("Select option");
            Console.WriteLine("0.Start menu");
            Console.WriteLine("1.Encrypt file");
            Console.WriteLine("2.Encrypt folder");
            Console.WriteLine("3.Decipher file");
            Console.WriteLine("4.Decipher folder");
            Console.WriteLine("99.Out");
        }
    }
}
