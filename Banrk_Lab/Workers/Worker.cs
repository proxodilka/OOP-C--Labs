using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banrk_Lab.Workers
{
    abstract class Worker
    {
        int uid;
        public string Name { get; }
        public float Salary { get; }

        public DateTime Birthday { get; }
        public DateTime HireDate { get; }

        public Worker(string name, float salary, DateTime birthday, DateTime hireDate)
        {
            this.Name = name;
            this.Salary = salary;
            this.Birthday = birthday;
            this.HireDate = hireDate;
        }

        public Worker(string name, float salary, DateTime birthday): this(name, salary, birthday, DateTime.Today) { }

        abstract public float YearBonus();

        public override string ToString()
        {
            return String.Format(
                "Name: {0}, Birthday: {1}, Sallary: {2}, Hire date: {3}, Current Year Bonus: {4}",
                new object[] { 
                    Name,
                    Birthday.Date.ToShortDateString(),
                    Salary,
                    HireDate.Date.ToShortDateString(),
                    YearBonus()
                }
            );
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Worker))
            {
                return false;
            }
            Worker other = obj as Worker;
            return Name == other.Name && Birthday == other.Birthday;
        }
    }
}
