using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace db2.data
{
    class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // k ničemu
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int ClassroomId { get; set; }
        [ForeignKey("ClassroomId")]
        public Classroom Classroom { get; set; }
   
        
    }
}
