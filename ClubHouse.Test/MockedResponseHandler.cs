using ClubHouse.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClubHouse.Test
{
    internal class MockedResponseHandler : DelegatingHandler
    {
        private readonly Dictionary<Uri, HttpResponseMessage> _FakeGetResponses = new Dictionary<Uri, HttpResponseMessage>();
        private readonly Dictionary<Uri, HttpResponseMessage> _FakePostResponses = new Dictionary<Uri, HttpResponseMessage>();
        private readonly Dictionary<Uri, HttpResponseMessage> _FakePutResponses = new Dictionary<Uri, HttpResponseMessage>();
        private readonly Dictionary<Uri, HttpResponseMessage> _FakeDeleteResponses = new Dictionary<Uri, HttpResponseMessage>();


        public void AddFakeGetResponse(Uri uri, HttpResponseMessage responseMessage)
        {
            _FakeGetResponses.Add(uri, responseMessage);
        }
        public void AddFakePostResponse(Uri uri, HttpResponseMessage responseMessage)
        {
            _FakePostResponses.Add(uri, responseMessage);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (request.Method == HttpMethod.Get && _FakeGetResponses.ContainsKey(request.RequestUri))
            {
                return _FakeGetResponses[request.RequestUri];
            }
            if (request.Method == HttpMethod.Post && _FakePostResponses.ContainsKey(request.RequestUri))
            {
                return _FakePostResponses[request.RequestUri];
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound) { RequestMessage = request };
            }

        }

    }

    static class MockExtensions
    {
        const string EndPoint = "https://api.clubhouse.io/api/v1/";

        public static MockedResponseHandler Epic(this MockedResponseHandler handler)
        {
            var content = new Models.Epic
            {
                FollowerIds = new List<string> { "12345678-9012-3456-7890-123456789012" },
                Deadline = new DateTime(2016, 12, 31, 12, 30, 0, DateTimeKind.Utc),
                Position = 123,
                OwnerIds = new List<string> { "12345678-9012-3456-7890-123456789012" },
                Name = "foo",
                Comments = new List<Models.Comment>
                {
                    new Models.Comment
                    {
                        AuthorId = "12345678-9012-3456-7890-123456789012",
                        CreatedAt = new DateTime(2016,12,31,12,30,0, DateTimeKind.Unspecified),
                        UpdatedAt = new DateTime(2016,12,31,12,30,0, DateTimeKind.Unspecified),
                        Text = "foo",
                        Deleted = true,
                        Id = 123

                    }
                },
                Archived = true,
                Description = "foo",
                State = Models.EpicState.ToDo,
                CreatedAt = new DateTime(2016, 12, 31, 12, 30, 0, DateTimeKind.Unspecified),
                UpdatedAt = new DateTime(2016, 12, 31, 12, 30, 0, DateTimeKind.Unspecified),
                Id = 123

            };


            var responseMessage = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Created,
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(content, new DefaultSerializerSettings()))
            };

            handler.AddFakeGetResponse(new Uri($"{EndPoint}epics/1"), responseMessage);

            return handler;
        }
    }
}
