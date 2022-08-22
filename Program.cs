using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SoftUniExercises
{
    
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public double Money { get; set; }   
        }
        static void Main(string[] args)
        {
            //1. Create class named Person
            //2. Person class must contains properties - Name type string, Money type double
            //3. Read commands in the following format: {Name}<->{Money}
            //4. if the command is "STOP" , print people ORDERED DESCENDING BY MONEY!!!
            //5. Good luck!
            List<Person> list = new List<Person>();
            
            string command = Console.ReadLine();
            while (command!="STOP")
            {
                string[] splitComand = command.Split(" ");
                Person person = new Person();   
                person.Name = splitComand[0];   
                person.Money= double.Parse(splitComand[1]);
                list.Add(person);
                command = Console.ReadLine();
            }
            List<Person> sort = list.OrderByDescending(x => x.Money).ToList();
            foreach (Person per in sort)
            {
                Console.WriteLine($"{per.Name}<->{per.Money}");
            }



        }

    }

}