using System;
using System.Text;

namespace LaboratoryWork6_1_
{
    class Person
    {
        protected string Sentence { get; set; }
        protected string[] words;

        public Person(string sentence) 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Sentence = sentence;
            words = sentence.Split(',');
        }
        public virtual void Display()
        {
            for(int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
    class Employee : Person
    {
        public string Salary { get; set; }
        public Employee(string sent, string salary) : base(sent)
        {
            Salary = salary;
        }
        public override void Display()
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine(Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Заіка М.В,2002");
            p1.Display();
            Console.WriteLine();
            Employee p2 = new Employee("Заіка М.В,2002","4000$");
            p2.Display();
            Console.ReadKey();
        }
    }
}
