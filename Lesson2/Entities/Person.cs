using System.ComponentModel.DataAnnotations;

namespace Lesson2.Entities
{
    public class Person
    {
        // pattern="https?://(?:[a-z0-9-]+\.)+[a-z]{2,}(?:/[^/#?]+)+\.(?:jpe?g|gif|png)$"
        public int Id { get; set; }

        [Required()]
        [RegularExpression("^[a-zA-Z]+$")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required()]
        [RegularExpression("^[a-zA-Z]+$")]
        //[StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required()]
        [RegularExpression(@"https?://(?:[a-z0-9-]+\.)+[a-z]{2,}(?:/[^/#?]+)+\.(?:jpe?g|gif|png)$")]
        public string ImageUrl { get; set; }
        [Range(18, 65)]
        [Required()]

        public int Age { get; set; }
        public string About { get; set; }
        public Person( string name, string surname,
            string ımageUrl, int age, string about)
        {
            Id = 1;
            Name = name;
            Surname = surname;
            ImageUrl = ımageUrl;
            Age = age;
            About = about;
        }

        public Person( int id, string name, string surname,
            string ımageUrl, int age, string about)
        {
            Id = 1;
            Name = name;
            Surname = surname;
            ImageUrl = ımageUrl;
            Age = age;
            About = about;
        }
        public Person() { }
    }
}
