using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.F
{
    class F3
    {
        public int a;
        public int b;
        public int c;

        public static void Main(string[] args)
        {
            Type t = typeof(F3);
            MemberInfo[] info1 = t.GetMembers();
            foreach (MemberInfo menber in info1) {
                Console.WriteLine(menber.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            MethodInfo[] info2 = t.GetMethods();
            foreach (MethodInfo method in info2) {
                Console.WriteLine(method.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();

            FieldInfo[] info3 = t.GetFields();
            foreach (FieldInfo field in info3)
            {
                Console.WriteLine(field.ToString());
            }

            Console.ReadKey();
        }
    }
}
