using AppCode.Infrastructure.Entities;
using FluentMigrator;

namespace AppCode.Infrastructure.Migrations;

public class SchemaMigration : AutoReversingMigration
{
    public override void Up()
    {
        CreateUserAccountTable();
        CreateUserPasswordTable();
        CreateUserFavoriteLocationTable();
    }

    private void CreateUserAccountTable()
    {
        Create.Table(nameof(UserAccount))
            .WithColumn(nameof(UserAccount.Id))
            .AsInt32()
            .Identity()
            .NotNullable()
            .PrimaryKey()
            
            .WithColumn(nameof(UserAccount.Guid))
            .AsGuid()
            .NotNullable()
            
            .WithColumn(nameof(UserAccount.Name))
            .AsString(500)
            .NotNullable()
            
            .WithColumn(nameof(UserAccount.Email))
            .AsString(500).NotNullable()
            
            .WithColumn(nameof(UserAccount.CreatedOnUtc)).AsDateTime().NotNullable()
            .WithColumn(nameof(UserAccount.Active)).AsBoolean().NotNullable();
    }

    private void CreateUserPasswordTable()
    {
        Create.Table(nameof(UserPassword))
            .WithColumn(nameof(UserPassword.Id))
            .AsInt32()
            .Identity()
            .NotNullable()
            .PrimaryKey()
            
            .WithColumn(nameof(UserPassword.Guid))
            .AsGuid()
            .NotNullable()
            
            .WithColumn(nameof(UserPassword.UserAccountId))
            .AsInt32()
            .NotNullable()
            .ForeignKey(
                $"FK_{nameof(UserPassword)}-{nameof(UserPassword.UserAccountId)}", 
                nameof(UserAccount), 
                nameof(UserAccount.Id))
            
            .WithColumn(nameof(UserPassword.Password))
            .AsMaxString()
            .NotNullable()
            
            .WithColumn(nameof(UserPassword.Salt))
            .AsMaxString()
            .NotNullable()
            
            .WithColumn(nameof(UserAccount.CreatedOnUtc)).AsDateTime().NotNullable();
    }

    private void CreateUserFavoriteLocationTable()
    {
        Create.Table(nameof(UserFavoriteLocation))
            .WithColumn(nameof(UserFavoriteLocation.Id))
            .AsInt32()
            .Identity()
            .NotNullable()
            .PrimaryKey()
            
            .WithColumn(nameof(UserFavoriteLocation.Guid))
            .AsGuid()
            .NotNullable()
            
            .WithColumn(nameof(UserFavoriteLocation.UserAccountId))
            .AsInt32()
            .NotNullable()
            .ForeignKey(
                $"FK_{nameof(UserFavoriteLocation)}-{nameof(UserFavoriteLocation.UserAccountId)}", 
                nameof(UserAccount), 
                nameof(UserAccount.Id))
            
            .WithColumn(nameof(UserFavoriteLocation.City))
            .AsMaxString()
            .NotNullable()
            
            .WithColumn(nameof(UserFavoriteLocation.Country))
            .AsMaxString()
            .NotNullable()
        
            .WithColumn(nameof(UserAccount.CreatedOnUtc)).AsDateTime().NotNullable();
    }
}