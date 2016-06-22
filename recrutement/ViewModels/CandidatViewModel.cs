using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace recrutement.ViewModels
{
    public class CandidatViewModel
    {
        public string[] LastName { get; set; }
        public string[] FirstName { get; set; }
        public string[] Email { get; set; }
        public string[] HomePhone { get; set; }
        public string[] MobilePhone { get; set; }
        public string[] Birthday { get; set; }
        public string[] Website { get; set; }
        public string[] Address { get; set; }
        public string[] EnrollmentDate { get; set; }
    }
}