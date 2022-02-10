using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItem
    {
        [Display(Name = "Note ID")]
        public int NoteId { get; set; }

        public string Title { get; set; }

        [UIHint("Starred")]
        [Display(Name = "Important")]
        public bool IsStarred { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreateUtc { get; set; }
    }
}