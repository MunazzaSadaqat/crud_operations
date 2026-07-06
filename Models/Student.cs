using System.ComponentModel.DataAnnotations;

namespace crud_operations.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }  
        public string Qualification { get; set; }  
        public string Contact { get; set; }  
        public string City { get; set; }  
    }
}
