﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApps
{
    class Student
    {
        public string regNo;
        public string firstName;
        public string lastName;

        public string GetFullName(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
