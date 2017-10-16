using ClubHouse.Serialization;
using System;

namespace ClubHouse.Models
{
    public abstract class ClubHouseModel<T>
    {
        /// <summary>
        /// The unique ID
        /// </summary>
        [HideFromUpdate, HideFromCreate]
        public T Id { get; set; }

        /// <summary>
        /// A string description of this resource.
        /// </summary>
        [HideFromUpdate]
        public string EntityType { get; set; }
    }

    public abstract class UpdatableClubHouseModel<T> : ClubHouseModel<T>
    {
        /// <summary>
        /// The time/date when the resource was created.
        /// </summary>
        [HideFromUpdate]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// The time/date when the resouce was updated.
        /// </summary>
        [HideFromUpdate, HideFromCreate]
        public DateTime UpdatedAt { get; set; }
    }
}