using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_Try.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Books")]
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return "Id: " + BookID + ", Name: " + BookName + ", ISBN: " + ISBN;
        }
    }
}
