using System.ComponentModel.DataAnnotations.Schema;

namespace LoginPageReactNET.Models
{
    [Table("Person")]
    public class Person
    {
        
        [Column("Id")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Password")]
        public string Password { get; set; }
    }
}
