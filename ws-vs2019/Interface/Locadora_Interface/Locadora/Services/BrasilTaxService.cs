

namespace Locadora.Services
{
    class BrasilTaxService : ITaxService // realização de interface, não é herança
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
