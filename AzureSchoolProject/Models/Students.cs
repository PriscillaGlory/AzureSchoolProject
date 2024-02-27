using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace AzureSchoolProject.Models
{ 
    [Table("Students")]

    public class Students
    {
    [Key]
        public int StudentId { get; set; }

        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public string ?Course { get; set; }
    }
}
