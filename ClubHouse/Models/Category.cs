using ClubHouse.Serialization;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Category can be used to associate Milestones.
    /// </summary>
    public class Category : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// A true/false boolean indicating if the Category has been archived.
        /// </summary>
        [HideFromCreate]
        public bool Archived { get; set; }

        /// <summary>
        /// The hex color to be displayed with the Category.
        /// </summary>
        /// <example>#ff0000</example>
        public string Color { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Category has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the Category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The type of entity this Category is associated with
        /// </summary>
        [HideFromUpdate]
        public CategoryType Type { get; set; }
    }

    public enum CategoryType
    {
        Milestone
    }
}
