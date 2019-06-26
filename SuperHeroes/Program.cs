using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperHeroes
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new CreateList();
            list.create();
            list.PrintPeople();
        }
    }

    class CreateList 
    {
        static List<Person> GetPeople = new List<Person>();
        public void create()
        {
            GetPeople.Add(new Person("Martin", "Marty"));
            GetPeople.Add(new SuperHero("Superman", "Clark Kent", "Supermanne"));
            GetPeople.Add(new Villian("Lex Luther", "Superman"));

        }
        public void PrintPeople()
        {
            foreach (var person in GetPeople)
            {
                person.PrintGreeting();
            }
        }
    }
    class Person     //      Person
    {
        public virtual string Name { get; set; }
        public string NickName { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public virtual void PrintGreeting()
        {
            Console.WriteLine("Hi, my name is {0}, but you can call me {1}.", Name, NickName);
        }



        public Person(string name, string nickName) 
        {
            Name = name;
            NickName = nickName;
        }
    }



    class SuperHero : Person
    {
        public override string Name { get; set; }
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        public SuperHero(string Name, string realName, string superPower) : base(Name, null)
        {
            RealName = realName;
            SuperPower = superPower;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine("I am {0}. When I am {1}, my super power is {2}.", RealName, Name, SuperPower);
        }
    }

    class Villian : Person
    {
        public override string Name { get; set; }
        public string Nemesis { get; set; }

        public Villian(string name, string nemesis) : base(name, null)
        {
            Nemesis = nemesis;
        }


        public override void PrintGreeting()
        {
            Console.WriteLine("I am {0}. Have you seen {1}?", Name, Nemesis);
        }
    }
}