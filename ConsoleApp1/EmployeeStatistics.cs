using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _empSearch;
        public EmployeeStatistics(IEmployeeSearchable empSearch)
        {
            _empSearch = empSearch;
        }
        public int CountFemaleManagers =>
          _empSearch.GetEmployeesByGenderAndPosition(Gender.Male, Position.Manager).Count();
    }
}
