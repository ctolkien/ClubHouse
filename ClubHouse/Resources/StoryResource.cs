using ClubHouse.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubHouse.Resources
{
    internal class StoryResource : Resource<Story, int>
    {
        protected override string ResourceName => "stories";

        public StoryResource(ClubHouseHttpClient client) : base(client)
        {
        }
    }
}
