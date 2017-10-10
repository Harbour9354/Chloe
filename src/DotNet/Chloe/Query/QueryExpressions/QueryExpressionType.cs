
namespace Chloe.Query.QueryExpressions
{
    enum QueryExpressionType
    {
        Root = 1,
        Where,
        AddWhere,
        Take,
        Skip,
        OrderBy,
        OrderByDesc,
        ThenBy,
        ThenByDesc,
        Select,
        Include,
        Aggregate,
        JoinQuery,
        GroupingQuery,
        Distinct,
    }
}
