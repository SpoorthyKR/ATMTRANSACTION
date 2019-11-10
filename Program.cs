
//ATM TRANSCATION PROBLEM
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000, withdrawal;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Enter your pin Number");
            pin = int.Parse((Console.ReadLine()));
            while(true)
            {
                Console.WriteLine("****Welcome to ATM SERVICES*****");
                Console.WriteLine("1.CheckBalance\n");
                Console.WriteLine("2.Withdrawal Cash\n");
                Console.WriteLine("3.Deposit Cash\n");
                Console.WriteLine("4.QUIT\n");

                Console.WriteLine("Enter your Choice:");
                choice = int.Parse(Console.ReadLine());

            switch(choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IN RS:{0}", amount);
                        break;

                    case 2:
                        Console.WriteLine("Enter the amount to WITHDRAW:");
                        withdrawal = int.Parse(Console.ReadLine());
                        if(withdrawal % 100 != 0)
                        {
                            Console.WriteLine("\n Please enter the amount in multiples of 100 ");
                        }
                        else if(withdrawal>(amount-500))
                            {
                            Console.WriteLine("\nInsufficient Balance");
                            }
                        else
                        {
                            amount = amount - withdrawal;
                            Console.WriteLine("\n\n Please Collect Cash");
                            Console.WriteLine("\n Your Current Balance is{0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank You for using atm services");
                        break;



                }

            }

        }
    }
}
