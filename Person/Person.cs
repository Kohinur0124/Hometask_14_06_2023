﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
            Family = false;
            Spouse = null;
            
        }
        public string Name { get; set; }

        public bool Family { get; set; }

        public Person? Spouse { get; set; }

        public static void GetMarried (Person person1 , Person person2)
        {
            if (person1.Family == false && person2.Family == false)
            {
                person1.Spouse = person2;
                person2.Spouse = person1;
                person1.Family = true;
                person2.Family = true;

                Console.WriteLine($" {person1.Name}  va  {person2.Name}  turmush qurishdi ");
            }
            else

                Console.WriteLine($" {person1.Name}  va  {person2.Name}  turmush qurishni iloji yo`q ");
        }
        public void GetMarried (Person person)
        {

            if (Family == false && person.Family == false)
            {
                person.Spouse = this;
                person.Family = true;
                Spouse = person;
                Family = true;
                Console.WriteLine($" {Name}  va  {person.Name}  turmush qurishdi ");
            }
            else

                Console.WriteLine($" {Name}  va  {person.Name}  turmush qurishni iloji yo`q ");
        }



    }
}

