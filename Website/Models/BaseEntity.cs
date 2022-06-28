using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class BaseEntity
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CreationUserID { get; set; }
        public virtual User CreationUser { get; set; }
        public DateTime CreationDate { get; set; }


        public int? ModifyUserID { get; set; }
        public virtual User ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }

        public Boolean IsDeleted { get; set; }

        public int? DeleteUserID { get; set; }
        public virtual User DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        

    }
}
