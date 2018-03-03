using System;
using ILRuntime.Runtime.Intepreter;

#if !NET_4_6
namespace System
{
    public delegate void Action<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate void Action<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate void Action<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    public delegate TResult Func<T1, T2, T3, T4, T5, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
}
#endif

namespace ILRuntime.Runtime.Enviorment
{
    public partial class DelegateManager
    {
        public void RegisterMethodDelegate<T1, T2, T3, T4, T5>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5) };
            methods.Add(node);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2, T3, T4, T5, T6>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6) };
            methods.Add(node);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5, T6>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2, T3, T4, T5, T6, T7>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7) };
            methods.Add(node);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5, T6, T7>>(defaultConverter);
        }

        public void RegisterMethodDelegate<T1, T2, T3, T4, T5, T6, T7, T8>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8) };
            methods.Add(node);
            RegisterDelegateConvertor<Action<T1, T2, T3, T4, T5, T6, T7, T8>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, T5, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(TResult) };
            functions.Add(node);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, T5, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, T5, T6, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(TResult) };
            functions.Add(node);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, T5, T6, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, T5, T6, T7, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(TResult) };
            functions.Add(node);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, T5, T6, T7, TResult>>(defaultConverter);
        }

        public void RegisterFunctionDelegate<T1, T2, T3, T4, T5, T6, T7, T8, TResult>()
        {
            DelegateMapNode node = new Enviorment.DelegateManager.DelegateMapNode();
            node.Adapter = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8, TResult>();
            node.ParameterTypes = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(TResult) };
            functions.Add(node);
            RegisterDelegateConvertor<Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>>(defaultConverter);
        }
    }
}
