using System;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Anna", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


            // ============ UPCASTING DOWNCASTING ===============
            /*
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            // BusinessAccount acc5 = (BusinessAccount)acc3; // instanciado no saving account - não é compativel - compilador não deu erro, mas não funcionará

            // Downcasting é uma operação insegura, é preciso testar se a variavel é do tipo que voce quer.
            // Usar comente quando muito necessário

            if (acc3 is BusinessAccount) // se acc3 for um BusinessAccount, faça:
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                // Outra forma de fazer a linha acima
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc5 = (SavingsAccount)acc3;
                // Outra forma de fazer a linha acima
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpDateBalance();
                Console.WriteLine("Update!");
            }
            */

        }
    }
}
