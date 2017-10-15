using System;
using System.Collections.Generic;
using System.Text;

namespace ClubHouse.Models
{
    public class Repository : UpdatableClubHouseModel<int>
    {
        public string ExternalId { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public RepositoryType Type { get; set; }
        public string Url { get; set; }
    }

    public enum RepositoryType
    {
        GitHub
    }
}
