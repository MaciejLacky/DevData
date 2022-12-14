using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevData.Enitites
{
    public class Table_A
    {

        [Key]
        public int Id { get; set; }
        public int Col_A1 { get; set; }
        [MaxLength(10)]
        public string? Col_A2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Col_A3 { get; set; }
    }
}
