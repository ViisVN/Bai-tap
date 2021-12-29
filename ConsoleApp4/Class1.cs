using System;
using System.Collections;

namespace String
{
    public class students
    {

        public string s_code;
        public string f_name;
        public string s_name;
        public string p_name;
        public int age;
        public double s_mark;
        public students(string s_code1, string f_name1, string s_name1, string p_name1, int age1, double s_mark1)
        {
            s_code = s_code1;
            f_name = f_name1;
            s_name = s_name1;
            p_name = p_name1;
            age = age1;
            s_mark = s_mark1;
        }
        public students()
        {

        }
        public void infor()
            {
            Console.WriteLine("==============================================");
            Console.WriteLine("TEN HOC SINH: {0} {1} {2} ", f_name,s_name,p_name);
                Console.WriteLine("MA SO HOC SINH: {0}", s_code);
                Console.WriteLine("TUOI: {0}", age);
            Console.WriteLine("DIEM TB: {0}", s_mark);
            Console.WriteLine("==============================================");
        }
        public string name()
        {
            string name1;
            name1 = $"{f_name} {s_name} {p_name}";
            return name1;
        }
        
    }
    
}