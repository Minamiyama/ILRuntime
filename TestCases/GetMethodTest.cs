using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ILClass;
using ILRuntimeTest.TestFramework;

namespace ILClass
{
    public class TestClassBaseBase
    {
        public void MethodInBaseBase() { }
    }

    public class TestClassBase : TestClassBaseBase
    {
        public void MethodInBase() { }
    }

    public class TestClass : TestClassBase
    {
        public void MethodInClass() { }
    }

    public class CrossBingdingTestClass : TestClass2
    {
        protected override void AbMethod1()
        {
            throw new NotImplementedException();
        }

        public override float AbMethod2(int arg1)
        {
            throw new NotImplementedException();
        }
    }
}

namespace TestCases
{
    class GetMethodTest
    {

        public static void RunTestPureClass()
        {
            var ilTest = new ILClass.TestClass();
            var nativeTest = new NativeClass.TestClass();

            Console.WriteLine("***************测试开始*************");
            MethodInfo[] methods;

            Console.WriteLine("+++++++++++++++Object所有方法+++++++++++++++");
            methods = typeof(object).GetMethods();
            PrintMethods(methods);

            Console.WriteLine("+++++++++++++++本地类+++++++++++++++");
            methods = typeof(NativeClass.TestClass).GetMethods();
            PrintMethods(methods);
            Console.WriteLine("+++++++++++++++IL类+++++++++++++++");
            methods = typeof(ILClass.TestClass).GetMethods();
            PrintMethods(methods);
            Console.WriteLine("----------------------------------");

            var found = typeof(NativeClass.TestClass).GetMethod("MethodInBaseBase") != null;
            Console.WriteLine($"[NativeClass]找到基类方法？{found}");

            found = typeof(ILClass.TestClass).GetMethod("MethodInBaseBase") != null;
            Console.WriteLine($"[ILClass]找到基类方法？{found}");

            Console.WriteLine("***************测试结束*************");
        }

        public static void _________RunTestCrossBinding()
        {
            Console.WriteLine("***************测试开始*************");
            Console.WriteLine("+++++++++++++++跨域类+++++++++++++++");
            var methods = typeof(CrossBingdingTestClass).GetMethods();
            PrintMethods(methods);
            Console.WriteLine("***************测试结束*************");
        }

        static void PrintMethods(MethodInfo[] methods)
        {
            var defaultColor = Console.ForegroundColor;
            foreach (var methodInfo in methods)
            {
                Console.Write($"Method: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{methodInfo.Name}");
                Console.ForegroundColor = defaultColor;
                Console.Write(" of class: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{methodInfo.DeclaringType.FullName}");
                Console.ForegroundColor = defaultColor;
            }
        }
    }
}
