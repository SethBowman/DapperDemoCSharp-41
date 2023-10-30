using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemoCSharp_41
{
    public interface IDepartmentRepo
    {
        public IEnumerable<Department> GetAllDepartments();
        public void InsertDepartment(string newName);
    }
}
