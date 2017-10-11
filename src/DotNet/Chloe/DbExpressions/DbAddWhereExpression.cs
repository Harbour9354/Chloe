using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chloe.DbExpressions
{
    public class DbAddWhereExpression : DbExpression
    {
        string _strWhere;
        public DbAddWhereExpression(string strWhere)
            : base(DbExpressionType.AddWhere)
        {
            this._strWhere = strWhere;
        }
        public string StrWhere { get { return this._strWhere; } }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
