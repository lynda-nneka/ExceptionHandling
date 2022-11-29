using System;
using System.Text.RegularExpressions;

namespace SimpleExceptionHandling
{
    public class ExceptionHandling
    {
        public void userAuthentication()
        {
            Regex regex = new Regex("[^a-zA-Z ]");
            try
            {
               Console.WriteLine("Enter your full name");
               string userName = Console.ReadLine().Trim();
    
                if (regex.IsMatch(userName)) throw new InvalidDataException
                ("please enter your name in the correct format");

                Console.WriteLine("Enter your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());

                if (userAge <= 18)
                {
                    Console.WriteLine("Can't view this show,This show is rated 18+");
                }
                else
                {
                    Console.WriteLine("now showing PPG");
                }
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidDataException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}

