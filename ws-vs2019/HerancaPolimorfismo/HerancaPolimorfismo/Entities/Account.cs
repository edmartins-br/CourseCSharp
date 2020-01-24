
namespace HerancaPolimorfismo.Entities
{
    class Account
    {
        public int Number { get; private set; } // o private permite que outras classes acessem esta variável mas não permite que sejam alteradas
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // PROTECTED - este valor só pode ser alterado pela propria classe ou por uma subclasse

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double ammount) // VIRTUAL significa que o metodo pode ser sobreposto ou sobrescrito em outra classe
        {
            Balance -= ammount + 5;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }
    }
}
