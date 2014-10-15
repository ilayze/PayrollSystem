using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PayrollDatabase
    {
        static Dictionary<int, Employee> _employees = new Dictionary<int, Employee>();

        public static void AddEmployee(int id,Employee e)
        {
            _employees[id] = e;
        }

        public static Employee GetEmployee(int empId)
        {
            if(_employees.ContainsKey(empId))
                return _employees[empId];
            return null;
        }

        internal static void DeleteEmployee(int empId)
        {
            _employees.Remove(empId);
        }
    }
}
