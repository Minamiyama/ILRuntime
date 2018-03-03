using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Stack;
using ILRuntime.Other;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.Intepreter
{
    class MethodDelegateAdapter<T1, T2, T3, T4, T5> : DelegateAdapter
    {
        Action<T1, T2, T3, T4, T5> action;

        public MethodDelegateAdapter()
        {

        }

        private MethodDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            if (method.HasThis)
                appdomain.Invoke(method, instance, p1, p2, p3, p4, p5);
            else
                appdomain.Invoke(method, null, p1, p2, p3, p4, p5);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new MethodDelegateAdapter<T1, T2, T3, T4, T5>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new MethodDelegateAdapter<T1, T2, T3, T4, T5>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Action<T1, T2, T3, T4, T5>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Action<T1, T2, T3, T4, T5>)dele;
        }
    }

    class MethodDelegateAdapter<T1, T2, T3, T4, T5, T6> : DelegateAdapter
    {
        Action<T1, T2, T3, T4, T5, T6> action;

        public MethodDelegateAdapter()
        {

        }

        private MethodDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            if (method.HasThis)
                appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6);
            else
                appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Action<T1, T2, T3, T4, T5, T6>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Action<T1, T2, T3, T4, T5, T6>)dele;
        }
    }

    class MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7> : DelegateAdapter
    {
        Action<T1, T2, T3, T4, T5, T6, T7> action;

        public MethodDelegateAdapter()
        {

        }

        private MethodDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            if (method.HasThis)
                appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6, p7);
            else
                appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6, p7);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Action<T1, T2, T3, T4, T5, T6, T7>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Action<T1, T2, T3, T4, T5, T6, T7>)dele;
        }
    }

    class MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8> : DelegateAdapter
    {
        Action<T1, T2, T3, T4, T5, T6, T7, T8> action;

        public MethodDelegateAdapter()
        {

        }

        private MethodDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        void InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            if (method.HasThis)
                appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6, p7, p8);
            else
                appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new MethodDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Action<T1, T2, T3, T4, T5, T6, T7, T8>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Action<T1, T2, T3, T4, T5, T6, T7, T8>)dele;
        }
    }

    class FunctionDelegateAdapter<T1, T2, T3, T4, T5, TResult> : DelegateAdapter
    {
        Func<T1, T2, T3, T4, T5, TResult> action;

        public FunctionDelegateAdapter()
        {

        }

        private FunctionDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        TResult InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
        {
            if (method.HasThis)
                return (TResult)appdomain.Invoke(method, instance, p1, p2, p3, p4, p5);
            else
                return (TResult)appdomain.Invoke(method, null, p1, p2, p3, p4, p5);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new FunctionDelegateAdapter<T1, T2, T3, T4, T5, TResult>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, TResult>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Func<T1, T2, T3, T4, T5, TResult>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Func<T1, T2, T3, T4, T5, TResult>)dele;
        }
    }

    class FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, TResult> : DelegateAdapter
    {
        Func<T1, T2, T3, T4, T5, T6, TResult> action;

        public FunctionDelegateAdapter()
        {

        }

        private FunctionDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        TResult InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6)
        {
            if (method.HasThis)
                return (TResult)appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6);
            else
                return (TResult)appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, TResult>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, TResult>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Func<T1, T2, T3, T4, T5, T6, TResult>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Func<T1, T2, T3, T4, T5, T6, TResult>)dele;
        }
    }

    class FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, TResult> : DelegateAdapter
    {
        Func<T1, T2, T3, T4, T5, T6, T7, TResult> action;

        public FunctionDelegateAdapter()
        {

        }

        private FunctionDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        TResult InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7)
        {
            if (method.HasThis)
                return (TResult)appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6, p7);
            else
                return (TResult)appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6, p7);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, TResult>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, TResult>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Func<T1, T2, T3, T4, T5, T6, T7, TResult>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Func<T1, T2, T3, T4, T5, T6, T7, TResult>)dele;
        }
    }

    class FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : DelegateAdapter
    {
        Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> action;

        public FunctionDelegateAdapter()
        {

        }

        private FunctionDelegateAdapter(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
            : base(appdomain, instance, method)
        {
            action = InvokeILMethod;
        }

        public override Delegate Delegate
        {
            get
            {
                return action;
            }
        }

        TResult InvokeILMethod(T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
        {
            if (method.HasThis)
                return (TResult)appdomain.Invoke(method, instance, p1, p2, p3, p4, p5, p6, p7, p8);
            else
                return (TResult)appdomain.Invoke(method, null, p1, p2, p3, p4, p5, p6, p7, p8);
        }

        public override IDelegateAdapter Instantiate(Enviorment.AppDomain appdomain, ILTypeInstance instance, ILMethod method)
        {
            return new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(appdomain, instance, method);
        }

        public override IDelegateAdapter Clone()
        {
            var res = new FunctionDelegateAdapter<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(appdomain, instance, method);
            res.isClone = true;
            return res;
        }

        public override void Combine(Delegate dele)
        {
            action += (Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>)dele;
        }

        public override void Remove(Delegate dele)
        {
            action -= (Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>)dele;
        }
    }
}
