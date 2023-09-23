using LessonA.Day_Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day_Two
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string Title { get; set; }=string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public long Phone { get; set; }

        public override string ToString()
        {
            return $"ID:{this.Id}, Name:{Title}, FirstName:{FirstName}, LastName:{LastName},\n" +
                $"Address:{Address}, City:{City}, Country:{Country},\n";
        }
        }

    }

    internal class TestPerson
    {
        public static void TestOne()
        {
            Person firstPerson = new Person();
            firstPerson.Id = 1;
            firstPerson.FirstName = "Suganth";
            firstPerson.LastName = "Sai";
            firstPerson.Address = "Royapuram";
            firstPerson.City = "chennai";
            firstPerson.Country = "India";
        String value=firstPerson.ToString();
        Console.WriteLine(value);


    }
    }

