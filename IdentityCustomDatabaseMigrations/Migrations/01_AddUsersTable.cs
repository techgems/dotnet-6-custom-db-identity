﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabaseMigrations.Migrations;

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
            .WithColumn("Email").AsString().NotNullable().Unique()
            .WithColumn("Password").AsString().NotNullable()
            .WithColumn("PreferredName").AsString().NotNullable()
            .WithColumn("SecurityStamp").AsString().NotNullable()
            .WithColumn("LastLogin").AsDateTime().Nullable()
            .WithColumn("CreateDate").AsDateTime().NotNullable()
            .WithColumn("InviteGuid").AsGuid().Nullable()
            .WithColumn("RoleId").AsInt32().NotNullable().ForeignKey("Roles", "Id");

        Create.Table("Claims")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("Users", "Id")
            .WithColumn("Key").AsString(250).NotNullable()
            .WithColumn("Value").AsString().NotNullable();
    }
}
