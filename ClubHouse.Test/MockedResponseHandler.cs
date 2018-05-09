using ClubHouse.Models;
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
        private readonly Dictionary<Uri, HttpResponseMessage> _fakeGetResponses = new Dictionary<Uri, HttpResponseMessage>();
        private readonly Dictionary<Uri, HttpResponseMessage> _fakePostResponses = new Dictionary<Uri, HttpResponseMessage>();
        private readonly Dictionary<Uri, HttpResponseMessage> _fakePutResponses = new Dictionary<Uri, HttpResponseMessage>();

        public void AddFakeGetResponse(Uri uri, HttpResponseMessage responseMessage) => _fakeGetResponses.Add(uri, responseMessage);

        public void AddFakePostResponse(Uri uri, HttpResponseMessage responseMessage) => _fakePostResponses.Add(uri, responseMessage);

        public void AddFakePutResponse(Uri uri, HttpResponseMessage responseMessage) => _fakePutResponses.Add(uri, responseMessage);

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            if (request.Method == HttpMethod.Get && _fakeGetResponses.ContainsKey(request.RequestUri))
            {
                return _fakeGetResponses[request.RequestUri];
            }
            if (request.Method == HttpMethod.Post && _fakePostResponses.ContainsKey(request.RequestUri))
            {
                return _fakePostResponses[request.RequestUri];
            }
            if (request.Method == HttpMethod.Put && _fakePutResponses.ContainsKey(request.RequestUri))
            {
                return _fakePutResponses[request.RequestUri];
            }
            else
            {
                throw new Exceptions.NotFoundException($"Request Uri not found in collection. {request.Method} {request.RequestUri}");
            }
        }
    }

    internal static class MockExtensions
    {
        private const string EndPoint = "https://api.clubhouse.io/api/v2/";

        public static MockedResponseHandler Epic(this MockedResponseHandler handler)
        {
            var content = new Models.Epic
            {
                FollowerIds = new List<string> { "12345678-9012-3456-7890-123456789012" },
                Deadline = new DateTime(2016, 12, 31, 12, 30, 0, DateTimeKind.Utc),
                Position = 123,
                OwnerIds = new List<string> { "12345678-9012-3456-7890-123456789012" },
                Name = "foo",
                Comments = new List<Models.ThreadedComment>
                {
                    new Models.ThreadedComment
                    {
                        AuthorId = "12345678-9012-3456-7890-123456789012",
                        CreatedAt = new DateTime(2016,12,31,12,30,0, DateTimeKind.Unspecified),
                        UpdatedAt = new DateTime(2016,12,31,12,30,0, DateTimeKind.Unspecified),
                        Text = "foo",
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
            handler.AddFakeGetResponse(new Uri($"{EndPoint}epics/123"), responseMessage);

            handler.AddFakeGetResponse(new Uri($"{EndPoint}epics"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(new[] { content, content }, new DefaultSerializerSettings()))
            });

            handler.AddFakePutResponse(new Uri($"{EndPoint}epics/500"), responseMessage);

            return handler;
        }

        public static MockedResponseHandler Categories(this MockedResponseHandler handler)
        {
            var arrayContent = @"
[
  {
    'archived': true,
    'color': 'foo',
    'created_at': '2016-12-31T12:30:00Z',
    'entity_type': 'foo',
    'external_id': 'foo',
    'id': 497,
    'name': 'foo',
    'type': 'milestone',
    'updated_at': '2016-12-31T12:30:00Z'
  }
]";

            var content = @"
  {
    'archived': true,
    'color': 'foo',
    'created_at': '2016-12-31T12:30:00Z',
    'entity_type': 'foo',
    'external_id': 'foo',
    'id': 497,
    'name': 'foo',
    'type': 'milestone',
    'updated_at': '2016-12-31T12:30:00Z'
  }
";

            handler.AddFakeGetResponse(new Uri($"{EndPoint}categories"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(arrayContent)
            });

            handler.AddFakePostResponse(new Uri($"{EndPoint}categories"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Created,
                Content = new StringContent(content)
            });

            handler.AddFakeGetResponse(new Uri($"{EndPoint}categories/497"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(content)
            });

            handler.AddFakePutResponse(new Uri($"{EndPoint}categories/497"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(new Category
                {
                    Name = "Test Category 2",
                    Color = "#ff0000"
                }, new DefaultSerializerSettings()))
            });

            return handler;
        }

        public static MockedResponseHandler Files(this MockedResponseHandler handler)
        {
            var content = @"[
  {
    'content_type': 'foo',
    'created_at': '2016-12-31T12:30:00Z',
    'description': 'foo',
    'entity_type': 'foo',
    'external_id': 'foo',
    'filename': 'foo',
    'id': 123,
    'mention_ids': ['12345678-9012-3456-7890-123456789012'],
    'name': 'foo',
    'size': 123,
    'story_ids': [123],
    'thumbnail_url': 'foo',
    'updated_at': '2016-12-31T12:30:00Z',
    'uploader_id': '12345678-9012-3456-7890-123456789012',
    'url': 'foo'
  }
]";
            handler.AddFakeGetResponse(new Uri($"{EndPoint}files"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(content)
            });

            handler.AddFakePutResponse(new Uri($"{EndPoint}files/123"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(content.TrimStart('[').TrimEnd(']'))
            });

            return handler;
        }

        public static MockedResponseHandler Labels(this MockedResponseHandler handler)
        {
            return handler;
        }

        public static MockedResponseHandler LinkedFiles(this MockedResponseHandler handler)
        {
            return handler;
        }

        public static MockedResponseHandler Projects(this MockedResponseHandler handler)
        {
            return handler;
        }

        public static MockedResponseHandler Stories(this MockedResponseHandler handler)
        {
            return handler;
        }

        public static MockedResponseHandler Workflows(this MockedResponseHandler handler)
        {
            handler.AddFakeGetResponse(new Uri($"{EndPoint}workflows"), new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(new Workflow[]
                {
                    new Workflow()
                }))
            });

            return handler;
        }
    }
}
