using System;
using RepoDb;
using CustomIdentity.DataAccess.Entities;

namespace CustomIdentity.DataAccess
{
    public static class IdentityCustomMappers
    {
        public static void SetTableMappers()
        {
            FluentMapper.Entity<Role>().Table("Roles")
                .Primary(c => c.Id)
                .Column(c => c.Id, "Id")
                .Column(c => c.Name, "Name");

            FluentMapper.Entity<User>().Table("Users")
                .Primary(c => c.Id)
                .Column(c => c.Id, "Id")
                .Column(c => c.Email, "Email")
                .Column(c => c.Password, "Password")
                .Column(c => c.PreferredName, "PreferredName")
                .Column(c => c.SecurityStamp, "SecurityStamp")
                .Column(c => c.LastLogin, "LastLogin")
                .Column(c => c.CreateDate, "CreateDate")
                .Column(c => c.InviteGuid, "InviteGuid")
                .Column(c => c.RoleId, "RoleId");

            FluentMapper.Entity<Claim>().Table("Claims")
                .Primary(c => c.Id)
                .Column(c => c.Id, "Id")
                .Column(c => c.UserId, "UserId")
                .Column(c => c.Key, "Key")
                .Column(c => c.Value, "Value");

        }
    }
}

