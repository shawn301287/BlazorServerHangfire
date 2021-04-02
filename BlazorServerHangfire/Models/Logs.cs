using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerHangfire.Models
{
    [Table("Logs")]
    public class Logs
    {
        [Key]
        public Guid Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}
