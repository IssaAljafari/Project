using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionAssociationFooter : BaseEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ProjectTitle { get; set; }
        public string GoalsTitle { get; set; }
        public string MessageTitle { get; set; }
        public string VisionTitle { get; set; }
        public string MembersTitle { get; set; }
       
    }
}
