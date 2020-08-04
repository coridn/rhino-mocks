#if DOTNET35
using Castle.Core.Interceptor;
#elif NETSTANDARD2_0
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