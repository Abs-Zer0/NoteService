using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteService.Models
{
    public class Note
    {
        public int ID { get; set; }

        [Display(Name ="Заголовок")]
        public string Head { get; set; }

        [Display(Name ="Описание"), RegularExpression(@"\S.*")]
        public string Body { get; set; }

        public bool IsEmptyHead()
        {
            return String.IsNullOrWhiteSpace(this.Head);
        }
    }
}
