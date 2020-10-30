using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banrk_Lab.Workers
{
    class Chief : Worker
    {
        public Chief(string name, float salary, DateTime birthday, DateTime hireDate) : base(name, salary, birthday, hireDate) { }
        public Chief(string name, float salary, DateTime birthday) : base(name, salary, birthday) { }

        static readonly float salaryScaleMultiplier = 0.1f;
        override public float YearBonus()
        {
            return Salary * salaryScaleMultiplier;
        }
    }
}
