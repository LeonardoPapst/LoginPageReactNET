using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPageReactNET.Models
{
    public class Person
    {
        [Table("Person")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
