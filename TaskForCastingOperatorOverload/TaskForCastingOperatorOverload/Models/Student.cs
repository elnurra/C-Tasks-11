using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForCastingOperatorOverload.Models
{
    class Student : Person
    {
        private float _point;
        public float Point
        {
            get { return _point; }
            set
            {
                if (value >= 0)
                {
                    _point = value;
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Point: {Point}");
        }

        public static float operator >(Student s1, Student s2) 
        {
            if (s1.Point>s2.Point)
            {
                return s1.Point;
            }
            return s2.Point;
        }
        public static float operator <(Student s1, Student s2) 
        {
            if (s1.Point < s2.Point)
            {
                return s2.Point;
            }
            return s1.Point;
        }

    }
}
