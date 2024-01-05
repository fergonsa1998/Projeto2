using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    class Company : Pessoa
    {
        public int NumberEmployee { get; set; }
        public Company(string name, double anualIncome, int numberEmployee) 
            : base(name, anualIncome)
        {
            NumberEmployee = numberEmployee;
        }

        public override double Tax()
        {
            if(NumberEmployee > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
