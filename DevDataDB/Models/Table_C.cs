using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevData.Models
{
    public class Table_C
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        public string Col_C1 { get; set; }
        [Timestamp]
        public byte[] Col_C2 { get; set; }
        public int Col_C3 { get; set; }
        [MaxLength(10)]
        public string Col_C4 { get; set; }
    }
}
