using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.Migrations.Migrations;

[Migration(1)]
public class AddUsersTable : Migration
{

    public override void Down()
    {
        Delete.Table("Users");
        Delete.Table("Claims");
        Delete.Table("Roles");
    }

    public override void Up()
    {
        Create.Table("Roles")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();

        Create.Table("Users")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Email").AsString(500).NotNullable().Unique()
            .WithColumn("Password").AsCustom("nvarchar(max)").NotNullable()
            .WithColumn("PreferredName").AsString(500).NotNullable()
            .WithColumn("SecurityStamp").AsCustom("nvarchar(max)").NotNullable()
            .WithColumn("LastLogin").AsDateTime().Nullable()
            .WithColumn("CreateDate").AsDateTime().NotNullable()
            .WithColumn("IsConfirmed").AsBoolean().NotNullable().WithDefaultValue(false)
            .WithColumn("InviteGuid").AsGuid().Nullable()
            .WithColumn("RoleId").AsInt32().NotNullable().ForeignKey("Roles", "Id");

        Create.Table("Claims")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("Users", "Id")
            .WithColumn("Key").AsString(250).NotNullable()
            .WithColumn("Value").AsString().NotNullable();
    }
}

