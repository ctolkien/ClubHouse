namespace ClubHouse.Models
{
    /// <summary>
    /// Details about individual Clubhouse user within the Clubhouse organization that has issued the token.
    /// </summary>
    public class Member : UpdatableClubHouseModel<string>
    {
        /// <summary>
        /// True/false boolean indicating whether the <see cref="Member"/> has been disabled within this Organization.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// A group of Member profile details.
        /// </summary>
        public Profile Profile { get; set; }

        /// <summary>
        /// The Member’s role in the Clubhouse organization.
        /// </summary>
        public string Role { get; set; }
    }

    /// <summary>
    /// Details about individual Clubhouse user’s profile within the Clubhouse organization that has issued the token.
    /// </summary>
    public class Profile : ClubHouseModel<string>
    {
        /// <summary>
        /// A true/false boolean indicating whether the Member has been deactivated within Clubhouse.
        /// </summary>
        public bool Deactivated { get; set; }

        /// <summary>
        /// The Member’s avatar Icon.
        /// </summary>
        public string DisplayIcon { get; set; }

        /// <summary>
        /// The primary email address of the Member with the Organization.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// This is the gravatar hash associated with <see cref="EmailAddress"/>.
        /// </summary>
        public string GravatarHash { get; set; }

        /// <summary>
        /// The Member’s username within the Organization.
        /// </summary>
        public string MentionName { get; set; }

        /// <summary>
        /// The Member’s name within the Organization.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// If Two Factor Authentication is activated for this User.
        /// </summary>
        public bool TwoFactorAuthActivated { get; set; }
    }
}
