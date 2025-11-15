using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentListApp.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // SQL Server will auto-generate this

        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
}
