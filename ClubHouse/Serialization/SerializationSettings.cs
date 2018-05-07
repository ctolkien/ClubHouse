namespace ClubHouse.Serialization
{
    internal static class SerializationSettings
    {
        public static readonly DefaultSerializerSettings Default = new DefaultSerializerSettings();

        public static readonly DefaultSerializerSettings Create = new CreateSerializerSettings();

        public static readonly DefaultSerializerSettings Update = new UpdateSerializerSettings();
    }
}
