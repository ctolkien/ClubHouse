namespace ClubHouse.Models
{
    public abstract class ClubHouseModel<T>
    {
        [HideFromUpdate]
        public T Id { get; set; }
    }

}