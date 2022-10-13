using Infrastructuur.Database;
using Infrastructuur.Entities;
using Infrastructuur.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Services.Classes
{
    public class StudentenService : IStudentenService
    {
         private readonly StudenDatabase _studenDataBase;

        public StudentenService(StudenDatabase studenDataBase)
        {
            _studenDataBase = studenDataBase;
        }

        public List<Student> GetStudents()
        {
            return _studenDataBase.GetAllStudenten().ToList();
        }
    }
}
