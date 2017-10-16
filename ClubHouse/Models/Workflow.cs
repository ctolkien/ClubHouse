using System.Collections.Generic;

namespace ClubHouse.Models
{
    /// <summary>
    /// Workflow is the array of defined Workflow States.
    /// Workflow can be queried using the API but must be updated in the Clubhouse UI.
    /// </summary>
    public class Workflow : UpdatableClubHouseModel<int>
    {
        /// <summary>
        /// The unique ID of the default state that new Stories are entered into.
        /// </summary>
        public int DefaultStateId { get; set; }

        /// <summary>
        /// A description of the workflow.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A map of the states in this Workflow.
        /// </summary>
        public IReadOnlyCollection<State> States { get; set; }

        /// <summary>
        /// The ID of the team the workflow belongs to.
        /// </summary>
        public int TeamId { get; set; }


        /// <summary>
        /// Workflow State is any of the at least 3 columns. Workflow States correspond to one of 3 types: Unstarted, Started, or Finished.
        /// </summary>
        public class State : UpdatableClubHouseModel<int>
        {
            /// <summary>
            /// The hex color for this Workflow State.
            /// </summary>
            public string Color { get; set; }

            /// <summary>
            /// The description of what sort of Stories belong in that Workflow state.
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// The Workflow State’s name.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// The number of Stories currently in that Workflow State.
            /// </summary>
            public int NumStories { get; set; }

            /// <summary>
            /// The position that the Workflow State is in, starting with 0 at the left.
            /// </summary>
            public int Position { get; set; }

            /// <summary>
            /// The type of Workflow State (Unstarted, Started, or Finished)
            /// </summary>
            public WorkflowStateType Type { get; set; }

            /// <summary>
            /// The verb that triggers a move to that Workflow State when making GitHub commits.
            /// </summary>
            public string Verb { get; set; }
        }

        public enum WorkflowStateType
        {
            Unstarted,
            Started,
            Done
        }
    }
}
