using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesApp.Models.ViewModels
{
    public class NoteVM
    {
        public Note Note { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
