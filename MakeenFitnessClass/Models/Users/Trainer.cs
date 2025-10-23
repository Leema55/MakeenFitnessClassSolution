using MakeenFitnessClass.Models.Enums;
using MakeenFitnessClass.Models.fito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenFitnessClass.Models.Users
{
    public class Trainer : Person
    {
        public string  Specialization { get; set; }
        public decimal  loggedHours { get; set; }
        public decimal  ratePerHour { get; set; }
        public List<FitnessClass> AssignedClass { get; set; }
        public Trainer(string name, string email, int age, string phoneNumber, Gender gender)
            : base(name, email, age, phoneNumber, gender)
        {
        }

        public string AssignToClass(FitnessClass fitness)
        {
            if(fitness.trainer is null)
            {
                AssignedClass.Add(fitness);
                return "Added Successfully";
            }
            else
            {
                return "the Class already has atrainer";
            }
            
        }

        public List<FitnessClass> ShowAssignedClasses()
        {
            return AssignedClass;
        }
    }
}
