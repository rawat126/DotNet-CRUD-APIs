using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API2.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public string Student_Email { get; set; }
        public int Student_Age { get; set; }
    }

}
