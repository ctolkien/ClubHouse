using System;
using System.Collections.Generic;

namespace ClubHouse.Models
{
    public class Workflow : ClubHouseModel<int>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IReadOnlyList<State> States { get; set; }
        public int DefaultStateId { get; set; }


        public class State : ClubHouseModel<int>
        {
            public int Position { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Color { get; set; }
            public int NumStories { get; set; }
            public string Verb { get; set; }
            public DateTime UpdatedAt { get; set; }
            public WorkflowStateType Type { get; set; }
        }

        public enum WorkflowStateType
        {
            Unstarted,
            Started,
            Done
        }

    }
}
