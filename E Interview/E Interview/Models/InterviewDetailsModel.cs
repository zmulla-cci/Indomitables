using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_Interview.Models
{
    public class InterviewDetailsModel
    {
        public string Name { get; set; }
        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }
        [DisplayName("Contact Email")]
        public string ContactEmail { get; set; }
    }
}