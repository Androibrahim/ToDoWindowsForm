using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }        

        [MaxLength(50)]
        public string Name { get; set; }

        public int userId { get; set; }     

        // navigation property
        public List<Note> notes { get; set; }       
    }
}
