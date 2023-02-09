using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Interfaces_and_Abstraction.Problem_1___2
{
    internal class Citizen : IPerson, IIdentifiable, IBirthdate
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Birthdate { get; private set; }
        public Citizen()
        {
        }
        public Citizen(string id, string name, int age, string birthdate)
        {
            Id=id;
            Name=name;
            Age=age;
            Birthdate=birthdate;
        }
    }
}
