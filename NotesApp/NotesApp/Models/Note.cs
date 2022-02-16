using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(100000)]
        public string Content { get; set; }
        public bool Important { get; set; } = false;
        public int ReadCount { get; set; } = 0;
        public string Creator { get; set; } = "Default User";

        [DisplayName("Note Type")]
        public int NoteTypeId { get; set; }
        [ForeignKey("NoteTypeId")]
        public virtual NoteType NoteType { get; set; }
    }
}
