using schoolBagAssignment.Models;
using System.Collections.Generic;

namespace schoolBagAssignment.Services
{
    public interface ISchoolServices
    {
        School AddSchool(School school);
        List<School> GetAllSchools();
    }
}