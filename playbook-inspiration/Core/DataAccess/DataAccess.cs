using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<PersonModel> people = new List<PersonModel>();

        public DataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Bob", LastName = "dell" });
            people.Add(new PersonModel { Id = 2, FirstName = "Steph", LastName = "Curr" });

        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(String firstName, String lastName)
        {
            PersonModel p = new PersonModel { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }
    }
}
