using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IEmployeeRepository EmployeeRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        void Save();
    }
}
