using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace firstBlazorApp.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext _db;
        public EmployeeService(ApplicationDBContext db)
        {
            _db = db;
        }
        
                //CRUD komutları için
        
        public List<EmployeeInfo> GetEmployee()//select
        {
            var empList = _db.Employees.ToList();
            return empList;
        }

        public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }

        //Get Employee by Id
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.Id == id);
            return employee;
        }


        //Update Employee Info
        public string UpdateEmployee(EmployeeInfo objEmployee)
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Update Successfully";
        }


        //Delete Employee
        public string DeleteEmployee(EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete Successfully";
        }
    }
}
