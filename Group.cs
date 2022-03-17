using System;
using System.Collections.Generic;
using System.Text;

namespace _170320022
{
     internal class Group
     {
        public Group(string no,int studentLimit)
        {
            this.No = no;
            this.StudentLimit = studentLimit;
        }
        private String _no;
        private int _studentlimit;
        public String No
        {
            get => this._no;
            set
            {
                if (CheckFullName(value) && value.Length>=5)
                {
                    this._no = value;
                }
            }
        }
        public int StudentLimit
        {
            get => this._studentlimit;
            set
            {
                if (value >= 0)
                {
                    this._studentlimit = value;
                }
            }
               
        }
        static bool CheckFullName(string str)
        {
            bool HisUpper = false;
            bool HisLetter = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    HisUpper = true;
                }
                if (char.IsLetter(str[i]))
                {
                    HisLetter = true;
                }
            }
            return HisUpper && HisLetter ? true : false;
        }
     }
}
