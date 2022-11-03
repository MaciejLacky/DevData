using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevData.Models
{
    public class Table_B
    {
        [Key]
        public int Id { get; set; }
        public int Col_B1 { get; set; }
        [MaxLength(10)]
        public string Col_B2 { get; set; }
        public int Col_B3 { get; set; }
    }
}
