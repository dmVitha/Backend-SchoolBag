using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolBagAssignment.Models
{
    public class School
    {
        public Guid id;
        public string SchoolName { get ; set; } //also known as a 'backing field'
        public string State { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get ; set; }
        public string NumberOfStudents { get; set; }
        public School()
        {
            
        }
       
    }
}
