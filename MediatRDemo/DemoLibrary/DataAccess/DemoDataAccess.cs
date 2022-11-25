using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private readonly List<PersonModel> _people = new();

        public DemoDataAccess()
        {
            _people.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            _people.Add(new PersonModel { Id = 2, FirstName = "Sue", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return _people;
        }

        public PersonModel GetPerson(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new() { FirstName = firstName, LastName = lastName };
            p.Id = _people.Max(p => p.Id) + 1;
            _people.Add(p);
            return p;
        }
    }
}
