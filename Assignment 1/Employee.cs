using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Employee
    {
        private int empNo;
        private string empName;
        private double salary;
        private int deptNo;

        public int EmpNo
        {
            get { return empNo; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Employee number (empno) cannot be zero.");
                empNo = value;
            }
        }

        public string EmpName
        {
            get { return empName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Employee name (ename) cannot be null or empty.");
                empName = value;
            }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Department number (deptno) cannot be zero.");
                deptNo = value;
            }
        }
    }


}

