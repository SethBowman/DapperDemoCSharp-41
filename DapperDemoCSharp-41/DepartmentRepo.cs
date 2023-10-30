using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperDemoCSharp_41
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly IDbConnection _connection;

        public DepartmentRepo(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }

        public void InsertDepartment(string newName)
        {
            _connection.Execute("INSERT INTO departments (Name) VALUES (@newName);",
                new { newName });
        }
    }
}
