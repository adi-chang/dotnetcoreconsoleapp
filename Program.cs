using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft;
using Newtonsoft.Json;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person {
                Id = 1,
                Name = "Budi",
                Age = 10
            };
            Person p2 = new Person {
                Id = 1,
                Name = "Tini",
                Age = 10
            };
            Person p3 = new Person {
                Id = 1,
                Name = "Susan",
                Age = 10
            };
            var listData = new List<Person>() {p1, p2, p3};

            string json = JsonConvert.SerializeObject(listData, Formatting.Indented);
            System.Console.WriteLine(json);
        }
    }
}
