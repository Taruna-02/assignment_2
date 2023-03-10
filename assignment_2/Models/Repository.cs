using System.Collections.Generic;
namespace assignment_2.Models
{
    
        public static class Repository { 

private static List<Employee> allEmpoyees = new List<Employee> ();
public static IEnumerable<Employee> AllEmpoyees
        {
            get { return allEmpoyees; }
        }
    public static void Create(Employee employee) { 
    allEmpoyees.Add(employee);
    }
        public static void Delete(Employee employee)
        {
            allEmpoyees.Remove(employee);
        }
        public static void Update(Employee employee) { allEmpoyees.Add(employee); }
    }
}