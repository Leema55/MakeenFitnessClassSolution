using MakeenFitnessClass.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenFitnessClass.Models.Users
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Email Validation
        
        [EmailAddress]
        public string Email { get; set; }

        public int age { get; set; }
        public string PhoneNumber { get; set; }

        public Gender gender { get; set; }


        public Person(string name, string email, int age, string phoneNumber, Gender gender)
        {
            Name = name;
            Email = email;
            this.age = age;
            PhoneNumber = phoneNumber;
            this.gender = gender;
        }
        public virtual string DisplayInfo()
        {
            return $"Name : {this.Name} \n" +
                   $" Email : {this.Email} \n" +
                   $" Phone Number : {this.PhoneNumber}";
        }


    }
}
