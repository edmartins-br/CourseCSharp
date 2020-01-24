using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    /* sealed */ class SavingsAccount : Account // Sealed não permite que esta classe seja herdada
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpDateBalance()
        {
            Balance += Balance * InterestRate;
        }

        // public sealed override void WithDraw... o SEALED nao permite que esta operação seja utilizada em outra classe
        public override void Withdraw(double ammount) // Escrever ovverride, apertar e espaço e o Withdraw ja aparece automaticamente
        {
            // neste caso sem o BASE não desconta nada
            // Balance -= ammount;

            base.Withdraw(ammount); // chama um metodo comum da superclasse
            Balance -= 2;
        }
    }
}
