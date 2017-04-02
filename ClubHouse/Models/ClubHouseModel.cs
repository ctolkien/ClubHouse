using ClubHouse.Serialization;

namespace ClubHouse.Models
{
    public abstract class ClubHouseModel<T>
    {
        [HideFromUpdate, HideFromCreate]
        public T Id { get; set; }
    }
}