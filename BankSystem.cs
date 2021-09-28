using System;
using System.Runtime.CompilerServices;

namespace Task3._2
{
    class BankSystem
    {
        static void Main(string[] args)
        {

            Account account = new Account("AC-01",4500);

            while (true) { 
            
                switch (ReadUserInput()) {

                    case MenuOption.Withdraw:

                        DoWithdraw(account);

                        break;

                    case MenuOption.Deposit:

                        DoDeposit(account);

                        break;

                    case MenuOption.Print:

                        DoPrint(account);

                        break;

                    case MenuOption.Quit:

                        System.Environment.Exit(1);

                        break;
            

                }//switch
            }//while

        }//Main-thread

        static MenuOption ReadUserInput() {

            int userChoice = -1;

            do
            {
                Console.WriteLine("Choose the operation you want to perform");
                Console.WriteLine("1. " + MenuOption.Withdraw);
                Console.WriteLine("2. " + MenuOption.Deposit);
                Console.WriteLine("3. " + MenuOption.Print);
                Console.WriteLine("4. " + MenuOption.Quit);
                userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice < 1 || userChoice > 4)
                {

                    Console.WriteLine("Choose the Correct option you want to perform");
                    Console.WriteLine("1. " + MenuOption.Withdraw);
                    Console.WriteLine("2. " + MenuOption.Deposit);
                    Console.WriteLine("3. " + MenuOption.Print);
                    Console.WriteLine("4. " + MenuOption.Quit);
                    userChoice = Convert.ToInt32(Console.ReadLine());

                }
                    return (MenuOption)(userChoice - 1);

            } while (true);



        }//ReadUserInput

        public static void DoDeposit(Account account) {
            int amount = 0;
            Console.WriteLine("Please Enter Ammount to Deposit");
            amount = Convert.ToInt32(Console.ReadLine());
            if (!(account.Deposit(amount)))
            {
                Console.WriteLine("Please Enter Valid Ammount to Deposit");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            else {

                Console.WriteLine("Deposited Successfully");
            }

        }//DoDeposit

        public static void DoWithdraw(Account account) {
            int amount = 0;
            Console.WriteLine("Please Enter Ammount to Withdraw");
            amount = Convert.ToInt32(Console.ReadLine());
            if (!(account.Withdraw(amount)))
            {
                Console.WriteLine("Please Enter Valid Ammount to Withdraw");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            else
            {

                Console.WriteLine("Withdrawal Successfully");
            }


        }//DoWithdraw

        public static void DoPrint(Account account) {

            account.Print();

        }//DoPrint


    }

    public enum MenuOption 
    {

        Withdraw,
        Deposit,
        Print,
        Quit
    }


}
