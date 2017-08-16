using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Try.Model
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        public string ReviewText { get; set; }

        // This will keep track of the book this review belong too
        public virtual Book Book { get; set; }

        public override string ToString()
        {
            return "Review Id: " + ReviewID + ", Book Id: " + BookID + ", Review Text: " + ReviewText;
        }
    }
}
