using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2
{
    class Human
    {
    public string BirthDate {get; set; }
    public string FirstName {get; set; }
    public string Lastame {get; set; }
    public readonly int Age;// {get; set; }

        public Human(string birth, string fName)
            : this(birth, fName, "no name")
        {
        }

        public Human(string birth, string fName, string lName)
            : this(birth, fName, lName, 18)
        {            
        }

        public Human(string birth, string fName, string lName, int age)
        {
            BirthDate = birth;
            FirstName = fName;
            Lastame = lName;
            Age = age;
        }

        public bool Equality(Human human)
        {
            return this.Equals(human);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("12/2", "Bob", "First", 4);
            Console.WriteLine("{0} {1} {2} {3}", h1.BirthDate, h1.FirstName, h1.Lastame, h1.Age);
            h1.BirthDate = "";
            Console.WriteLine("{0} {1} {2} {3}", h1.BirthDate, h1.FirstName, h1.Lastame, h1.Age);
            //h1.Age = 1;
            Human h2 = new Human("1111", "Dan");
            Console.WriteLine("{0} {1} {2} {3}", h2.BirthDate,h2.FirstName,h2.Lastame,h2.Age);
            h2 = h1;
            h2.FirstName = "123";
            Console.WriteLine(h1.FirstName);
            Console.WriteLine(h1.Equality(h2));

                Console.ReadKey();
        }
    }
}
