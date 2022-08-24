using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForCastingOperatorOverload.Models
{
    class Teacher : Person
    {
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value>0)
                {
                    _salary = value;
                }
            }
        }
        public override void ShowInfo()
        {
            throw new Exception();
        }
        public static double operator >(Teacher t1, Teacher t2) 
        {
            if (t1.Salary>t2.Salary)
            {
                return t1.Salary;
            }
            return t2.Salary;
        }
        public static double operator <(Teacher t1, Teacher t2)
        {
            if (t1.Salary < t2.Salary)
            {
                return t2.Salary;
            }
            return t1.Salary;

        }

    }
}
