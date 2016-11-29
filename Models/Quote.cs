using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace tutorial1.Models
{
    [Table("Quotes")]
    public class Quote
    {
        public int id {get; set;}
        public string name {get; set;}
        public string quote {get; set;}
        public DateTime created_at {get; set;}
    }
}