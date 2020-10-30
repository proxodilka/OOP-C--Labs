using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banrk_Lab.Workers
{
    class Saler : Worker
    {
        public Saler(string name, float salary, DateTime birthday, DateTime hireDate): base(name, salary, birthday, hireDate) { }
        public Saler(string name, float salary, DateTime birthday): base(name, salary, birthday) { }

        static readonly float[] salaryScaleMultipliers = { 0, 0.03f, 0.05f, 0.07f };
        override public float YearBonus() {
            int yearsWorked = (DateTime.Now - this.HireDate).Days / 365;
            int normalizerMultiplier = NormalizeWorkedYears(yearsWorked);
            return Salary * salaryScaleMultipliers[normalizerMultiplier];
        }

        int NormalizeWorkedYears(int yearsWorked)
        {
            int result;

            if (yearsWorked >=5 && yearsWorked < 10)
            {
                result = 1;
            }
            else if (yearsWorked > 10)
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
