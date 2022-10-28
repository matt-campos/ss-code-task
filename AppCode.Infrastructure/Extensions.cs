using FluentMigrator.Builders.Create.Table;

namespace AppCode.Infrastructure;

public static class Extensions
{
    public static ICreateTableColumnOptionOrWithColumnSyntax AsMaxString(this ICreateTableColumnAsTypeSyntax createTableColumnAsTypeSyntax)
    {
        return createTableColumnAsTypeSyntax.AsString(int.MaxValue);
    }
}