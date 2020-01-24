
namespace Empregado.Entities
{
    class OutsourcedEmployee : Employee // Herda a classe emplyee, pois um fucnionário terceirizado, é um funcionário também
    {
        public double AdditionalCharge { get; set; }


        public OutsourcedEmployee()
        {

        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
