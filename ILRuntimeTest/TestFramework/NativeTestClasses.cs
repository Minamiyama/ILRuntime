using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NativeClass
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

        //        public static MethodInfo[] GetMethods()
        //        {
        //            return typeof(TestClass).GetMethods();
        //        }
        //
        //        public static MethodInfo[] GetObjectMethods()
        //        {
        //            return typeof(object).GetMethods();
        //        }
    }
}
