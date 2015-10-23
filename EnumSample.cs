using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.F
{
    public enum TimeDay
    {
        Moning = 0,
        Afternoon = 1,
        Evening = 2
    }

    class F2
    {
        public static void Main(string[] args)
        {
            test1();
            Console.ReadKey();
        }

        static void test1()
        {
            TimeDay time = TimeDay.Afternoon;
            Console.WriteLine(time);// 输出：Afternoon
            Console.WriteLine(time.ToString());// 输出：Afternoon

            Console.WriteLine((int)time);// 输出：1

            // Enum.Parse()方法:将字符串转换成指定的枚举类型。
            // 这个方法带3个参数:
            // 第一个参数是要使用的枚举类型。其语法是关键字typeof后跟放在括号中的枚举类名
            // 第二个参数是要转换的字符串，
            // 第三个参数是一个bool，指定在进行转换时是否忽略大小写
            // 最后，注意Enum.Parse()方法实际上返回一个对象引用, 我们需要把这个字符串显式转换为需要的枚举类型
            Console.WriteLine((TimeDay)Enum.Parse(TimeDay.Afternoon.GetType(), "evening", true));  // 输出：Evening
            Console.WriteLine((TimeDay)Enum.Parse(typeof(TimeDay), "evening", true));  // 输出：Evening

            // 根据枚举类型的值，获取对应的名称
            Console.WriteLine("{0}", Enum.GetName(typeof(TimeDay), 0));   // 输出：Moning
            Console.WriteLine("{0}", Enum.GetName(typeof(TimeDay), 1));   // 输出：Afternoon
            Console.WriteLine("{0}", Enum.GetName(typeof(TimeDay), 2));   // 输出：Evening

            Console.WriteLine("{0}", (TimeDay)0);    // 输出：Moning
            Console.WriteLine("{0}", (TimeDay)1);    // 输出：Afternoon
            Console.WriteLine("{0}", (TimeDay)2);    // 输出：Evening

            // 获取枚举的所有的值 
            foreach (int i in Enum.GetValues(typeof(TimeDay))) {
                Console.Write("{0} ", i.ToString());
            } // 输出：0 1 2 
            Console.WriteLine();

            // 获取枚举的所有的名称
            foreach (string name in Enum.GetNames(typeof(TimeDay))) {
                Console.Write("{0} ", name);
            } // 输出：Moning Afternoon Evening
            Console.WriteLine();

        }
    }
}
