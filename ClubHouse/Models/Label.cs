using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// A Label can be used to associate and filter <see cref="Story">Stories</see> and <see cref="Epic">Epics</see>, and also create new Workspaces.
    /// </summary>
    public class Label : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// A true/false boolean indicating if the Label has been archived.
        /// </summary>
        public bool Archived { get; set; }

        /// <summary>
        /// The hex color to be displayed with the Label (for example, “#ff0000”).
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// This field can be set to another unique ID. In the case that the Label has been imported from another tool, the ID in the other tool can be indicated here.
        /// </summary>
        public string ExternalId { get; set; }

        /// <summary>
        /// The name of the Label.
        /// </summary>
        public string Name { get; set; }

        [JsonProperty(PropertyName = "stats")]
        public IReadOnlyCollection<LabelStatistics> Statistics { get; set; } = new Collection<LabelStatistics>();
    }
}
