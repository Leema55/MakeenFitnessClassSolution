using MakeenFitnessClass.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenFitnessClass.Models.fito
{
    public class FitnessClass
    {
        public string ClassName { get; set; }
        public string  schedule  { get; set; }
        public Trainer  trainer { get; set; }


        public Member[] members { get; set; }
       public int numberOfMembers { get; set; } 

        public FitnessClass(string className, string schedule, Trainer trainer,  int numberOfMembers)
        {
            this.numberOfMembers = numberOfMembers;
            ClassName = className;
            this.schedule = schedule;
            this.trainer = trainer;
            members = new Member[numberOfMembers];
        }


        public string AddMember(Member member)
        {
            if ( this.numberOfMembers < members.Count() )
            {
                members[members.Count() - 1] = member;
                return "Added Suuccesfully";

                }
            return "the Class is full sorry ";
        }    
        public string DisplayClassInfo()
        {
            string result = $"Welcome to {this.ClassName} Class " +
                $"\n the Class will be At {this.schedule} " +
                $"\n with trainer : {this.trainer.Name} ";
            return result;
        }



    }
}
