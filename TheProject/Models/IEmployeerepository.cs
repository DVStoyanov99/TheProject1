using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.Models
{
    public interface _IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}
