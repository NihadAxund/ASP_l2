using Lesson2.Entities;
using System.Collections.Generic;

namespace Lesson2.Models
{
    public class PersonsListViewModel
    {
        public List<Person> Persons { get; set; }
        //public PersonsListViewModel() { }
        public PersonsListViewModel(List<Person> persons) { 
            Persons = persons;
        }
    }
}
