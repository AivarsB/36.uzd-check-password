using System;

namespace _36.uzd_check_password
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result1 = true;
            do
            {
                Console.Write("Enter password (minimum 8 characters, use numbers and letters): ");
                var password1 = Console.ReadLine();

                if (password1.Length < 8)
                {
                    Console.WriteLine("Password is not at least 8 characters long");
                }

                else { result1 = false; }

                
                var y = password1.Contains("a");
                
                Console.WriteLine(y);


            }

            while (result1);

            Console.WriteLine("First password looks ok");

            









            //if (password1 != password2)
            //{
            //    Console.WriteLine("Password entered is not the same");
            //}
            //else
            //{
            //    Console.WriteLine("Password ok");
            //}


        }
    }
}
// Izveidot aplikāciju, kura validēs paroli:
// 1) Paroles garumu, min garums ir 8 simboli
// 2) Pārbaudīs vai ievadītās paroles sakrīt
// 3) Pārbaudīs vai parolē ir skaitļi un burti

// - Modificēt programmu tā, lai tā izmantotu metodes paroles pārbaudei.
// - Modificēt programmu tā, lai paroles validācijas metodes atrastos atsevišķā failā
// - Modificēt programmu tā, lai paroles validācijas metodes atrastos citā bibliotēkā (citā projektā)
// - Izveidot WPF aplikāciju, kura izmanto jaunizveidoto bibliotēku ievadītās paroles pārbaudei