using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// Populate this object with search terms used to search on a <see cref="Story"/>.
    /// <para>See also <seealso cref="Resources.IStoryResource.Search(StorySearch)"/></para>
    /// </summary>
    public class StorySearch
    {
        public IList<int> ProjectIds { get; set; }
        public IList<string> OwnerIds { get; set; }
        public int? Estimate { get; set; }
        public StoryType? StoryType { get; set; }
        public string Text { get; set; }
        public IList<int> EpicIds { get; set; }
        public IList<Workflow.WorkflowStateType> WorkflowStateTypes { get; set; }
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
