using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjectDemo1.Models
{
    public abstract class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public Status Status { get; set; }
    }
}
