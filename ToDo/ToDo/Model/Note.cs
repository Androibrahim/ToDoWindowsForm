using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string? Content { get; set; }
        public byte priority { get; set; }  
        public DateTime CreatedAt { get; set; }
        public DateTime? RemiderDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool isDeleted { get; set; }
        public byte? RemiderBeforeDays { get; set; }
        public DateTime? LastDate { get; set; }

        public DateTime? CompleteDate { get; set; }

        public int userId { get; set; }     
        // Navigation properties
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
