using schoolBagAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolBagAssignment.Services
{
    public class SchoolServices : ISchoolServices
    {
        private readonly List<School> _schools;

        public SchoolServices()
        {
            _schools = new List<School>();
        }

        public School AddSchool(School school)
        {
            school.id = Guid.NewGuid();
            _schools.Add(school);
            return school;
        }

        public List<School> GetAllSchools()
        {
            return _schools;
        }
    }
}
