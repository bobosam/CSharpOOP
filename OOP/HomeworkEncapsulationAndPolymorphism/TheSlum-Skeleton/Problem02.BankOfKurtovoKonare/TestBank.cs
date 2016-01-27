namespace Problem02.BankOfKurtovoKonare
{
    using System;
    using Problem02.BankOfKurtovoKonare.Models.Accounts;
    using Problem02.BankOfKurtovoKonare.Models.Customers;

    public class TestBank
    {
        public static void Main()
        {
            var individualCustomer = new Individual(
                                                    "+35908888888",
                                                    "Burgas Burgaska str. 45",
                                                    "Ivan",
                                                    "Ivanov",
                                                    "Popov",
                                                    123456789);

            var companyCustomer = new Company(
                                                "+3598742568",
                                                "Plovdiv Plovdivska str. 155",
                                                "Bat Gogo Ltd",
                                                1616466816);

            var depositAccount = new DepositAccount(individualCustomer, 7856.25m, 0.07m);
            var loanAccount = new LoanAccount(companyCustomer, 158789.00m, 0.12m);
            var mortgageAccount = new MortgageAccount(individualCustomer, 15789.25m, 0.17m);

            Console.WriteLine(depositAccount);
            decimal money = 525.30m;
            depositAccount.DepositMoney(money);
            Console.WriteLine("Deposit --> {0}", money);
            Console.WriteLine("New balance --> {0}", depositAccount.Balance);
            money = 300.00m;
            depositAccount.WithdrawMoney(money);
            Console.WriteLine("Withdraw --> {0}", money);
            Console.WriteLine("New balance --> {0}", depositAccount.Balance);
            int months = 15;
            Console.WriteLine("Interest for {0} months --> {1:0.00}lv.", months, depositAccount.CalculateInterest(months));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(loanAccount);
            months = 24;
            Console.WriteLine("Interest for {0} months --> {1:0.00}lv.", months, loanAccount.CalculateInterest(months));
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(mortgageAccount);
            months = 5;
            Console.WriteLine("Interest for {0} months --> {1:0.00}lv.", months, mortgageAccount.CalculateInterest(months));
        }
    }
}
