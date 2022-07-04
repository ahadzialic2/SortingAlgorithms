using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Person : IComparable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public Person(string Name, string Surname, DateTime DateOfBirth, double height, double weight)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
            this.height = height;
            this.weight = weight;
        }
        public int CompareTo(object? obj)
            {
                Person person = obj as Person;
                if (person != null)
                {
                    return this.height.CompareTo(person.height);
                }
                throw new NullReferenceException();
            }
        public override string ToString()
        {
            return $"Name: {this.Name}, surname: {this.Surname}, height: {this.height}";
        }
    }
}
