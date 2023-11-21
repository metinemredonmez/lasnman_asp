using System;
using System.Collections.Generic;
using Abp.Authorization.Users;
using Abp.Extensions;

namespace lansman.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public User()
        {
            UserAddresses = new List<UserAddress>();
        }
        public const string DefaultPassword = "123qwe";

        public bool? IsSeller { get; set; }
        public int? TrustScore { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<UserAddress> UserAddresses { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>(),
                CreatorUser = null,
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
