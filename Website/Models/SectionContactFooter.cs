using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionContactFooter : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string TimeLogo { get; set; }
        public string FromDay { get; set; }
        public string ToDay { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Morning { get; set; }
        public string Evening { get; set; }
        public string EmailLogo { get; set; }
        public string Email { get; set; }
        public string MobileLogo { get; set; }
        public string Mobile { get; set; }
        public string LocationLogo { get; set; }
        public string Location { get; set; }





    }
}
