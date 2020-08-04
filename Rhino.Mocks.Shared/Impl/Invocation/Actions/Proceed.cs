#if DOTNET35
using Castle.Core.Interceptor;
#else
using Castle.DynamicProxy;
# endif
using Rhino.Mocks.Interfaces;

namespace Rhino.Mocks.Impl.Invocation.Actions
{
    ///<summary>
    ///</summary>
    public class Proceed : IInvocationActionn
    {
        ///<summary>
        ///</summary>
        public void PerformAgainst(IInvocation invocation)
        {
            invocation.Proceed();
        }
    }
}