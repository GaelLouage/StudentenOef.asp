using Infrastructuur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Services.Interfaces
{
    public interface IStudentenService
    {
        public List<Student> GetStudents();
    }
}
