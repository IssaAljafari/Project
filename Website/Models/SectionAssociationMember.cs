﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionAssociationMember : BaseEntity
    {
        [Key]
        public int ID { get; set; } 
        public string HeaderTitle { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string DestinationURL { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
        public string BackgroundColor { get; set; }



    }
}
