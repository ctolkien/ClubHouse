using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ClubHouse.Models
{
    /// <summary>
    /// Populate this object with search terms used to search on a <see cref="Story"/>.
    /// <para>See also <seealso cref="Resources.IStoryResource.Search(StorySearch)"/></para>
    /// </summary>
    public class StorySearch
    {
        public ICollection<int> ProjectIds { get; set; } = new Collection<int>();
        public ICollection<string> OwnerIds { get; set; } = new Collection<string>();
        public int? Estimate { get; set; }
        public StoryType? StoryType { get; set; }
        public string Text { get; set; }
        public ICollection<int> EpicIds { get; set; } = new Collection<int>();
        public ICollection<Workflow.WorkflowStateType> WorkflowStateTypes { get; set; }
        public DateTime? UpdatedAtEnd { get; set; }
        public DateTime? UpdatedAtStart { get; set; }
        public int? ProjectId { get; set; }
        public int? EpicId { get; set; }
        public string LabelName { get; set; }
        public bool? Archived { get; set; }
        public string RequestedById { get; set; }
        public string OwnerId { get; set; }
        public int? WorkflowStateId { get; set; }
        public DateTime? CreatedAtStart { get; set; }

        public DateTime? CreatedAtEnd { get; set; }
    }
}
