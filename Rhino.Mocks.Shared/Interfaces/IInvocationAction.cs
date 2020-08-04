#if DOTNET35
using Castle.Core.Interceptor;
#else
using Castle.DynamicProxy;
# endif

namespace Rhino.Mocks.Interfaces
{
    ///<summary>
    ///</summary>
    public interface IInvocationActionn
    {
        ///<summary>
        ///</summary>
        void PerformAgainst(IInvocation invocation);
    }
}