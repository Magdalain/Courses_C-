using System;


namespace Laboratornaya_6
{
    internal class Program
    {
        struct Person
        {
            private string _name;
            private int? _age;
            public Person(string Name, int? Age)
            {
                _name = Name;
                _age = Age;
            }
            public void Show()
            {
                if (_age.HasValue)
                    Console.WriteLine($"Имя: {_name}  Возраст: {_age.Value}");
                else
                    Console.WriteLine($"Имя: {_name}");
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите имя");
            string personName = Console.ReadLine();
            Console.WriteLine("Введите возраст, если есть");
            
   
            string Age = Console.ReadLine();
            int? personAge = null;
            if (!string.IsNullOrEmpty(Age))
            {
                personAge = Convert.ToInt32(Age);
            }
           
            Person person = new Person(personName, personAge);
            person.Show();
            Console.ReadLine();


        }
    }
}
