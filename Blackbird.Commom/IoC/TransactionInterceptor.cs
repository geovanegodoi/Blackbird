using System;
using System.Transactions;
using Castle.DynamicProxy;

namespace Blackbird.Commom.IoC
{
    public class TransactionInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            using(var transaction = new TransactionScope(TransactionScopeOption.Required))
            {
                invocation.Proceed();
                transaction.Complete();
            }
        }
    }
}
