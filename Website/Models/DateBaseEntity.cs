using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    //[Keyless]
    public class DateBaseEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Boolean IsDeleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        
    }
}
