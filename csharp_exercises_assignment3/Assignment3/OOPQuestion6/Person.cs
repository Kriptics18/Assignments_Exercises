using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.OOPQuestion6 {
    internal abstract class Person : IPersonService {

        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        private decimal salary;
        public List<string> Addresses { get; set; } = new List<string>();

        public Person(string name, DateTime birthDate, decimal salary) {
            Name = name;
            BirthDate = birthDate;
            Salary = salary;
        }

        public int CalculateAge() {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public decimal Salary {
            get { return salary; }
            set {
                if (value < 0) {
                    throw new ArgumentException("Salary cannot be a negative number");
                }
                salary = value;
            }
        }

        public virtual decimal CalculateSalary() {
            return Salary;
        }

        public List<string> GetAddresses() {
            return Addresses;
        }

    }
}
