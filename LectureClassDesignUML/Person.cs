using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureClassDesignUML
{
    class Person {

        //public string? Name { get; set; }
        //public int? Age { get; set; }
        //public Gender Gender { get; set; }
        //public Person(string name, int age, Gender gender)
        //{
        //    Name = name;
        //    Age = age;
        //    Gender = gender;

        //}
        //public string Greet()
        //{
        //    return $"say hello";
        //}
        //public string Describe()
        //{
        //    return $"this is whom I am";
        //}
        //public double EvaluateEquation(string equation)
        //{
        //    string Equation = equation;
        //    return EvaluateEquation(Equation);
        //}


        //public Person()
        //{
        //    Person p1 = new Person();
        //    p1.Name = "Nisse";
        //    p1.Age = 33;
        //    p1.Gender = Gender.Male;

        //    Person p2 = new Person();
        //    p2.Name = "Nissa";
        //    p2.Age = 45;
        //    p2.Gender = Gender.Female;

        //    Person p3 = new Person();
        //    p3.Name = "Lisa";
        //    p3.Age = 54;
        //    p3.Gender = Gender.Female;
        //}


        // Methods
        public int Hight { get; set; }
        public int Weight { get; set; }
        public string? Name { get; set; }
        public void Greet(Person otherPerson)
        {
            Console.Write($"Hello,{otherPerson.Name}!");
        }
        public double Addition(double numA, double numB) { return numA + numB; }
    }
    enum Gender
    {
        Male,
        Female
    }
}
