using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Chloe.Query.QueryExpressions
{
    class AddWhereExpression : QueryExpression
    {
        string _strWhere;
        public AddWhereExpression(Type elementType, QueryExpression prevExpression, string strWhere)
           : base(QueryExpressionType.AddWhere, elementType, prevExpression)
        {
            this._strWhere = strWhere;
        }
        public string StrWhere { get { return this._strWhere; } }

        public override T Accept<T>(QueryExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
