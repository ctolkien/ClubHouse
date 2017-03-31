using System.Collections.Generic;
using System.Threading.Tasks;
using ClubHouse.Models;
using System;

namespace ClubHouse.Resources
{
    internal class LinkedFileResource : Resource<LinkedFile, int>, ILinkedFileResource
    {
        protected override string ResourceName => "linked-files";
        internal LinkedFileResource(ClubHouseHttpClient client) : base(client)
        {
        }


    }

    public interface ILinkedFileResource
    {

    }
}
