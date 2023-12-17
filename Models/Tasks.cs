using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public DateTime EndDate {get; set;}
        public string? Description { get; set; }
    }
}