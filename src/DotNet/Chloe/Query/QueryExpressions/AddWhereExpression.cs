using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Chloe.Query.QueryExpressions
{
    class AddWhereExpression : QueryExpression
    {
        LambdaExpression _predicate;
        public AddWhereExpression(QueryExpression prevExpression, Type elementType, LambdaExpression predicate)
            : base(QueryExpressionType.AddWhere, elementType, prevExpression)
        {
            this._predicate = predicate;
        }
        public LambdaExpression Predicate
        {
            get { return this._predicate; }
        }
        public override T Accept<T>(QueryExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
