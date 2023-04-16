using Lesson2.Entities;
using System.Collections.Generic;

namespace Lesson2.Models
{
    public class ADDPersonViewModel
    {
        public Person Person { get; set; }
        public ADDPersonViewModel() { }
        public ADDPersonViewModel(Person person) {  Person = person; }
    }
}
