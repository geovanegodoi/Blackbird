using System;
using Castle.DynamicProxy;

namespace Blackbird.Commom.IoC
{
    public class LoggerInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"[in] {invocation.Method.Name}");
            invocation.Proceed();
            Console.WriteLine($"[out] {invocation.Method.Name}");
        }
    }
}
