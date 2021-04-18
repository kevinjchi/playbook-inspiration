using Core.Models;
using System.Collections.Generic;

namespace Core.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}