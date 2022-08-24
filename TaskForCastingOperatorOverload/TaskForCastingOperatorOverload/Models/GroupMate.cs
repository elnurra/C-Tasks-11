using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForCastingOperatorOverload.Models
{
    class GroupMate
    {
        public string Name { get; set; }

        private Student[] _students;
        public void Sort(Student student)
        {
            
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Point>_students[i+1].Point)
                {

                }
            }
        }
        
    
    }
 }
    

