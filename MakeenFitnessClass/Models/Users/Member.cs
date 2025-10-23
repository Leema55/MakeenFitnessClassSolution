using MakeenFitnessClass.Models.Enums;
using MakeenFitnessClass.Models.fito;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenFitnessClass.Models.Users
{
    
    public class Member : Person
    {
        public MemberShipType memberType { get; set; }
        public List<FitnessClass> regesteredClasses { get; set; }

        public Member(string name, string email, int age, string phoneNumber, Gender gender, MemberShipType memberShip)
            : base(name, email, age, phoneNumber, gender)
        {
            this.memberType = memberShip;
            regesteredClasses = new List<FitnessClass>();
        }
        public string RegisterToClass(FitnessClass fitness)
        {
            if (fitness.numberOfMembers < fitness.members.Count())
            {
                fitness.members[fitness.members.Count() - 1] = this;
                this.regesteredClasses.Add(fitness);
                return "registered Successfully ";
            }
            else
            {
                return "already full we will put you on the waiting list ";
            }
        }


        public List<FitnessClass> ShowAllRegiesteredClasses()
        {
            return regesteredClasses;
        }
    }
}
