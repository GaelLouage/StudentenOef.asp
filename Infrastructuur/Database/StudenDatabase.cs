using Infrastructuur.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructuur.Database
{
    public class StudenDatabase
    {
        public IEnumerable<Student> GetAllStudenten()
        {
            string studentenFile = @"C:\Users\louag\source\repos\StudentenPunten\Infrastructuur\Database\Studenten.txt";
            string puntenFile = @"C:\Users\louag\source\repos\StudentenPunten\Infrastructuur\Database\Punten.txt";
            if (File.Exists(studentenFile) && File.Exists(puntenFile))
            {
                string[] studenten = File.ReadAllLines(studentenFile);
                string[] punten = File.ReadAllLines(puntenFile);
                for (int i = 0; i < studenten.Length; i++)
                {
                    string[] studSplit = studenten[i].Split(" ");
                    yield return new Student
                    {
                        FirstName = studSplit[0],
                        LastName = studSplit[1],
                        Punten = int.Parse(punten[i])
                    };
                }
            }
        }
    }
}
