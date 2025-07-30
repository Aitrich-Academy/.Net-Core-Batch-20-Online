using System.ComponentModel.DataAnnotations;

namespace TaskManagementApp.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }  
        public string Description { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        public DateTime DueDate { get; set; }   
        public bool IsCompleted { get; set; }  
    }


}
