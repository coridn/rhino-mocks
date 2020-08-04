#if NETSTANDARD2_0
using System;
using System.Reflection.Emit;

namespace Rhino.Mocks.Shared
{
	/// <summary>
	/// 
	/// </summary>
	public static class TypeBuilderExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="typeBuilder"></param>
		/// <returns></returns>
		public static Type CreateType(this TypeBuilder typeBuilder)
		{
			return typeBuilder.DeclaringType;
		}
	}
}
#endif
