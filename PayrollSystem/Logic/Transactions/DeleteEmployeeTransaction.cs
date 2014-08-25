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
            // TODO: Complete member initialization
            this.empId = empId;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
