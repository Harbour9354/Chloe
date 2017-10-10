using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloe.DbExpressions
{
    public class DbAddWhereExpression : DbExpression
    {
        string _value;
        public DbAddWhereExpression(string value)
            : base(DbExpressionType.AddWhere)
        {
            this._value = value;
        }
        public object Value { get { return this._value; } }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
