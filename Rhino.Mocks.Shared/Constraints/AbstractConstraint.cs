﻿#region license
// Copyright (c) 2005 - 2007 Ayende Rahien (ayende@ayende.com)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Ayende Rahien nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion


namespace Rhino.Mocks.Constraints
{
	/// <summary>
	/// Interface for constraints
	/// </summary>
	public abstract class AbstractConstraint
	{
		/// <summary>
		/// Determines if the object pass the constraints
		/// </summary>
		public abstract bool Eval(object obj);

		/// <summary>
		/// Gets the message for this constraint
		/// </summary>
		/// <value></value>
		public abstract string Message { get; }

		/// <summary>
		/// And operator for constraints
		/// </summary>
		public static AbstractConstraint operator &(AbstractConstraint c1, AbstractConstraint c2)
		{
			return new And(c1, c2);
		}

		/// <summary>
		/// Not operator for constraints
		/// </summary>
		public static AbstractConstraint operator !(AbstractConstraint c1)
		{
			return new Not(c1);
		}


		/// <summary>
		/// Or operator for constraints
		/// </summary>
		public static AbstractConstraint operator |(AbstractConstraint c1, AbstractConstraint c2)
		{
			return new Or(c1, c2);
		}

		/// <summary>
		/// Allow overriding of || or &amp;&amp;
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static bool operator false(AbstractConstraint c)
		{
			return false;
		}
		/// <summary>
		/// Allow overriding of || or &amp;&amp;
		/// </summary>
		/// <param name="c"></param>
		/// <returns></returns>
		public static bool operator true(AbstractConstraint c)
		{
			return false;
		}
	}

    ///<summary>
    /// Interface for constraints that match a type
    ///</summary>
    ///<typeparam name="T">Type of the Argument</typeparam>
    public abstract class AbstractConstraint<T> : AbstractConstraint
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
        public override bool Eval(object obj)
        {
            if (obj is T)
            {
                return Eval((T) obj);
            }
            return false;
        }

        ///<summary>
        /// Determines if the object pass the constraints
        ///</summary>
        ///<param name="obj">object to evaluate</param>
        ///<returns></returns>
        public abstract bool Eval(T obj);
    }
}
