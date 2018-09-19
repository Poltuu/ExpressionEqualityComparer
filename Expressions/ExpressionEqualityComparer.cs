using Expressions.Internals;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Expressions
{
    public class ExpressionEqualityComparer : IEqualityComparer<Expression>
    {
        public bool Equals(Expression x, Expression y) => new ExpressionValueComparer().Compare(x, y);

        public int GetHashCode(Expression obj) => new ExpressionHashCodeResolver().GetHashCodeFor(obj);
    }
}