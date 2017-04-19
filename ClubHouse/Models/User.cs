using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Clubhouse User
    /// </summary>
    public class User : ClubHouseModel<string>
    {
        public bool TwoFactorAuthActivated { get; set; }
        public IReadOnlyList<Permission> Permissions { get; set; }
        public string Name { get; set; }
        public bool Deactivated { get; set; }
        public string Username { get; set; }
    }

    /// <summary>
    /// The permissions of a Clubhouse <see cref="User"/>
    /// </summary>
    public class Permission : ClubHouseModel<string>
    {
        public string Initials { get; set; }
        public string EmailAddress { get; set; }
        public bool Disabled { get; set; }
        public string GravatarHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Role { get; set; }
    }
}
