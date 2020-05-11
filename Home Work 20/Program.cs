using System;

using System.Collections;

using System.Collections.Generic;

using System.Reflection.PortableExecutable;

using System.Runtime.CompilerServices;

using System.Linq;



//using lesson3.ViewModel;



namespace HomeWork20

{

    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            //string[] Letter = { "A", "B", "S", "D", "F"};

            //IEnumerable<string> Let = from i in Letter

            //                           select i;

            //foreach (var i in Let.Reverse())

            //{
            //    Console.WriteLine(i);
            //}

            //Задача 2

            //int[] numbers = { 1, 2, 3, 4, 5, -6, -7, -8, -9 };

            //IEnumerable<int> number = from i in numbers

            //                       where i > 0

            //                       select i;

            //IEnumerable<int> number2 = from a in numbers

            //                        where a < 0

            //                        select a;

            //Console.WriteLine(number.Count());

            //Console.WriteLine(number2.Sum());


            //Задача 3

            //List<Person> person = new List<Person>();


            //person.Add(new Person { LastName = "Ali" });

            //person.Add(new Person { LastName = "Vali" });

            //person.Add(new Person { LastName = "Sami" });

            //person.Add(new Person { LastName = "Sali" });
         
            //var items = from a in person

            //            orderby a.LastName.Length
            //            select a;

            //foreach (var i in items)

            //{
           //    Console.WriteLine(i.LastName);            
            //}


            //Задача 4

            //List<int> ages = new List<int> { 2, 2, 2, 4, 2, 2 };

            //var list = ages.GroupBy(x => x).Where(p => p.ToList().Count == 1).Select(p => p.Key);

            //foreach (var item in list)

            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
        //internal class Person
        //{
        //    public string LastName { get; set; }         
        //}
    }
}
