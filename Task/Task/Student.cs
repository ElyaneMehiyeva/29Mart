using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Student
    {
        public Student(string fullName,string groupNo,int age)
        {
            this.Age = age;
            this.FullName = fullName;
            this.GroupNo = groupNo;
        }
        private string _fullName;
        public string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                if (ChechFullName(value))
                {
                    this._fullName = value;
                }
            }
        }
        private string _groupNo;
        public string GroupNo
        {
            get
            {
                return this._groupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    this._groupNo = value;
                }
            }
        }
        public int Age;
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4)
            {
                return false;
            } else if (char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool ChechFullName(string fullname)
        {
            string[] parts = fullname.Split(' ');
            if (parts.Length != 2)
            {
                return false;
            } else
            {
                foreach (string part in parts)
                {
                    if (!char.IsUpper(part[0]))
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
