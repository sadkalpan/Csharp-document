using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_app
{
    class student
    {
        private int no;
        private string name;
        private string lastname;
        private int midterm1;
        private int midterm2;
        private int final;
        private string schoolname;

        public student(int _no, string _name, string _lastname, int _midterm1, int _midterm2, int _final, string _schoolname)
        {
            no = _no;
            name = _name;
            lastname = _lastname;
            midterm1 = _midterm1;
            midterm2 = _midterm2;
            final = _final;
            schoolname = _schoolname;
        }

        public void studentinfo()
        {
            Console.WriteLine("student number :" + no);
            Console.WriteLine("student name: " + name);
            Console.WriteLine("student lastname:" + lastname);
            Console.WriteLine("student's first midterm:" + midterm1);
            Console.WriteLine("student's second midterm:" + midterm2);
            Console.WriteLine("student's final:" + final);
        }

        public double notecalculator()
        {
            double averagenote = midterm1 * 0.2 + midterm2 * 0.2 + final * 0.6;
            return averagenote;
        }

        public void scname()
        {
            Console.WriteLine("school name:" + schoolname);
        }




    }
}
