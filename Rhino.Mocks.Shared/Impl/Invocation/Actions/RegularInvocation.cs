using System.Reflection;
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
    public class RegularInvocation : IInvocationActionn {
        MockRepository mockRepository;
        ///<summary>
        ///</summary>
        public RegularInvocation(MockRepository mock_repository)
        {
            mockRepository = mock_repository;
        }

        ///<summary>
        ///</summary>
        public void PerformAgainst(IInvocation invocation)
        {
            object proxy = mockRepository.GetMockObjectFromInvocationProxy(invocation.Proxy);
            MethodInfo method = invocation.GetConcreteMethod();
            invocation.ReturnValue = mockRepository.MethodCall(invocation, proxy, method, invocation.Arguments);
        }
    }
}