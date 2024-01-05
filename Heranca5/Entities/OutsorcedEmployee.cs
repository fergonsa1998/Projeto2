namespace Heranca5.Entities
{
    class OutsorcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }


        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }


        public OutsorcedEmployee() 
        {
        }

        public OutsorcedEmployee(string name, int hours, double valuePerHour, double additionalcharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalcharge;
        }


    }
}
