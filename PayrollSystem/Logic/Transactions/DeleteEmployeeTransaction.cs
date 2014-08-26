using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Transactions
{
    public class DeleteEmployeeTransaction:Transaction
    {
        private int empId;

        public DeleteEmployeeTransaction(int empId)
        {
            this.empId = empId;
        }
        public void Execute()
        {
            PayrollDatabase.DeleteEmployee(empId);
        }
    }
}
