using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionDivision : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string BtnTitle { get; set; }
        public string BtnColor { get; set; }
        public string MemberCounttitle { get; set; }
        
        public string Name { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public string BackgroundColor { get; set; }

    }
}
