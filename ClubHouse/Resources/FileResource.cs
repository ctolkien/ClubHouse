using ClubHouse.Models;

namespace ClubHouse.Resources
{
    internal class FileResource : Resource<File, int>
    {
        protected override string ResourceName => "files";
        internal FileResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }
}
