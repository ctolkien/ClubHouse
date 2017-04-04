using Newtonsoft.Json.Linq;

namespace ClubHouse.Exceptions
{
    internal class ClubHouseErrorResponse
    {
        public string Message { get; set; }
        public JObject Errors { get; set; }

        public override string ToString()
        {
            if (Errors == null)
            {
                return Message;
            }

            return $"{Message} Error: {Errors}";
        }
    }
}
