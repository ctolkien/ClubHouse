# ClubHouse

This is a .NET Standard 1.4 library for the [Clubhouse.io](https://clubhouse.io) API. 

Non-blocking async turtles all the way down!

| Platform | Status|
|---------|-------|
|Windows  | [![Build status](https://img.shields.io/appveyor/ci/Soda-Digital/clubhouse.svg?maxAge=200)](https://ci.appveyor.com/project/Soda-Digital/clubhouse) |
|Linux | [![Build Status](https://img.shields.io/travis/ctolkien/ClubHouse.svg?maxAge=200)](https://travis-ci.org/ctolkien/ClubHouse) |

![Version](https://img.shields.io/nuget/v/ClubHouse.svg?maxAge=200)
![license](https://img.shields.io/github/license/ctolkien/ClubHouse.svg?maxAge=2592000)


```
install-package ClubHouse
```
or 
```
dotnet add package ClubHouse
```

## Getting Started

```csharp
var client = new ClubHouseClient("yourApiKey");
```

You can get your API key via the settings page of the Clubhouse.io website

This API closely follows the structure of the official [API documentation](https://clubhouse.io/api/v1/).

Most endpoints support the capability to:

* List all resources
* Get an individual resource
* Update a specific resource
* Create a new resource
* Delete an existing resource

If it's not exposed on the API surface, then it probably means it's not available via the API. As an example, you cannot create new `Files` via the API, `Workflows` only allow you to `List`, etc.

Some endpoints, such as  `Stories` allow you to perform bulk operations.

### Sample

```csharp
//list
var epics = await client.Epics.List();

//get individual epic by id
var epic = await client.Epics.Get(123);

//update an existing record
epic.State = EpicState.InProgress;
await client.Epics.Update(epic);

//create new
await client.Epics.Create(new Epic { Name = "New Epic" });

//delete by id
await client.Epics.Delete(123);

```
